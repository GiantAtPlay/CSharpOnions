using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ApplicationFascade : IApplicationFascade
    {
        public IEntitiesFascade Entities { get; }
        public IServicesFascade Services { get; }

        public ApplicationFascade(IEntitiesFascade entities, IServicesFascade services)
        {
            Entities = entities;
            Services = services;
        }
    }
}
