using DBFirst_Example.Models;
using DBFirst_Example.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst_Example.Forms;
public partial class FormSupplier : Form
{
    public FormSupplier()
    {
        InitializeComponent();
    }

    private void FormSupplier_Load(object sender, EventArgs e)
    {
        SupplierService supplierService = new SupplierService();
        List<Supplier> values = supplierService.GetSupplierList();
        dtGridSupplier.DataSource = values;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(dtGridSupplier.CurrentRow.Cells[0].Value);
            SupplierService supplierService = new SupplierService();
            supplierService.DeleteSupplier(id);
            dtGridSupplier.DataSource = supplierService.GetSupplierList();
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
