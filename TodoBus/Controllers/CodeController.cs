using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBus.Models;

namespace TodoBus.Controllers
{
    class CodeController
    {
        public bool save(string code)
        {
            using (TodoBusEntities db = new TodoBusEntities())
            {
                try
                {
                    //Formato de codigo a ingresar [categoria - subcategoria - subclase]
                    spare_codes codeSpare = new spare_codes();

                    codeSpare.code = code;
                    codeSpare.count_spare = 1;

                    db.spare_codes.Add(codeSpare);
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public int findSpareCode(string code)
        {
            try
            {
                using (TodoBusEntities db = new TodoBusEntities())
                {
                    var lst = from d in db.spare_codes
                               where d.code == code
                               select d;

                    int countCode = 0;

                    if (lst.Count() > 0)
                    {
                        spare_codes codeSpare = new spare_codes();
                        codeSpare = lst.First();
                        countCode = codeSpare.count_spare + 1;

                        codeSpare.count_spare += 1;

                        db.Entry(codeSpare).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        bool save = this.save(code);
                        if (save)
                        {
                            countCode = 1;                            
                        }
                    }

                    return countCode;
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
