using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IEntitiesFascade
    {
        IPersonRepository Person { get; }
    }

    public class EntitiesFascade : IEntitiesFascade
    { 
        public IPersonRepository Person { get; }

        public EntitiesFascade(IPersonRepository personRepository)
        {
            Person = personRepository;
        }
    }
}
