using SecurityLayerImpl.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Domain.Contracts.Services
{
    public interface ISecurityService
    {
        public SecurityServiceResponse SaveISINPrice(string isinKey);
    }
}
