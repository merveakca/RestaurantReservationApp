using RestaurantReservationApp.Models;
using RestaurantReservationApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservationApp.Forms.FormCustomer;
public partial class AddCustomerForm : Form
{
    public AddCustomerForm()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Customer customer = new Customer();
            customer.Name = txtName.Text.Trim();
            customer.Surname = txtSurname.Text.Trim();
            customer.Email = txtEmail.Text.Trim();
            customer.Phone = txtPhone.Text.Trim();
            customer.Address = txtAddress.Text;

            CustomerServices customerServices = new CustomerServices();
            customerServices.AddCustomer(customer);
            MessageBox.Show(customer.Name + " Customer added succesfully");
        }
        catch (Exception)
        {
            MessageBox.Show("Müşteri eklenirken bir hata oluştu!");
        }
    }

    private void AddCustomerForm_Load(object sender, EventArgs e)
    {
        CustomerServices customerServices = new CustomerServices();
        dtgridCustomers.DataSource = customerServices.GetAllCustomer();
    }
}
