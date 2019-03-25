using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleSystemCore.Models;
using SaleSystemCore.Repos;

namespace SaleSystemCore.Logic
{
    //todo SaleModule :)
    public class SaleModule
    {
        private SaleInvoiceRepo saleInvoiceRepo;
        private SaleInvoiceDetailRepo saleInvoiceDetailRepo;
        private SaleInvoiceDetailsTempRepo saleInvoiceDetailsTempRepo;
        private SaleInvoicePaymentRepo saleInvoicePaymentRepo;
        private GlobalSettingRepo globalSettingRepo;
        private StockLogRepo stockLogRepo;
        private StockRepo stockRepo;

        internal SaleModule()
        {
            saleInvoiceRepo = new SaleInvoiceRepo();
            saleInvoiceDetailRepo = new SaleInvoiceDetailRepo();
            saleInvoiceDetailsTempRepo = new SaleInvoiceDetailsTempRepo();
            saleInvoicePaymentRepo = new SaleInvoicePaymentRepo();
            globalSettingRepo = new GlobalSettingRepo();
            stockLogRepo = new StockLogRepo();
            stockRepo = new StockRepo();
        }

        #region DetailsTemp

        public void AddDetailToTemp(SaleInvoiceDetailsTemp temp)
        {
            saleInvoiceDetailsTempRepo.Add(temp);
        }

        public void DeleteDetailTemp(SaleInvoiceDetailsTemp temp)
        {
            saleInvoiceDetailsTempRepo.Delete(temp);
        }

        public IEnumerable<SaleInvoiceDetailsTemp> GetAllDetailsTemp(int userid)
        {
            return saleInvoiceDetailsTempRepo.GetAllByUserID(userid);
        }

        public void UpdateAllDetailsTemp(IEnumerable<SaleInvoiceDetailsTemp> lst)
        {
            saleInvoiceDetailsTempRepo.UpdateRange(lst);
        }

        public SaleInvoiceDetailsTemp GetDetailTemp(int id)
        {
            return saleInvoiceDetailsTempRepo.Find(id);
        }

        public void SaveDetailTemp()
        {
            saleInvoiceDetailsTempRepo.SaveChanges();
        }


        #endregion

        #region SaveSaleInvoice

        private string GetNewSaleInvoiceNo()
        {   
            return Extension.Extension.GetDateTimeYearPart() + "-SI" + globalSettingRepo.GetSaleInvoiceCounter();
        }

        public bool SaveSaleInvoice(int userid, int customerid, string description, IEnumerable<SaleInvoicePayments> saleInvoicePayments)
        {           
            try
            {

                var detailtemps = GetAllDetailsTemp(userid);
                if (detailtemps == null || detailtemps.Count() == 0)
                {
                    throw new Exception("SaleInvoice Detail Temp is Empty for this User");
                }   

                var sino = GetNewSaleInvoiceNo();
                var sumprice = detailtemps.Sum(l => l.SalePrice * l.Qty);
                var sumdiscount = detailtemps.Sum(l => ((l.Discount * l.SalePrice) / 100) * l.Qty);
                var sumvat = detailtemps.Sum(l => ((l.Vat * l.SalePrice) / 100) * l.Qty);

                var sumcustomerpayment = (sumprice + sumvat) - sumdiscount;
                if (sumcustomerpayment != saleInvoicePayments.Sum(l => l.Value))
                {
                    throw new Exception("Payments value is not match to invoice items sum prices");
                }

                var header = new SaleInvoice()
                {
                    InvoiceNumber = sino,
                    UserID = userid,
                    Description = description,
                    CustomerID = customerid,
                    SumPrice = sumprice,
                    SumDiscount = sumdiscount,
                    SumVat = sumvat
                };

                saleInvoiceRepo.Add(header);

                var details = new List<SaleInvoiceDetails>();
                foreach (var item in detailtemps)
                {
                    details.Add(new SaleInvoiceDetails()
                    {
                        InvoiceID = header.Id,
                        ProductID = item.ProductID,
                        Qty = item.Qty,
                        Vat = item.Vat,
                        SalePrice = item.SalePrice,
                        PurchasePrice = item.PurchasePrice,
                        Discount = item.Discount,
                        Description = item.Description
                    });

                    stockLogRepo.Add(new StockLog()
                    {
                        ProductID = item.ProductID,
                        Qty = -1 * item.Qty,
                        InvoiceNumber = sino,
                        TypeID = 2
                    });
                    stockRepo.SetProductStock(item.ProductID);
                }

                saleInvoiceDetailRepo.AddRange(details);
                saleInvoiceDetailsTempRepo.DeleteRange(detailtemps);
                saleInvoicePaymentRepo.AddRange(saleInvoicePayments);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        #endregion
    }
}
