using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste02.DTO
{
    public class AppSettingsDTO
    {
        public string Secret { get; set; }
        public int ExpirationTime { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
