using SaleSystemCore.Models;
using SaleSystemCore.Repos;
using System.Collections.Generic;

namespace SaleSystemCore.Logic
{
    public class UserModule
    {
        private UserRepo userRepo;
        private UserPermissionRepo userPermissionRepo;
        private PermissionRepo permissionRepo;

        internal UserModule()
        {
            userRepo = new UserRepo();
            userPermissionRepo = new UserPermissionRepo();
            permissionRepo = new PermissionRepo();
        }

        #region [Users]
        public IEnumerable<User> GetAllUsers()
        {
            return userRepo.GetAll();
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

        public void DeleteUser(User user)
        {
            userRepo.Delete(user);
        }
        #endregion

        #region [UserPermission]
        public IEnumerable<Permission> GetAllPermissions()
        {
            return permissionRepo.GetAll();
        }

        public void AddUserPermission(UserPermissions userPermissions)
        {
            userPermissionRepo.Add(userPermissions);
        }

        public void DeleteUserPermission(UserPermissions userPermissions)
        {
            userPermissionRepo.Delete(userPermissions);
        }

        public IEnumerable<UserPermissions> GetAllUserPermissions()
        {
            return userPermissionRepo.GetAll();
        }
        #endregion
    }
}
