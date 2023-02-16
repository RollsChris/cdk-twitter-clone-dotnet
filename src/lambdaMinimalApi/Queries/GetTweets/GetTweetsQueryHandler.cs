using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lambdaMinimalApi.Queries.GetTweets
{
    public class GetTweetsQueryHandler : IGetTweetsQueryHandler
    {
        public async Task<List<string>> Handle(GetTweetsQuery query)
        {
            return new List<string>
            {
                ""
            };
        }
    }
}