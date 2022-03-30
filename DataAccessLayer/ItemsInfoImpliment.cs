using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class ItemsInfoImpliment : IItemsInfoRepository<ItemsInfo>
    {
        public bool DeleteItems(ItemsInfo itemsInfo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var item = dbContext.ItemsInfoes.Where(x => x.ItemId == itemsInfo.ItemId).FirstOrDefault();
                dbContext.ItemsInfoes.Remove(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<ItemsInfo> GetAllItems()
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var items = dbContext.ItemsInfoes.ToList();
                return items;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ItemsInfo GetItemById(int itemId)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var items = dbContext.ItemsInfoes.Where(x => x.ItemId == itemId).FirstOrDefault();
                return items;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool SaveItems(ItemsInfo itemsInfo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                dbContext.ItemsInfoes.Add(itemsInfo);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateItems(ItemsInfo itemsInfo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var items = dbContext.ItemsInfoes.Where(x => x.ItemId == itemsInfo.ItemId).FirstOrDefault();
                items.ItemId = itemsInfo.ItemId;
                items.ItemName = itemsInfo.ItemName;
                items.Mrp=itemsInfo.Mrp;
                dbContext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
