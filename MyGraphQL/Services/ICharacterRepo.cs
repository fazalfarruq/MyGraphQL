using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGraphQL.Model;

namespace MyGraphQL
{
    public interface ICharacterRepo
    {
        IEnumerable<Character> Get();
        Character? GetById(int id);
    }
}
