using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login1
{
    public class Authlogic
    {
        public static bool AuthLogic(string login, string password)
        {
            foreach (var item in User.GetUsers())
            {
                if (item.login == login && item.password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
