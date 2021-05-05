using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;
using MyGraphQL.GraphQL.Types;

namespace MyGraphQL
{
    public class QueryType : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");
            descriptor.Field("GetCharacters")
                .ResolveWith<CharacterResolver>(q => q.GetCharacters(default))
                .Name("AllTheCharacters");

            descriptor.Field("GetCharacterByIdAsync")
                .ResolveWith<CharacterResolver>(q => q.GetCharacterByIdAsync(default,default,default))
                .Type<ListType<CharacterType>>()
                .Name("AllTheCharactersMulti");

        }
    }
}
