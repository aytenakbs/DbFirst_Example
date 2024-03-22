namespace DBFirst_Example.Forms;

partial class FrmCategories
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
        dtGridCategories = new DataGridView();
        btnDelete = new Button();
        label1 = new Label();
        txtName = new TextBox();
        btnUpdate = new Button();
        label3 = new Label();
        txtDescription = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dtGridCategories).BeginInit();
        SuspendLayout();
        // 
        // dtGridCategories
        // 
        dtGridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridCategories.Location = new Point(12, 12);
        dtGridCategories.Name = "dtGridCategories";
        dtGridCategories.RowHeadersWidth = 51;
        dtGridCategories.Size = new Size(865, 323);
        dtGridCategories.TabIndex = 0;
        dtGridCategories.CellClick += dtGridCategories_CellClick;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(12, 352);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(115, 37);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(366, 369);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 2;
        label1.Text = "Name:";
        // 
        // txtName
        // 
        txtName.Location = new Point(492, 362);
        txtName.Name = "txtName";
        txtName.Size = new Size(223, 27);
        txtName.TabIndex = 3;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(600, 449);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(115, 37);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnDelete_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(366, 402);
        label3.Name = "label3";
        label3.Size = new Size(88, 20);
        label3.TabIndex = 2;
        label3.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(492, 395);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(223, 27);
        txtDescription.TabIndex = 3;
        // 
        // FrmCategories
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(889, 564);
        Controls.Add(txtDescription);
        Controls.Add(label3);
        Controls.Add(txtName);
        Controls.Add(label1);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(dtGridCategories);
        Name = "FrmCategories";
        Text = "FrmCategories";
        Load += FrmCategories_Load;
        ((System.ComponentModel.ISupportInitialize)dtGridCategories).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dtGridCategories;
    private Button btnDelete;
    private Label label1;
    private TextBox txtName;
    private Button btnUpdate;
    private Label label3;
    private TextBox txtDescription;
}