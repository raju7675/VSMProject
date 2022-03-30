using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerMasterImpliment : ICustomerMasterRepository<CustomerMaster>
    {
        public bool DeleteCustomer(CustomerMaster customer)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext=new VMSDataBaseProjectEntities();
                var cust=dbContext.CustomerMasters.Where(x=>x.CustId==customer.CustId).FirstOrDefault();
                dbContext.CustomerMasters.Remove(cust);
                dbContext.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<CustomerMaster> GetAllCustomer()
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var customers = dbContext.CustomerMasters.ToList();
                return customers;
            }catch (Exception ex)
            {
                return null;
            }
        }

        public CustomerMaster GetCustomerById(int id)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var customer=dbContext.CustomerMasters.Where(x=>x.CustId==id).FirstOrDefault();
                return customer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool SaveCustomer(CustomerMaster customer)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                dbContext.CustomerMasters.Add(customer);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdteCustomer(CustomerMaster customer)
        {
            try
            {
                VMSDataBaseProjectEntities dbContext = new VMSDataBaseProjectEntities();
                var cust = dbContext.CustomerMasters.Where(x => x.CustId==customer.CustId).FirstOrDefault();
                cust.CustId = customer.CustId;  
                cust.FirstName= customer.FirstName; 
                cust.LastName= customer.LastName;
                cust.ContactNo= customer.ContactNo;
                cust.Email= customer.Email;
                cust.City   = customer.City;
                cust.Country = customer.Country;    
                cust.State = customer.State;
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
