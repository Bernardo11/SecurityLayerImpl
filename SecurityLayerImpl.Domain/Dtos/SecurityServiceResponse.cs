using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayerImpl.Domain.Dtos
{
    public class SecurityServiceResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
