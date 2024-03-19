namespace DBFirst_Example.Forms;

partial class FrmCreateSupplier
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
        txtCompanyName = new TextBox();
        label2 = new Label();
        txtContactName = new TextBox();
        label3 = new Label();
        txtContactTitle = new TextBox();
        btnCreate = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(95, 51);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(141, 25);
        label1.TabIndex = 0;
        label1.Text = "Company Name";
        // 
        // txtCompanyName
        // 
        txtCompanyName.Location = new Point(224, 42);
        txtCompanyName.Margin = new Padding(4);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.Size = new Size(155, 31);
        txtCompanyName.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(95, 106);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(125, 25);
        label2.TabIndex = 0;
        label2.Text = "Contact Name";
        // 
        // txtContactName
        // 
        txtContactName.Location = new Point(224, 98);
        txtContactName.Margin = new Padding(4);
        txtContactName.Name = "txtContactName";
        txtContactName.Size = new Size(155, 31);
        txtContactName.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(95, 164);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(110, 25);
        label3.TabIndex = 0;
        label3.Text = "Contact Title";
        // 
        // txtContactTitle
        // 
        txtContactTitle.Location = new Point(224, 155);
        txtContactTitle.Margin = new Padding(4);
        txtContactTitle.Name = "txtContactTitle";
        txtContactTitle.Size = new Size(155, 31);
        txtContactTitle.TabIndex = 1;
        // 
        // btnCreate
        // 
        btnCreate.Location = new Point(224, 235);
        btnCreate.Margin = new Padding(4);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(156, 41);
        btnCreate.TabIndex = 2;
        btnCreate.Text = "Create";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        // 
        // FrmCreateSupplier
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(518, 384);
        Controls.Add(btnCreate);
        Controls.Add(txtContactTitle);
        Controls.Add(label3);
        Controls.Add(txtContactName);
        Controls.Add(label2);
        Controls.Add(txtCompanyName);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmCreateSupplier";
        Text = "FrmCreateSupplier";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtCompanyName;
    private Label label2;
    private TextBox txtContactName;
    private Label label3;
    private TextBox txtContactTitle;
    private Button btnCreate;
}