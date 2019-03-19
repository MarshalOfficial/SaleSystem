using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleSystemCore.Models;
using SaleSystemCore.Repos;

namespace SaleSystemCore.Logic
{
    public class Cash
    {
        private User LoginedUser;   
        private List<UserPermissions> UserPermissions;

        public Cash(string username, string password)
        {
            LoginUser(username, password);
        }

        public void LoginUser(string username, string password)
        {
            LoginedUser = new UserRepo().FindByCredentials(username, password);
            if (LoginedUser != null && !LoginedUser.IsAdmin)
            {
                UserPermissions = new UserPermissionRepo().GetUserPermissions(LoginedUser.Id);
            }
        }
    }
}
