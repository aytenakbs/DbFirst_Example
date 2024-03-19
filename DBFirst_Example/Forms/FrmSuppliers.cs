using DBFirst_Example.Models;
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
public partial class FrmSuppliers : Form
{
    public FrmSuppliers()
    {
        InitializeComponent();
    }

    void FrmSuppliers_Load(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();
        var suppliers = db.Suppliers.ToList();
        dtGridSuppliers.DataSource = suppliers;
    }

    private void btnOrderByCompanyName_Click(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();
        var suppliers = db.Suppliers.OrderBy(x => x.CompanyName).ToList();
        dtGridSuppliers.DataSource = suppliers;
    }

    private void txtCompanyNameSearch_TextChanged(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();
        string search = txtCompanyNameSearch.Text;
        var suppliers = db.Suppliers.Where(x => x.CompanyName.StartsWith(search)).OrderBy(x => x.CompanyName).ToList();
        dtGridSuppliers.DataSource = suppliers;
    }

    private void txtTake_TextChanged(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();
        int take = Convert.ToInt32(txtTake.Text);
        var values = db.Suppliers.Take(take).ToList();
        dtGridSuppliers.DataSource = values;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dtGridSuppliers.CurrentRow.Cells[0].Value);
        NorthwndContext db = new NorthwndContext();
        Supplier supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        if (supplier != null)
        {
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
            LoadSuppliers();
        }
    }

    void LoadSuppliers()
    {
        NorthwndContext db = new NorthwndContext();
        var suppliers = db.Suppliers.ToList();
        dtGridSuppliers.DataSource = suppliers;
    }

    private void dtGridSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int id = Convert.ToInt32(dtGridSuppliers.CurrentRow.Cells[0].Value);
        NorthwndContext db = new NorthwndContext();
        Supplier supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        if (supplier != null)
        {
            txtCompanyName.Text = supplier.CompanyName;
            txtContactName.Text = supplier.ContactName;
            txtContactTitle.Text = supplier.ContactTitle;
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dtGridSuppliers.CurrentRow.Cells[0].Value);
        NorthwndContext db = new NorthwndContext();
        Supplier supplier=db.Suppliers.FirstOrDefault( x => x.SupplierId == id);
        supplier.CompanyName= txtCompanyName.Text;
        supplier.ContactName= txtContactName.Text;
        supplier.ContactTitle= txtContactTitle.Text;
        db.SaveChanges();
        LoadSuppliers();
    }
}
