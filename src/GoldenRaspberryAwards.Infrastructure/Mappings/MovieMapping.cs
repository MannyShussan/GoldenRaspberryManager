using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenRaspberryAwards.Infrastructure.Mappings;

public static class MovieMapper
{
    public static Movie Map(MovieCsv csv)
    {
        return new Movie
        {
            Title = csv.Title,
            Year = csv.Year,
            IsWinner = csv.IsWinner,
            Studios = csv.Studios.Split(',').Select(s => new Studio(s.Trim())).ToList(),
            Producers = csv.Producers.Split(',').Select(p => new Producer(p.Trim())).ToList()
        };
    }
}

