namespace DBFirst_Example.Forms;

partial class FormSupplier
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
        dtGridSupplier = new DataGridView();
        btnDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)dtGridSupplier).BeginInit();
        SuspendLayout();
        // 
        // dtGridSupplier
        // 
        dtGridSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridSupplier.Location = new Point(12, 85);
        dtGridSupplier.Name = "dtGridSupplier";
        dtGridSupplier.RowHeadersWidth = 51;
        dtGridSupplier.Size = new Size(766, 335);
        dtGridSupplier.TabIndex = 0;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(12, 29);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(142, 37);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // FormSupplier
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnDelete);
        Controls.Add(dtGridSupplier);
        Name = "FormSupplier";
        Text = "FormSupplier";
        Load += FormSupplier_Load;
        ((System.ComponentModel.ISupportInitialize)dtGridSupplier).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dtGridSupplier;
    private Button btnDelete;
}