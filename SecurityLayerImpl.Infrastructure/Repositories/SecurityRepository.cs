using SecurityLayerImpl.Domain.Contracts.Repositories;
using SecurityLayerImpl.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Infrastructure.Repositories
{
    public class SecurityRepository : ISecurityRepository
    {
        public SecurityRepository() { }

        public void SavePrice(SecurityPrice price)
        {
            throw new NotImplementedException();
        }
    }
}
