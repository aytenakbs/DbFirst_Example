using DBFirst_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst_Example.Services;
public class CategoryService
{
    public void AddCategory(Category category)
    {
        NorthwndContext db = new NorthwndContext();
        db.Categories.Add(category);
        db.SaveChanges();
        MessageBox.Show("Category added successfully");

    }
    public List<Category> GetAllCategories()
    {
        NorthwndContext db = new NorthwndContext();
        List<Category> categories = db.Categories.OrderBy(x => x.CategoryName).ToList();
        return categories;
    }
    public void DeleteCategory(int id)
    {
        NorthwndContext db = new NorthwndContext();
        Category category = db.Categories.FirstOrDefault(x => x.CategoryId == id);
        if (category != null)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }

    }
    public Category GetCategoryByID(int id) 
    {
        NorthwndContext db= new NorthwndContext();
        Category category = db.Categories.FirstOrDefault(x=>x.CategoryId == id);
        return category;
    }
}
