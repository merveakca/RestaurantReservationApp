namespace RestaurantReservationApp.Forms.FormCustomer;

partial class AddCustomerForm
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
        btnAdd = new Button();
        txtAddress = new TextBox();
        label5 = new Label();
        txtPhone = new TextBox();
        Phone = new Label();
        txtEmail = new TextBox();
        label3 = new Label();
        txtSurname = new TextBox();
        label2 = new Label();
        txtName = new TextBox();
        label1 = new Label();
        dtgridCustomers = new DataGridView();
        label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)dtgridCustomers).BeginInit();
        SuspendLayout();
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.Green;
        btnAdd.Font = new Font("Segoe UI", 13F);
        btnAdd.ForeColor = SystemColors.ButtonHighlight;
        btnAdd.Location = new Point(27, 262);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(1216, 76);
        btnAdd.TabIndex = 21;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // txtAddress
        // 
        txtAddress.Font = new Font("Segoe UI", 13F);
        txtAddress.Location = new Point(175, 199);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(1068, 42);
        txtAddress.TabIndex = 20;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 13F);
        label5.Location = new Point(27, 202);
        label5.Name = "label5";
        label5.Size = new Size(113, 36);
        label5.TabIndex = 19;
        label5.Text = "Address:";
        // 
        // txtPhone
        // 
        txtPhone.Font = new Font("Segoe UI", 13F);
        txtPhone.Location = new Point(863, 133);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(380, 42);
        txtPhone.TabIndex = 18;
        // 
        // Phone
        // 
        Phone.AutoSize = true;
        Phone.Font = new Font("Segoe UI", 13F);
        Phone.Location = new Point(725, 136);
        Phone.Name = "Phone";
        Phone.Size = new Size(95, 36);
        Phone.TabIndex = 17;
        Phone.Text = "Phone:";
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 13F);
        txtEmail.Location = new Point(863, 72);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(380, 42);
        txtEmail.TabIndex = 16;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 13F);
        label3.Location = new Point(725, 75);
        label3.Name = "label3";
        label3.Size = new Size(92, 36);
        label3.TabIndex = 15;
        label3.Text = "E-Mail:";
        // 
        // txtSurname
        // 
        txtSurname.Font = new Font("Segoe UI", 13F);
        txtSurname.Location = new Point(175, 133);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(380, 42);
        txtSurname.TabIndex = 14;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 13F);
        label2.Location = new Point(27, 136);
        label2.Name = "label2";
        label2.Size = new Size(123, 36);
        label2.TabIndex = 13;
        label2.Text = "Surname:";
        // 
        // txtName
        // 
        txtName.Font = new Font("Segoe UI", 13F);
        txtName.Location = new Point(175, 72);
        txtName.Name = "txtName";
        txtName.Size = new Size(380, 42);
        txtName.TabIndex = 12;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 13F);
        label1.Location = new Point(27, 75);
        label1.Name = "label1";
        label1.Size = new Size(89, 36);
        label1.TabIndex = 11;
        label1.Text = "Name:";
        // 
        // dtgridCustomers
        // 
        dtgridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgridCustomers.Location = new Point(27, 416);
        dtgridCustomers.Name = "dtgridCustomers";
        dtgridCustomers.RowHeadersWidth = 62;
        dtgridCustomers.Size = new Size(1216, 591);
        dtgridCustomers.TabIndex = 22;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 19F);
        label4.Location = new Point(27, 362);
        label4.Name = "label4";
        label4.Size = new Size(201, 51);
        label4.TabIndex = 23;
        label4.Text = "Customers";
        // 
        // AddCustomerForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1395, 1073);
        Controls.Add(label4);
        Controls.Add(dtgridCustomers);
        Controls.Add(btnAdd);
        Controls.Add(txtAddress);
        Controls.Add(label5);
        Controls.Add(txtPhone);
        Controls.Add(Phone);
        Controls.Add(txtEmail);
        Controls.Add(label3);
        Controls.Add(txtSurname);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(label1);
        Name = "AddCustomerForm";
        Text = "AddCustomerForm";
        Load += AddCustomerForm_Load;
        ((System.ComponentModel.ISupportInitialize)dtgridCustomers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnAdd;
    private TextBox txtAddress;
    private Label label5;
    private TextBox txtPhone;
    private Label Phone;
    private TextBox txtEmail;
    private Label label3;
    private TextBox txtSurname;
    private Label label2;
    private TextBox txtName;
    private Label label1;
    private DataGridView dtgridCustomers;
    private Label label4;
}