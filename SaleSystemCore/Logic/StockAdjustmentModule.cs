using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaleSystemCore.Models;
using SaleSystemCore.Repos;

namespace SaleSystemCore.Logic
{
    public class StockAdjustmentModule
    {
        private StockAdjustmentRepo stockAdjustmentRepo;
        private StockAdjustmentDetailRepo stockAdjustmentDetailRepo;
        private StockAdjustmentDetailsTempRepo stockAdjustmentDetailsTempRepo;
        private GlobalSettingRepo globalSettingRepo;
        private StockRepo stockRepo;
        private StockLogRepo stockLogRepo;

        internal StockAdjustmentModule()
        {
            stockAdjustmentRepo = new StockAdjustmentRepo();
            stockAdjustmentDetailRepo = new StockAdjustmentDetailRepo();
            stockAdjustmentDetailsTempRepo = new StockAdjustmentDetailsTempRepo();
            globalSettingRepo = new GlobalSettingRepo();
            stockRepo = new StockRepo();
            stockLogRepo = new StockLogRepo();
        }
            
        #region DetailsTemp

        public void AddDetailToTemp(StockAdjustmentDetailsTemp temp)
        {
            stockAdjustmentDetailsTempRepo.Add(temp);
        }

        public void DeleteDetailTemp(StockAdjustmentDetailsTemp temp)
        {
            stockAdjustmentDetailsTempRepo.Delete(temp);
        }

        public IEnumerable<StockAdjustmentDetailsTemp> GetAllDetailsTemp(int userid)
        {
            return stockAdjustmentDetailsTempRepo.GetAllByUserID(userid);
        }

        public void UpdateAllDetailsTemp(IEnumerable<StockAdjustmentDetailsTemp> lst)
        {
            stockAdjustmentDetailsTempRepo.UpdateRange(lst);
        }

        public StockAdjustmentDetailsTemp GetDetailTemp(int id)
        {
            return stockAdjustmentDetailsTempRepo.Find(id);
        }

        public void SaveDetailTemp()
        {
            stockAdjustmentDetailsTempRepo.SaveChanges();
        }

        #endregion

        #region SaveStockAdjustment

        private string GetNewStockAdjustmentNo()    
        {
            return Extension.Extension.GetDateTimeYearPart() + "-SA" + globalSettingRepo.GetStockAdjustmentCounter();
        }

        public bool SaveStockAdjustmentInvoice(int userid, int type,bool isOutput, string description, DateTime invoicedate)   
        {
            try
            {
                var detailtemps = GetAllDetailsTemp(userid);
                if (detailtemps == null || detailtemps.Count() == 0)
                {
                    throw new Exception("StockAdjustment Details Temp is Empty for this User");
                }

                var sano = GetNewStockAdjustmentNo();

                var header = new StockAdjustment()
                {
                    InvoiceNumber = sano,
                    UserID = userid,
                    Description = description,
                    Type = type,
                    IsOutput = isOutput,
                    InvoiceDate = invoicedate,
                    SumPrice = detailtemps.Sum(l => l.Price * l.Qty)
                };

                stockAdjustmentRepo.Add(header);

                var details = new List<StockAdjustmentDetails>();
                foreach (var item in detailtemps)
                {
                    details.Add(new StockAdjustmentDetails()
                    {
                        InvoiceID = header.Id,
                        ProductID = item.ProductID,
                        Qty = ((isOutput) ? -1 : 1) * item.Qty,
                        Price = item.Price,
                        Description = item.Description
                    });
                    stockLogRepo.Add(new StockLog()
                    {
                        ProductID = item.ProductID,
                        Qty = ((isOutput) ? -1 : 1) * item.Qty,
                        InvoiceNumber = sano,
                        TypeID = 3
                    });
                    stockRepo.SetProductStock(item.ProductID);
                }

                stockAdjustmentDetailRepo.AddRange(details);
                stockAdjustmentDetailsTempRepo.DeleteRange(detailtemps);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Report

        public IEnumerable<StockAdjustment> GetAllStockAdjustments()    
        {
            return stockAdjustmentRepo.GetAll();
        }

        public IEnumerable<StockAdjustmentDetails> GetStockAdjustmentDetails(int stockAdjustmentId)     
        {
            return stockAdjustmentDetailRepo.GetAllByInvoiceID(stockAdjustmentId);
        }
        #endregion
    }
}
