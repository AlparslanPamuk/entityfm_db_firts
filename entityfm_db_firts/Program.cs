using ConsoleTables;
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
            //var doctors = db.Tbl_Doctors;
            //foreach (var doc in doctors)
            //{
            //    Console.WriteLine(doc.docname);
            //    Console.ReadLine();
            //}




            ////////////////////////////////////////////////////// UPDATE ////////////////////////////////////////////////////////////////
            //var Alparslan = db.Tbl_Doctors.Find(3); // Find works with only primary key
            //Alparslan.docname = "Test";
            //Alparslan.docsurname = "Test";
            //db.SaveChanges();

            ////////////////////////////////////////////////////// DELETE ////////////////////////////////////////////////////////////////

            //var Alparslan = db.Tbl_Doctors.Find(3);
            //db.Tbl_Doctors.Remove(Alparslan);
            //db.SaveChanges();

            // select * from table Query //
            var result = db.Tbl_Doctors;
            ConsoleTable.From(result).Write(); // method
            Console.ReadLine();
                



        }
    }
}
