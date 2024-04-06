using RestaurantReservationApp.Forms.FormCustomer;
using RestaurantReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationApp.Services;
public class CustomerServices
{
    public Customer AddCustomer(Customer customer)
    {
        RestaurantDbContext db = new RestaurantDbContext();
        db.Customers.Add(customer);
        db.SaveChanges();

        return customer;
    }

    public List<Customer> GetAllCustomer()
    {
        RestaurantDbContext db = new RestaurantDbContext();
        List<Customer> customers = db.Customers.ToList();
        return customers;
    }

    public void DeleteCustomer(int id)
    {
        RestaurantDbContext db = new RestaurantDbContext();
        // önce silinecek müşteri bulunur.
        //Customer customer = db.Customers.Find(id);
        Customer customer = db.Customers.FirstOrDefault(x => x.Id == id);

        db.Customers.Remove(customer);
        db.SaveChanges();
    }
}
