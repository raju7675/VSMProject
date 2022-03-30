using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ServiceRecordInfoImpliment : IServiceRecordInfoRepository<ServiceRecordInfo>
    {
        public bool DeleteServiceRecodes(ServiceRecordInfo serviceRecordInfo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var service = dbContext.ServiceRecordInfoes.Where(x => x.ServiceRefNo == serviceRecordInfo.ServiceRefNo).FirstOrDefault();
                dbContext.ServiceRecordInfoes.Remove(service);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<ServiceRecordInfo> GetAllServiceRecords()
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var servicesRecord = dbContext.ServiceRecordInfoes.ToList();
                return servicesRecord;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ServiceRecordInfo GetServiceRecordInfoByServiceRefNo(int servicerefno)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var serviceRecord = dbContext.ServiceRecordInfoes.Where(x => x.ServiceRefNo == servicerefno).FirstOrDefault();
                return serviceRecord;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool SaveServiceRecodes(ServiceRecordInfo serviceRecordInfo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                dbContext.ServiceRecordInfoes.Add(serviceRecordInfo);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateServiceRecodes(ServiceRecordInfo serviceRecordInfo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var service = dbContext.ServiceRecordInfoes.Where(x => x.ServiceRefNo == serviceRecordInfo.ServiceRefNo).FirstOrDefault();
                service.ServiceRefNo = serviceRecordInfo.ServiceRefNo;
                service.CustId = serviceRecordInfo.CustId;
                service.ModalNo= serviceRecordInfo.ModalNo;
                service.ServiceDate = serviceRecordInfo.ServiceDate;
                service.NextServiceDate= serviceRecordInfo.NextServiceDate;
                service.ServiceRepId= serviceRecordInfo.ServiceRepId;
                dbContext.SaveChanges();
                return true;

            }catch (Exception ex)
            { return false;}
        }
    }
}
