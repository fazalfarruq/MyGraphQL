using HotChocolate.Types;
using MyGraphQL.Model;

namespace MyGraphQL.GraphQL.Types
{
    public class CharacterType : ObjectType<Character>
    {
        protected override void Configure(IObjectTypeDescriptor<Character> descriptor)
        {
            descriptor.Field(f => f.Id).Type<IntType>().Name("id");
            descriptor.Field(f => f.Name).Type<StringType>().Name("characterName");

        }
    }
}
