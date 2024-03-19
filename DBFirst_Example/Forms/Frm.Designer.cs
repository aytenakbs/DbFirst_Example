namespace DBFirst_Example.Forms;

partial class Frm
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
        btnFilter = new Button();
        txtMax = new TextBox();
        txtMin = new TextBox();
        label2 = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(361, 25);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(126, 64);
        btnFilter.TabIndex = 14;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = true;
        // 
        // txtMax
        // 
        txtMax.Location = new Point(113, 62);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(220, 27);
        txtMax.TabIndex = 12;
        // 
        // txtMin
        // 
        txtMin.Location = new Point(113, 25);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(220, 27);
        txtMin.TabIndex = 13;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(52, 32);
        label2.Name = "label2";
        label2.Size = new Size(37, 20);
        label2.TabIndex = 10;
        label2.Text = "Min:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(52, 69);
        label1.Name = "label1";
        label1.Size = new Size(40, 20);
        label1.TabIndex = 11;
        label1.Text = "Max:";
        // 
        // Frm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnFilter);
        Controls.Add(txtMax);
        Controls.Add(txtMin);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Frm";
        Text = "Frm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnFilter;
    private TextBox txtMax;
    private TextBox txtMin;
    private Label label2;
    private Label label1;
}