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
        LoadData();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int selectedCell = Convert.ToInt32(dtgridCustomers.SelectedCells[0].Value);
        CustomerServices customerServices = new CustomerServices();
        customerServices.DeleteCustomer(selectedCell);
        LoadData();
    }

    void LoadData()
    {
        CustomerServices customerServices = new CustomerServices();
        dtgridCustomers.DataSource = customerServices.GetAllCustomer();
    }

    
}
