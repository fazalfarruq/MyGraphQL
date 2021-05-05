using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace MyGraphQL
{
    public class QueryType : ObjectType<Query>
    {
        //private readonly ICharacterRepo _repo;
        //public QueryType(ICharacterRepo repo)
        //{
        //    _repo = repo;
        //}
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(_ => _.GetCharacters(default))
                .Type<CharacterType>()
                .Name("AllCharacters");
            descriptor.Field(_ => _.GetCharacterByIdAsync(default, default, default))
                .Type<ListType<CharacterType>>()
                .Name("CharacterDataLoader");

        }
    }
}
