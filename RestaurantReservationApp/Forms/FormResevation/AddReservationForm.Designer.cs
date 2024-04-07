namespace RestaurantReservationApp.Forms.FormResevation;

partial class AddReservationForm
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
        label1 = new Label();
        cmbCustomer = new ComboBox();
        label2 = new Label();
        dateTimePicker1 = new DateTimePicker();
        richTextBox1 = new RichTextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(74, 97);
        label1.Name = "label1";
        label1.Size = new Size(93, 25);
        label1.TabIndex = 0;
        label1.Text = "Customer:";
        // 
        // cmbCustomer
        // 
        cmbCustomer.FormattingEnabled = true;
        cmbCustomer.Location = new Point(244, 89);
        cmbCustomer.Name = "cmbCustomer";
        cmbCustomer.Size = new Size(278, 33);
        cmbCustomer.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(74, 164);
        label2.Name = "label2";
        label2.Size = new Size(149, 25);
        label2.TabIndex = 2;
        label2.Text = "Reservation Date:";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(244, 159);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(278, 31);
        dateTimePicker1.TabIndex = 4;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(74, 239);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(448, 136);
        richTextBox1.TabIndex = 5;
        richTextBox1.Text = "";
        // 
        // AddReservationForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1091, 750);
        Controls.Add(richTextBox1);
        Controls.Add(dateTimePicker1);
        Controls.Add(label2);
        Controls.Add(cmbCustomer);
        Controls.Add(label1);
        Name = "AddReservationForm";
        Text = "AddReservationForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox cmbCustomer;
    private Label label2;
    private DateTimePicker dateTimePicker1;
    private RichTextBox richTextBox1;
}