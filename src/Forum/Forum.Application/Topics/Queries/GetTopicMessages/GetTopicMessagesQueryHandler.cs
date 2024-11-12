﻿using AutoMapper;
using Forum.Application.Common.Extensions;
using Forum.Application.Common.Intrefaces;
using Forum.Application.Common.Models;
using Forum.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Topics.Queries.GetTopicMessages;
public class GetTopicMessagesQueryHandler : IRequestHandler<GetTopicMessagesQuery, PagedList<MessageDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IUserProvider _userProvider;
    private readonly IMapper _mapper;

    public GetTopicMessagesQueryHandler(IApplicationDbContext dbContext, IUserProvider userProvider, IMapper mapper)
    {
        _dbContext = dbContext;
        _userProvider = userProvider;
        _mapper = mapper;
    }

    public async Task<PagedList<MessageDto>> Handle(GetTopicMessagesQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Message
            .Where(x => x.TopicId == request.TopicId && !x.IsDeleted)
            .Where(x => string.IsNullOrEmpty(request.SearchQuery) ||
                        EF.Functions.Like(x.Text, $"%{request.SearchQuery}%"))
            .Include(x => x.Author)
            .Select(x => new MessageDto
            {
                Id = x.Id,
                Text = x.Text,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                Author = _mapper.Map<AuthorDto>(x.Author),
                TopicId = x.TopicId,
                LikeCount = x.Likes.LongCount(),
                CanLike = _userProvider.User == null || !x.Likes.Any(x => x.UserId == _userProvider.User.Id),
            })
            .OrderBy(x => x.CreatedAt)
            .AsNoTracking()
            .AsSplitQuery()
            .ToPagedListAsync(request.Pagination, cancellationToken);
    }
}
