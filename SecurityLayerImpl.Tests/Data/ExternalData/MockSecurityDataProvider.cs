using SecurityLayerImpl.Domain.Contracts.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Infrastructure.ExternalData
{
    public class MockSecurityDataProvider : ISecurityDataProvider
    {
        private readonly string _securityBaseUrl = "https://securities.dataprovider.com/";
        public decimal? FetchPrice(string isinKey)
        {
            return string.Equals(isinKey, "123456789101") ? 15 : null;
        }
    }
}
