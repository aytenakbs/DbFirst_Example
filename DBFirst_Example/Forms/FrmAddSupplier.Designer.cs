namespace DBFirst_Example.Forms;

partial class FrmAddSupplier
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
        txtCompanyName = new TextBox();
        label1 = new Label();
        btnAdd = new Button();
        txtContactName = new TextBox();
        label2 = new Label();
        SuspendLayout();
        // 
        // txtCompanyName
        // 
        txtCompanyName.Location = new Point(195, 52);
        txtCompanyName.Margin = new Padding(4, 4, 4, 4);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.Size = new Size(349, 31);
        txtCompanyName.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 58);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(141, 25);
        label1.TabIndex = 1;
        label1.Text = "Company Name";
        label1.Click += label1_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(301, 210);
        btnAdd.Margin = new Padding(4, 4, 4, 4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(190, 45);
        btnAdd.TabIndex = 2;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // txtContactName
        // 
        txtContactName.Location = new Point(195, 129);
        txtContactName.Margin = new Padding(4, 4, 4, 4);
        txtContactName.Name = "txtContactName";
        txtContactName.Size = new Size(349, 31);
        txtContactName.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 135);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(125, 25);
        label2.TabIndex = 1;
        label2.Text = "Contact Name";
        // 
        // FrmAddSupplier
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(621, 326);
        Controls.Add(btnAdd);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtContactName);
        Controls.Add(txtCompanyName);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4, 4, 4, 4);
        Name = "FrmAddSupplier";
        Text = "FrmAddSupplier";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtCompanyName;
    private Label label1;
    private Button btnAdd;
    private TextBox txtContactName;
    private Label label2;
}