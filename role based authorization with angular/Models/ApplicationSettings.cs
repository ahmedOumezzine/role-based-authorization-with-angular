using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace role_based_authorization_with_angular.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_URL { get; set; }
    }
}
