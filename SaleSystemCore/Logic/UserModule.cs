using SaleSystemCore.Models;
using SaleSystemCore.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleSystemCore.Logic
{
    public class UserModule
    {
        private UserRepo userRepo;
        private UserPermissionRepo userPermissionRepo;
        internal UserModule()
        {
            userRepo = new UserRepo();
            userPermissionRepo = new UserPermissionRepo();
        }

        #region [Users]
        public List<User> GetAllUsers()
        {
            return userRepo.GetAll().ToList();
        }

        public void AddUser(User user)
        {
            userRepo.Add(user);
        }

        public User GetUser(int id)
        {
            return userRepo.Find(id);
        }

        public void SaveUser()
        {
            userRepo.SaveChanges();
        }
        #endregion

        #region [UserPermission]
        #endregion
    }
}
