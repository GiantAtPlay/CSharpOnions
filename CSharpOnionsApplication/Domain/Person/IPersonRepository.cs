using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Person
{
    public interface IPersonRepository
    {
        IPerson Get(int id);
        ICollection<IPerson> Get();
        ICollection<IPerson> Get(IEnumerable<int> ids);
    }
}
