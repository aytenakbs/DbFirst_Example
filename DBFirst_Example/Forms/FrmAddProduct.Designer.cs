namespace DBFirst_Example.Forms;

partial class FrmAddProduct
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
        txtName = new TextBox();
        cmbCategory = new ComboBox();
        btnAdd = new Button();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txtStock = new TextBox();
        label6 = new Label();
        label7 = new Label();
        txtUnitPrice = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(67, 28);
        label1.Name = "label1";
        label1.Size = new Size(95, 23);
        label1.TabIndex = 0;
        label1.Text = "Categories:";
        // 
        // txtName
        // 
        txtName.Location = new Point(214, 67);
        txtName.Name = "txtName";
        txtName.Size = new Size(151, 30);
        txtName.TabIndex = 1;
        // 
        // cmbCategory
        // 
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(214, 20);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(151, 31);
        cmbCategory.TabIndex = 2;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(214, 227);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(151, 31);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(67, 74);
        label2.Name = "label2";
        label2.Size = new Size(55, 23);
        label2.TabIndex = 0;
        label2.Text = "label1";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(67, 74);
        label3.Name = "label3";
        label3.Size = new Size(60, 23);
        label3.TabIndex = 0;
        label3.Text = "Name:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(67, 125);
        label4.Name = "label4";
        label4.Size = new Size(55, 23);
        label4.TabIndex = 0;
        label4.Text = "label1";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(67, 125);
        label5.Name = "label5";
        label5.Size = new Size(54, 23);
        label5.TabIndex = 0;
        label5.Text = "Stock:";
        // 
        // txtStock
        // 
        txtStock.Location = new Point(214, 118);
        txtStock.Name = "txtStock";
        txtStock.Size = new Size(151, 30);
        txtStock.TabIndex = 1;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(67, 172);
        label6.Name = "label6";
        label6.Size = new Size(55, 23);
        label6.TabIndex = 0;
        label6.Text = "label1";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(67, 172);
        label7.Name = "label7";
        label7.Size = new Size(88, 23);
        label7.TabIndex = 0;
        label7.Text = "Unit Price:";
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(214, 165);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(151, 30);
        txtUnitPrice.TabIndex = 1;
        // 
        // FrmAddProduct
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(447, 314);
        Controls.Add(btnAdd);
        Controls.Add(cmbCategory);
        Controls.Add(txtUnitPrice);
        Controls.Add(txtStock);
        Controls.Add(label7);
        Controls.Add(txtName);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "FrmAddProduct";
        Text = "FrmAddProduct";
        Load += FrmAddProduct_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtName;
    private ComboBox cmbCategory;
    private Button btnAdd;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtStock;
    private Label label6;
    private Label label7;
    private TextBox txtUnitPrice;
}