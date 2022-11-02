using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserOperations
    {
        CustomerEntities userContext = null;
        public UserOperations()
        {
            userContext = new CustomerEntities();
        }
        public bool ValidateUser(string email, string pass)
        {
            bool ans = false;
            var found = userContext.UserInfoes.FirstOrDefault(x => x.Email == email);
            if (found != null)
            {
                if (found.Password == pass)
                {
                    ans = true;
                }
            }
            return ans;
        }
    }
}
