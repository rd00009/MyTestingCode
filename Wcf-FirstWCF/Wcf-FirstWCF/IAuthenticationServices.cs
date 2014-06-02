using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_FirstWCF
{
    [ServiceContract]
    public interface IAuthenticationServices
    {
        [OperationContract]
        bool InsertUser(Wcf_FirstWCF.Models.UserModel User);
    }
}
