using HotChocolate.Types;
using MyGraphQL.Model;

namespace MyGraphQL.GraphQL.Types
{
    public class CharacterType : ObjectType<Character>
    {
        protected override void Configure(IObjectTypeDescriptor<Character> descriptor)
        {
            
        }
    }
}
