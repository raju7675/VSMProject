using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BillInfoImpliment : IBillInfoRepository<BillInfo>
    {
        public bool DeleteBill(BillInfo bill)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var b = dbContext.BillInfoes.Where(x => x.ID == bill.ID).FirstOrDefault();
                dbContext.BillInfoes.Remove(b);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<BillInfo> GetAllBill()
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var b = dbContext.BillInfoes.ToList();
                return b;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public BillInfo GetBillById(int Billid)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var b = dbContext.BillInfoes.Where(x => x.ID == Billid).FirstOrDefault();
                return b;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool SaveBill(BillInfo bill)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                dbContext.BillInfoes.Add(bill);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateBill(BillInfo bill)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var b = dbContext.BillInfoes.Where(x => x.ID == bill.ID).FirstOrDefault();
                b.ID=bill.ID;
                b.ServiceRef = bill.ServiceRef;
                b.ItemId = bill.ItemId;
                b.Price = bill.Price;
                b.Qty = bill.Qty;
                b.ItemAmount= bill.ItemAmount;
                dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
