using SecurityLayerImpl.Domain.Contracts.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Infrastructure.ExternalData
{
    public class SecurityDataProvider : ISecurityDataProvider
    {
        private readonly string _securityBaseUrl = "https://securities.dataprovider.com/";
        public decimal? FetchPrice(string isinKey)
        {
            return 15;
        }
    }
}
