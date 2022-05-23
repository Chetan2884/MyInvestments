using MyInvestments.Data;
using MyInvestments.Models;
using System.Threading.Tasks;
using System.Linq;

namespace MyInvestments.ViewModel
{
    public class LoginViewModel
    {
        public static bool CheckLoginDetails(Login loginObj)
        {
            using (var loginContext = new MyInvestmentsContext())
            {
                var dbPass = loginContext.Logins.Where(l=>l.LoginName == loginObj.LoginName).FirstOrDefault();
                if(dbPass.Password.Trim() == loginObj.Password.Trim())
                    return true;
            }
            return false;
        }
    }
}
