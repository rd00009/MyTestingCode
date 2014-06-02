using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_FirstWCF.Models;

namespace Wcf_FirstWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Authentication : IAuthentication
    {
        

        void IAuthentication.DoWork()
        {
            throw new NotImplementedException();
        }

        bool IAuthenticationServices.InsertUser(UserModel User)
        {

            return true;
        }
    }
}
