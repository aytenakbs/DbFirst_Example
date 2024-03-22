using DBFirst_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst_Example.Services;
public class SupplierService
{
    public List<Supplier> GetSupplierList()
    {
        NorthwndContext db=new NorthwndContext();
        List<Supplier> values = db.Suppliers.OrderBy(x=>x.CompanyName).ToList();
        return values;
    }
    public void DeleteSupplier(int id)
    {
        NorthwndContext db=new NorthwndContext();
        Supplier value = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        db.Suppliers.Remove(value);
        db.SaveChanges();
    }
    public Supplier AddSupplier(Supplier supplier)
    {
        NorthwndContext db = new NorthwndContext();
        db.Suppliers.Add(supplier);
        db.SaveChanges ();
        return supplier;
    }
}
