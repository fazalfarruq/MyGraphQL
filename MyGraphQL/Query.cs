using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace MyGraphQL
{
    public class Query
    {
        public IEnumerable<Character> GetCharacters([Service] ICharacterRepo repo)
        {
            return repo.Get();
        }


        public async Task<List<Character>> GetCharacterByIdAsync(
            int id,
            ChracterDataLoader dataLoader,
            CancellationToken cancellationToken)
        {
            var result = await dataLoader.LoadAsync(id, cancellationToken);
            return result;
        }

    }
}
