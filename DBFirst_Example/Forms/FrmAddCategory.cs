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
public partial class FrmAddCategory : Form
{
    public FrmAddCategory()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void FrmAddCategory_Load(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Category category = new Category();
        category.CategoryName= txtCategoryName.Text.Trim();
        category.Description= txtDescription.Text.Trim();
        CategoryService categoryService = new CategoryService();
        categoryService.AddCategory(category);
        
    }
}
