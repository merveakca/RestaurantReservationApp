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
public partial class DeleteCustomerForm : Form
{
    public DeleteCustomerForm()
    {
        InitializeComponent();
    }

    private void DeleteCustomerForm_Load(object sender, EventArgs e)
    {
        CustomerServices customerServices = new CustomerServices();
        dtgridDeleteCustomers.DataSource = customerServices.GetAllCustomer();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int selectedId = Convert.ToInt32(dtgridDeleteCustomers.CurrentRow.Cells["id"].Value);

        CustomerServices customerServices = new CustomerServices();
        customerServices.DeleteCustomer(selectedId);
        dtgridDeleteCustomers.DataSource = customerServices.GetAllCustomer();
    }


    
}
