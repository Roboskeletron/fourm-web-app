using AutoMapper;
using Forum.Application.Common.Extensions;
using Forum.Application.Common.Models;
using Forum.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Comments.Queries.GetMessageComments;
public class GetMessageCommentsQueryHandler : IRequestHandler<GetMessageCommentsQuery, PagedList<CommentDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetMessageCommentsQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<PagedList<CommentDto>> Handle(GetMessageCommentsQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Message
            .AsNoTracking()
            .AsSplitQuery()
            .Where(x => !x.IsDeleted && x.Id == request.MessageId)
            .Include(x => x.Comments.Where(x => !x.IsDeleted))
                .ThenInclude(x => x.Author)
            .SelectMany(x => x.Comments)
            .Select(x => new CommentDto
            {
                Id = x.Id,
                MessageId = x.MessageId,
                Text = x.Text,
                Author = _mapper.Map<AuthorDto>(x.Author),
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            })
            .OrderBy(x => x.CreatedAt)
            .ToPagedListAsync(request.Pagination, cancellationToken);
    }
}
