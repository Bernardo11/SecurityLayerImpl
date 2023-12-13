using SecurityLayerImpl.Application.Services;
using SecurityLayerImpl.Domain.Contracts.ExternalData;
using SecurityLayerImpl.Domain.Contracts.Services;
using SecurityLayerImpl.Infrastructure.ExternalData;
using SecurityLayerImpl.Tests.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Tests.Data.Config
{
    public class ServiceFactory
    {
        public static ISecurityService BuildSecurityService ()
        {
            var securityRepository = new MockSecurityRepository();
            var securityDataService = new MockSecurityDataProvider();

            return new SecurityService(securityRepository, securityDataService);
        }
    }
}
