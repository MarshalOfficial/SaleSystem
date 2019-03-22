using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleSystemCore.Models;
using SaleSystemCore.Repos;

namespace SaleSystemCore.Logic
{
    public static class Cash
    {
        public static User _User;  
        public static List<UserPermissions> _UserPermissionses;  
            
        public static UserModule _UserModule;
        public static StockModule _StockModule;
        public static SaleModule _SaleModule;
        public static PurchaseModule _PurchaseModule;
        public static ProductModule _ProductModule;
        public static CustomerModule _CustomerModule;
        public static StockAdjustmentModule _StockAdjustmentModule; 



        public static bool LoginUser(string username, string password)
        {
            try
            {
                _User = new UserRepo().FindByCredentials(username, password);
                _UserPermissionses = new List<UserPermissions>();
                if (_User != null)
                {
                    if (!_User.IsAdmin)
                    {
                        _UserPermissionses = new UserPermissionRepo().GetUserPermissions(_User.Id);
                    }
                    else
                    {
                        // when user is admin, we should fill all permissions for him in userpermissions list
                        var allperms = new PermissionRepo().GetAll();
                        foreach (Permission item in allperms)
                        {
                            _UserPermissionses.Add(new UserPermissions() {UserID = _User.Id, PermKey = item.PermKey});
                        }
                    }
                    LoadModules();
                    return true;
                }
                else
                {
                    // login failed
                    return false;
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private static void LoadModules()
        {
            try
            {
                if (_UserPermissionses == null || _UserPermissionses.Count == 0) return;

                foreach (var item in _UserPermissionses.Where(l => l.PermKey.ToLower().Contains("module")))
                {
                    switch (item.PermKey)
                    {
                        case "UserModule":
                            _UserModule = new UserModule();
                            break;
                        case "ProductModule":
                            _ProductModule = new ProductModule();
                            break;
                        case "StockModule":
                            _StockModule = new StockModule();
                            break;
                        case "SaleModule":
                            _SaleModule = new SaleModule();
                            break;
                        case "PurchaseModule":
                            _PurchaseModule = new PurchaseModule();
                            break;
                        case "CustomerModule":
                            _CustomerModule = new CustomerModule();
                            break;
                        case "StockAdjustmentModule":
                            _StockAdjustmentModule = new StockAdjustmentModule();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}   