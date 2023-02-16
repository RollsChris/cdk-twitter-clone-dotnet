using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lambdaMinimalApi.Queries.GetTweets
{
    public interface IGetTweetsQueryHandler : IQueryHandler<GetTweetsQuery, List<string>>
    {
        
    }
}