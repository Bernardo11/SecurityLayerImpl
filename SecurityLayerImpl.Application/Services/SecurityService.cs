using SecurityLayerImpl.Domain.Contracts.ExternalData;
using SecurityLayerImpl.Domain.Contracts.Repositories;
using SecurityLayerImpl.Domain.Contracts.Services;
using SecurityLayerImpl.Domain.Dtos;
using SecurityLayerImpl.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Application.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly ISecurityDataProvider _securityDataProvider;

        public SecurityService(ISecurityRepository securityRepository, ISecurityDataProvider securityDataProvider)
        {
            this._securityRepository = securityRepository;
            this._securityDataProvider = securityDataProvider;
        }

        public SecurityServiceResponse SaveISINPrice(string isinKey)
        {
            var securityServiceResponse = new SecurityServiceResponse();

            if(string.IsNullOrEmpty(isinKey) || isinKey.Length < 12)
            {
                securityServiceResponse.Success = false;
                securityServiceResponse.Message = "Invalid key";
                return securityServiceResponse;
            }

            var price = this._securityDataProvider.FetchPrice(isinKey);

            if(!price.HasValue)
            {
                securityServiceResponse.Success = false;
                securityServiceResponse.Message = "Price not found";
                return securityServiceResponse;
            }

            var securityPrice = new SecurityPrice() {
                IsinKey = isinKey,
                PriceValue = price.Value
            };

            this._securityRepository.SavePrice(securityPrice);

            securityServiceResponse.Success = true;
            securityServiceResponse.Message = "Price saved successfully";

            return securityServiceResponse;

        }
    }
}
