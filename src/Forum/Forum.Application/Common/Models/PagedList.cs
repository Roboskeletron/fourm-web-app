using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Common.Models;
public record PagedList<T>
{
    public required IEnumerable<T> Items { get; init; }

    public int Count { get; init; }
}
