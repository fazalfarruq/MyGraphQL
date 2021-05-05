using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGraphQL
{
    public class CharacterRepo : ICharacterRepo
    {
        public List<Character> Character { get; }
        public CharacterRepo()
        {
            Character = new List<Character>{
                new Character()
                {
                    Id = 1,
                    Name = "John"
                },
                new Character()
                {
                    Id = 2,
                    Name = "Fazal"
                },
                new Character()
                {
                    Id = 3,
                    Name = "Payne"
                }
            };
        }
        public IEnumerable<Character> Get()
        {
            return Character;
        }
    }
}
