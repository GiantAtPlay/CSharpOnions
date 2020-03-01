using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IPerson Get(int id)
        {
            throw new NotImplementedException();    
        }

        public ICollection<IPerson> Get()
        {
            throw new NotImplementedException();
        }

        public ICollection<IPerson> Get(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}
