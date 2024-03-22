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
public partial class FrmAddSupplier : Form
{
    public FrmAddSupplier()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        SupplierService supplierService=new SupplierService();
        Supplier supplier = new Supplier();
        supplier.CompanyName=txtCompanyName.Text;
        supplier.ContactName=txtContactName.Text;
        supplierService.AddSupplier(supplier);
        MessageBox.Show("Supplier added successfully");
    }
}
