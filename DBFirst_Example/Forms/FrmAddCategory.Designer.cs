namespace DBFirst_Example.Forms;

partial class FrmAddCategory
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
        txtCategoryName = new TextBox();
        label2 = new Label();
        txtDescription = new TextBox();
        btnAdd = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(71, 44);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(140, 25);
        label1.TabIndex = 0;
        label1.Text = "Category Name:";
        label1.Click += label1_Click;
        // 
        // txtCategoryName
        // 
        txtCategoryName.Location = new Point(215, 38);
        txtCategoryName.Margin = new Padding(4);
        txtCategoryName.Name = "txtCategoryName";
        txtCategoryName.Size = new Size(345, 31);
        txtCategoryName.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(71, 85);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(106, 25);
        label2.TabIndex = 0;
        label2.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(215, 79);
        txtDescription.Margin = new Padding(4);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(345, 31);
        txtDescription.TabIndex = 1;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(279, 129);
        btnAdd.Margin = new Padding(4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(281, 39);
        btnAdd.TabIndex = 2;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmAddCategory
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(620, 276);
        Controls.Add(btnAdd);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtCategoryName);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmAddCategory";
        Text = "FrmAddCategory";
        Load += FrmAddCategory_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtCategoryName;
    private Label label2;
    private TextBox txtDescription;
    private Button btnAdd;
}