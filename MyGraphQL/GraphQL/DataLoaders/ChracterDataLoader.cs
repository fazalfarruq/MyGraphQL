using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GreenDonut;
using HotChocolate.DataLoader;
using MyGraphQL.Model;

namespace MyGraphQL
{
    public class ChracterDataLoader : BatchDataLoader<int, List<Character>>
    {
        private readonly ICharacterRepo _repo;

        public ChracterDataLoader(ICharacterRepo repo, IBatchScheduler batchScheduler) : base(batchScheduler)
        {
            _repo = repo;
        }

        protected override async Task<IReadOnlyDictionary<int, List<Character>>> LoadBatchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
        {
            {
                var gadgets = _repo.Get().ToList()
                    .Where(g => keys.Contains(g.Id)).ToList();
                
                
                var result = gadgets.GroupBy(_ => _.Id)
                    .Select(_ => new {
                        key = _.Key,
                        gadgets = _.ToList()
                    }).ToDictionary(_ => _.key, _ => _.gadgets);
                return result;
            };
        }

    }
}
