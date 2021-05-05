using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace MyGraphQL
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(_ => _.GetCharacters(default))
                .Type<ListType<CharacterType>>()
                .Name("AllCharacters");
            descriptor.Field(_ => _.GetCharacterByIdAsync(default, default, default))
                .Type<CharacterType>()
                .Name("CharacterDataLoader");

        }
    }
}
