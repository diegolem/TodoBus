using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class SpareUnitController
    {

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

    }
}
