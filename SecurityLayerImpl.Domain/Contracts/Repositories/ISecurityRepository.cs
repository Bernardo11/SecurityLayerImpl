using SecurityLayerImpl.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Domain.Contracts.Repositories
{
    public interface ISecurityRepository
    {
        public void SavePrice(SecurityPrice price);
    }
}
