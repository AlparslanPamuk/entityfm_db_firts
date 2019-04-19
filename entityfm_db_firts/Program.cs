using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityfm_db_firts
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalProjectEntities db = new HospitalProjectEntities();
            var doctors = db.Tbl_Doctors;
            foreach (var doc in doctors)
            {
                Console.WriteLine(doc.docname);
                Console.ReadLine();
            }

        }
    }
}
