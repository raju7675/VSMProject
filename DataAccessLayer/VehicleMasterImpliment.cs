using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VehicleMasterImpliment : IVehicleMasterRepository<VechileMaster>
    {
        public bool DeleteVehicle(VechileMaster vehicle)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var v = dbContext.VechileMasters.Where(x => x.ModalNo==vehicle.ModalNo).FirstOrDefault();
                dbContext.VechileMasters.Remove(v);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<VechileMaster> GetAllVehicle()
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var v = dbContext.VechileMasters.ToList();
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public VechileMaster GetVehicle(int modeNo)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var v = dbContext.VechileMasters.Where(x => x.ModalNo == modeNo).FirstOrDefault();
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool SaveVehicle(VechileMaster vehicle)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                dbContext.VechileMasters.Add(vehicle);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateVehicle(VechileMaster vehicle)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var v = dbContext.VechileMasters.Where(x => x.ModalNo == vehicle.ModalNo).FirstOrDefault();
                v.ModalNo = vehicle.ModalNo;
                v.ModalName = vehicle.ModalName;
                v.ModalYear = vehicle.ModalYear;
                v.VehicleType = vehicle.VehicleType;
                v.ServiceSchedule = vehicle.ServiceSchedule;
                v.SoldDate = vehicle.SoldDate;
                v.CustId = vehicle.CustId;
                dbContext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
