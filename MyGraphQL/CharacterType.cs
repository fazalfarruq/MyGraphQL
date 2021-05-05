using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace MyGraphQL
{
    public class CharacterType : ObjectType<Character>
    {
        protected override void Configure(IObjectTypeDescriptor<Character> descriptor)
        {
            descriptor.Field(_ => _.Id).Type<IntType>().Name("Id");
            descriptor.Field(_ => _.Name).Type<StringType>().Name("CharacterName");
        }
    }
}
