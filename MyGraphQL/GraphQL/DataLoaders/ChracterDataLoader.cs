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
                var result = _repo.Get().ToList()
                    .Where(g => keys.Contains(g.Id)).ToList();

                return result.ToDictionary(r => r.Id, r => r);

            };
        }

    }
}
