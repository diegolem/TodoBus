using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class SpareController
    {
        public bool save(string codigo,string nombre,int tipo,int marca,string imagen)
        {
            using(TodoBusEntities db=new TodoBusEntities())
            {
                try
                {
                    spare oSpare = new spare();
                    oSpare.code = codigo;
                    oSpare.name = nombre;
                    oSpare.spare_type_id = tipo;
                    oSpare.brand_id = marca;
                    oSpare.image = imagen;

                    db.spare.Add(oSpare);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
            
        }
        public void llenarCMB(ref List<int> typeid, ref List<int> brandid, ref List<string> fillcmb1, ref List<string> fillcmb2)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {             
                var lst1 = from d in db.spare_categories
                           select d;               
                foreach (var category in lst1)
                {
                    fillcmb1.Add(category.name);
                   
                    typeid.Add(category.id);
                }
                var lst2 = from d in db.brands
                           select d;           
                foreach (var category in lst2)
                {
                    fillcmb2.Add(category.name);                    
                    brandid.Add(category.id);
                }
            }
        }
        public List<spare> getAllSpare()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                
                var lst = from d in db.spare
                          select d;
                
                if (lst.Count() > 0)
                {
                    return lst.ToList();
                }
                else
                {
                    List<spare> newSC = new List<spare>();
                    return newSC;
                }
            }
        }
        public bool delete(int? id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                   
                    spare subc = db.spare.Find(id);
                    
                    db.spare.Remove(subc);
                    
                    db.SaveChanges();
                    
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
