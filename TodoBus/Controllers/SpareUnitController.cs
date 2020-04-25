using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBus.Models;
using Bunifu.Framework.UI;

namespace TodoBus.Controllers
{
    class SpareUnitController
    {
        private List<int> lstSpareUnits = new List<int>();

        public List<FakeSpareUnit> getAllSpares()
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare
                          join m in db.brands on d.brand_id equals m.id
                          join c in db.spare_categories on d.spare_type_id equals c.id
                          select d;

                if (lst.Count() > 0)
                {
                    List<FakeSpareUnit> customL = new List<FakeSpareUnit>();

                    foreach (var spare in lst)
                    {                      
                        FakeSpareUnit spareF = new FakeSpareUnit();
                        spareF.Spare_id = spare.id;
                        spareF.Codigo = spare.code;
                        spareF.Nombre = spare.name;
                        spareF.NombreMarca = spare.brands.name;
                        spareF.NombreCategoria = spare.spare_categories.name;

                        if (!(customL.Exists(c => c.Spare_id == spare.id)))
                        {
                            customL.Add(spareF);
                        }
                    }

                    for (int i = 0; i < lstSpareUnits.Count(); i++)
                    {
                        var itemToRemove = customL.Single(s => s.Spare_id == lstSpareUnits[i]);
                        if (itemToRemove != null)
                        {
                            customL.Remove(itemToRemove);
                        }
                    }

                    return customL;
                }
                else
                {
                    List<FakeSpareUnit> newSC = new List<FakeSpareUnit>();
                    return newSC;
                }
            }
        }

        public void spareInformation(int spare_id,ref Label lblNotImage, ref BunifuCustomLabel lblName, ref BunifuCustomLabel lblBrand, ref BunifuCustomLabel lblCategory,ref BunifuCustomLabel lblCode, ref  WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription, ref PictureBox picImage)
        {
            using(TodoBusEntities db = new TodoBusEntities())
            {
                var lst = from d in db.spare
                          where d.id == spare_id
                          select d;
                spare spare = lst.First();

                lblName.Text = "Nombre: " + spare.name;
                lblCategory.Text = "Categoría: " + spare.spare_categories.name;
                lblCode.Text = "Código: " + spare.code;
                txtDescription.Text = "Descripción: " + spare.description;
                lblBrand.Text = "Marca: " + spare.brands.name;
                if(spare.image != "Imagen no insertada")
                {
                    lblNotImage.Visible = false;
                    picImage.Visible = true;
                    picImage.Load(spare.image);
                }
                else
                {
                    lblNotImage.Visible = true;
                    picImage.Visible = false;
                }
            }
        }

        public List<FakeSpareUnit> getAllAsignedSpares(int unit_id)
        {
            using(TodoBusEntities db = new TodoBusEntities())
            {
                this.lstSpareUnits.Clear();

                var lst = from d in db.units_spare
                          join s in db.spare on d.spare_id equals s.id
                          join m in db.brands on s.brand_id equals m.id
                          join c in db.spare_categories on s.spare_type_id equals c.id
                          where d.unit_id == unit_id
                          select d;
                if(lst.Count() > 0)
                {
                    List<FakeSpareUnit> customL = new List<FakeSpareUnit>();
                    foreach (var units_spare in lst)
                    {
                        this.lstSpareUnits.Add(units_spare.spare.id);

                        FakeSpareUnit spareF = new FakeSpareUnit();                        
                        spareF.Spare_id = units_spare.spare.id;
                        spareF.Codigo = units_spare.spare.code;
                        spareF.Nombre = units_spare.spare.name;
                        spareF.NombreMarca = units_spare.spare.brands.name;
                        spareF.NombreCategoria = units_spare.spare.spare_categories.name;
                        customL.Add(spareF);
                    }
                    return customL;
                }
                else
                {
                    List<FakeSpareUnit> newSC = new List<FakeSpareUnit>();
                    return newSC;
                }
            }
        }

        public bool save(int unit_id, int spare_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.units_spare
                              where d.unit_id == unit_id && d.spare_id == spare_id
                              select d;
                    if (lst.Count() == 0)
                    {
                        units_spare unitSpare = new units_spare();
                        unitSpare.spare_id = spare_id;
                        unitSpare.unit_id = unit_id;

                        db.units_spare.Add(unitSpare);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool remove(int unit_id, int spare_id)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    var lst = from d in db.units_spare
                              where d.unit_id == unit_id && d.spare_id == spare_id
                              select d;
                    if (lst.Count() == 1)
                    {                       
                        db.units_spare.Remove(lst.First());
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
