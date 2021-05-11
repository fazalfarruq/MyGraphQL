using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGraphQL.Model;

namespace MyGraphQL
{
    public class CharacterRepo : ICharacterRepo
    {
        public List<Character> Characters { get; }
        public CharacterRepo()
        {
            Characters = new List<Character>{
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
            return Characters;
        }

        public Character? GetById(int id)
        {
            return Characters.Find(f => f.Id == id);
        }
    }
}
