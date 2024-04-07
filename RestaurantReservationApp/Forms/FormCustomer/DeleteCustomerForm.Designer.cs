namespace RestaurantReservationApp.Forms.FormCustomer;

partial class DeleteCustomerForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label4 = new Label();
        dtgridDeleteCustomers = new DataGridView();
        btnDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)dtgridDeleteCustomers).BeginInit();
        SuspendLayout();
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 19F);
        label4.Location = new Point(70, 35);
        label4.Name = "label4";
        label4.Size = new Size(201, 51);
        label4.TabIndex = 26;
        label4.Text = "Customers";
        // 
        // dtgridDeleteCustomers
        // 
        dtgridDeleteCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgridDeleteCustomers.Location = new Point(70, 89);
        dtgridDeleteCustomers.Name = "dtgridDeleteCustomers";
        dtgridDeleteCustomers.RowHeadersWidth = 62;
        dtgridDeleteCustomers.Size = new Size(1216, 591);
        dtgridDeleteCustomers.TabIndex = 25;
        dtgridDeleteCustomers.CellContentClick += dtgridDeleteCustomers_CellContentClick;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Firebrick;
        btnDelete.Font = new Font("Segoe UI", 13F);
        btnDelete.ForeColor = SystemColors.ButtonHighlight;
        btnDelete.Location = new Point(1015, 723);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(271, 76);
        btnDelete.TabIndex = 24;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // DeleteCustomerForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1370, 924);
        Controls.Add(label4);
        Controls.Add(dtgridDeleteCustomers);
        Controls.Add(btnDelete);
        Name = "DeleteCustomerForm";
        Text = "DeleteCustomerForm";
        Load += DeleteCustomerForm_Load;
        ((System.ComponentModel.ISupportInitialize)dtgridDeleteCustomers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label4;
    private DataGridView dtgridDeleteCustomers;
    private Button btnDelete;
}