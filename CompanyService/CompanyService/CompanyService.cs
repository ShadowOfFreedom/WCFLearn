using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CompanyPublicService : ICompanyPublicService
    {
        public string GetPublicInformation()
        {
            throw new NotImplementedException();
        }
    }
    
    public class CompanyConfidentialService : ICompanyConfidentialService
    {
        public string GetConfidentialInformation()
        {
            throw new NotImplementedException();
        }
    }
}
