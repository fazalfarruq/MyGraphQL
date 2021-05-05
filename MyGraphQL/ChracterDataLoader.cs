using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GreenDonut;
using HotChocolate.DataLoader;

namespace MyGraphQL
{
    public class ChracterDataLoader : BatchDataLoader<int, Character>
    {
        private readonly ICharacterRepo _repo;

        public ChracterDataLoader(ICharacterRepo repo, IBatchScheduler batchScheduler) : base(batchScheduler)
        {
            _repo = repo;
        }

        protected override async Task<IReadOnlyDictionary<int, Character>> LoadBatchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
        {
            {
                var gadgets = _repo.Get().ToList()
                    .Where(g => keys.Contains(g.Id)).ToList();


                return gadgets.ToDictionary(_ => _.Id, _ => _);
                
                //var result = gadgets.GroupBy(_ => _.Id)
                //    .Select(_ => new {
                //        key = _.Key,
                //        gadgets = _
                //    }).ToDictionary(_ => _.key, _ => _.gadgets);
                //return result;
            };
        }

    }
}
