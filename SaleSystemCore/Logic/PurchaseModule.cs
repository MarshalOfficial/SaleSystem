using SaleSystemCore.Models;
using SaleSystemCore.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleSystemCore.Logic
{
    public class PurchaseModule
    {
        private PurchaseInvoiceRepo purchaseInvoiceRepo;
        private PurchaseInvoiceDetailRepo purchaseInvoiceDetailRepo;
        private PurchaseInvoiceDetailsTempRepo purchaseInvoiceDetailsTempRepo;
        private GlobalSettingRepo globalSettingRepo;
        private StockLogRepo stockLogRepo;
        private StockRepo stockRepo;

        internal PurchaseModule()
        {
            purchaseInvoiceRepo = new PurchaseInvoiceRepo();
            purchaseInvoiceDetailRepo = new PurchaseInvoiceDetailRepo();
            purchaseInvoiceDetailsTempRepo = new PurchaseInvoiceDetailsTempRepo();
            globalSettingRepo = new GlobalSettingRepo();
            stockLogRepo = new StockLogRepo();
            stockRepo = new StockRepo();
        }

        

        #region [DetailsTemp]

        public void AddDetailToTemp(PurchaseInvoiceDetailsTemp temp)
        {
            purchaseInvoiceDetailsTempRepo.Add(temp);
        }

        public void DeleteDetailTemp(PurchaseInvoiceDetailsTemp temp)
        {
            purchaseInvoiceDetailsTempRepo.Delete(temp);
        }

        public IEnumerable<PurchaseInvoiceDetailsTemp> GetAllDetailsTemp(int userid)
        {
            return purchaseInvoiceDetailsTempRepo.GetAllByUserID(userid);
        }

        public void UpdateAllDetailsTemp(IEnumerable<PurchaseInvoiceDetailsTemp> lst)
        {
            purchaseInvoiceDetailsTempRepo.UpdateRange(lst);
        }

        public PurchaseInvoiceDetailsTemp GetDetailTemp(int id)
        {
            return purchaseInvoiceDetailsTempRepo.Find(id);
        }

        public void SaveDetailTemp()
        {
            purchaseInvoiceDetailsTempRepo.SaveChanges();
        }

        #endregion

        #region SavePurchaseInvoice
        private string GetNewPurchaseInvoiceNo()
        {
            return Extension.Extension.GetDateTimeYearPart() + "-PI" + globalSettingRepo.GetPurchaseInvoiceCounter();
        }

        public bool SavePurchaseInvoice(int userid, int invoiceType, string description, int providerid,
            DateTime invoicedate)
        {
            try
            {
                var detailtemps = GetAllDetailsTemp(userid);
                if (detailtemps == null || detailtemps.Count() == 0)
                {
                    throw new Exception("Purchase Detail Temp is Empty for this User");
                }

                var pino = GetNewPurchaseInvoiceNo();

                var header = new PurchaseInvoice()
                {
                    InvoiceNumber = pino,
                    UserID = userid,
                    Description = description,
                    ProviderID = providerid,
                    InvoiceType = invoiceType,
                    InvoiceDate = invoicedate,
                    SumPrice = ((invoiceType == 1) ? 1 : -1) * detailtemps.Sum(l => l.Price * l.Qty),
                    SumDiscount = ((invoiceType == 1) ? 1 : -1) *
                                  detailtemps.Sum(l => ((l.Discount * l.Price) / 100) * l.Qty),
                    SumVat = ((invoiceType == 1) ? 1 : -1) * detailtemps.Sum(l => ((l.Vat * l.Price) / 100) * l.Qty)
                };

                purchaseInvoiceRepo.Add(header);

                var details = new List<PurchaseInvoiceDetails>();
                foreach (var item in detailtemps)
                {
                    details.Add(new PurchaseInvoiceDetails()
                    {
                        InvoiceID = header.Id,
                        ProductID = item.ProductID,
                        Qty = ((invoiceType == 1) ? 1 : -1) * item.Qty,
                        Vat = item.Vat,
                        Price = item.Price,
                        Discount = item.Discount,
                        Description = item.Description
                    });
                    stockLogRepo.Add(new StockLog()
                    {
                        ProductID = item.ProductID,
                        Qty = ((invoiceType == 1) ? 1 : -1) * item.Qty,
                        InvoiceNumber = pino,
                        TypeID = 1
                    });
                    stockRepo.SetProductStock(item.ProductID);
                }

                purchaseInvoiceDetailRepo.AddRange(details);
                purchaseInvoiceDetailsTempRepo.DeleteRange(detailtemps);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Report

        public IEnumerable<PurchaseInvoice> GetAllPurchaseInvoices()
        {
            return purchaseInvoiceRepo.GetAll();
        }

        public IEnumerable<PurchaseInvoiceDetails> GetPurchaseInvoiceDetails(int purchaseId)
        {
            return purchaseInvoiceDetailRepo.GetAllByInvoiceID(purchaseId);
        }
        #endregion
    }
}