namespace DBFirst_Example.Forms;

partial class FrmSuppliers
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
        dtGridSuppliers = new DataGridView();
        btnOrderByCompanyName = new Button();
        txtCompanyNameSearch = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtTake = new TextBox();
        btnDelete = new Button();
        label3 = new Label();
        txtCompanyName = new TextBox();
        label4 = new Label();
        txtContactName = new TextBox();
        label5 = new Label();
        txtContactTitle = new TextBox();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dtGridSuppliers).BeginInit();
        SuspendLayout();
        // 
        // dtGridSuppliers
        // 
        dtGridSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridSuppliers.Location = new Point(22, 232);
        dtGridSuppliers.Name = "dtGridSuppliers";
        dtGridSuppliers.RowHeadersWidth = 51;
        dtGridSuppliers.Size = new Size(1174, 447);
        dtGridSuppliers.TabIndex = 4;
        dtGridSuppliers.CellClick += dtGridSuppliers_CellClick;
        // 
        // btnOrderByCompanyName
        // 
        btnOrderByCompanyName.Location = new Point(22, 25);
        btnOrderByCompanyName.Name = "btnOrderByCompanyName";
        btnOrderByCompanyName.Size = new Size(172, 57);
        btnOrderByCompanyName.TabIndex = 5;
        btnOrderByCompanyName.Text = "Order by Company Name";
        btnOrderByCompanyName.UseVisualStyleBackColor = true;
        btnOrderByCompanyName.Click += btnOrderByCompanyName_Click;
        // 
        // txtCompanyNameSearch
        // 
        txtCompanyNameSearch.Location = new Point(289, 25);
        txtCompanyNameSearch.Name = "txtCompanyNameSearch";
        txtCompanyNameSearch.Size = new Size(125, 27);
        txtCompanyNameSearch.TabIndex = 6;
        txtCompanyNameSearch.TextChanged += txtCompanyNameSearch_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(216, 32);
        label1.Name = "label1";
        label1.Size = new Size(56, 20);
        label1.TabIndex = 7;
        label1.Text = "Search:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(442, 32);
        label2.Name = "label2";
        label2.Size = new Size(41, 20);
        label2.TabIndex = 9;
        label2.Text = "Take:";
        // 
        // txtTake
        // 
        txtTake.Location = new Point(515, 25);
        txtTake.Name = "txtTake";
        txtTake.Size = new Size(125, 27);
        txtTake.TabIndex = 8;
        txtTake.TextChanged += txtTake_TextChanged;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.OrangeRed;
        btnDelete.Location = new Point(22, 147);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(184, 46);
        btnDelete.TabIndex = 10;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(548, 97);
        label3.Name = "label3";
        label3.Size = new Size(116, 20);
        label3.TabIndex = 12;
        label3.Text = "Company Name";
        // 
        // txtCompanyName
        // 
        txtCompanyName.Location = new Point(683, 90);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.Size = new Size(302, 27);
        txtCompanyName.TabIndex = 11;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(548, 141);
        label4.Name = "label4";
        label4.Size = new Size(104, 20);
        label4.TabIndex = 14;
        label4.Text = "Contact Name";
        // 
        // txtContactName
        // 
        txtContactName.Location = new Point(683, 134);
        txtContactName.Name = "txtContactName";
        txtContactName.Size = new Size(302, 27);
        txtContactName.TabIndex = 13;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(548, 186);
        label5.Name = "label5";
        label5.Size = new Size(93, 20);
        label5.TabIndex = 16;
        label5.Text = "Contact Title";
        // 
        // txtContactTitle
        // 
        txtContactTitle.Location = new Point(683, 179);
        txtContactTitle.Name = "txtContactTitle";
        txtContactTitle.Size = new Size(302, 27);
        txtContactTitle.TabIndex = 15;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.LimeGreen;
        btnUpdate.Location = new Point(1010, 125);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(170, 44);
        btnUpdate.TabIndex = 17;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // FrmSuppliers
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1208, 704);
        Controls.Add(btnUpdate);
        Controls.Add(label5);
        Controls.Add(txtContactTitle);
        Controls.Add(label4);
        Controls.Add(txtContactName);
        Controls.Add(label3);
        Controls.Add(txtCompanyName);
        Controls.Add(btnDelete);
        Controls.Add(label2);
        Controls.Add(txtTake);
        Controls.Add(label1);
        Controls.Add(txtCompanyNameSearch);
        Controls.Add(btnOrderByCompanyName);
        Controls.Add(dtGridSuppliers);
        Name = "FrmSuppliers";
        Text = "FrmAddSupplier";
        Load += FrmSuppliers_Load;
        ((System.ComponentModel.ISupportInitialize)dtGridSuppliers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private DataGridView dtGridSuppliers;
    private Button btnOrderByCompanyName;
    private TextBox txtCompanyNameSearch;
    private Label label1;
    private Label label2;
    private TextBox txtTake;
    private Button btnDelete;
    private Label label3;
    private TextBox txtCompanyName;
    private Label label4;
    private TextBox txtContactName;
    private Label label5;
    private TextBox txtContactTitle;
    private Button btnUpdate;
}