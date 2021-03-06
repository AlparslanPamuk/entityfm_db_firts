﻿using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityfm_db_firts
{
    class Program
    {
        public enum Level : byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }
        static void Main(string[] args)
        {
            //var course = new Level();
            //course.Level1 = CourseLevel.Beginner;


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

            //-----------------Select * from table Query -------------------------------------//

            //var result = db.Tbl_Doctors;
            //ConsoleTable.From(result).Write(); // method
            //Console.ReadLine();

            //-----------------Select Id as ID, name as name From table Query-----------------//

            //var result = db.Tbl_Doctors.Select(x => new
            //{
            //    Id = x.docid,
            //    Name = x.docname
            //});
            //ConsoleTable.From(result).Write(); 
            //Console.ReadLine();

            //-----------------Select Top(2) * from tbl---------------------------------------//

            //var result = db.Tbl_Doctors.Take(2);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  orderby name -------------------------------//

            //var result = db.Tbl_Doctors.OrderBy(x=>x.docname);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  orderby name desc --------------------------//

            //var result = db.Tbl_Doctors.OrderByDescending(x => x.docname);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  where ID<5 ---------------------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docid < 5);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  where ID=1 OR ID=3 -------------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docid == 1 || x.docid == 3);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  where ID<>4 and ID<>7 ----------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docid != 4 && x.docid != 7);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  where ID between 3 and 6 -------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docid >= 3 && x.docid <= 6);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl  where ID NOT between 3 and 6 ---------------//

            //var result = db.Tbl_Doctors.Where(x => x.docid < 3 || x.docid > 6);
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select sum(ID) from tbl ---------------------------------------//

            //var result = db.Tbl_Doctors.Sum(x => x.docid);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //-----------------Select avg(ID) from tbl ---------------------------------------//

            //var result = db.Tbl_Doctors.Average(x => x.docid);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //-----------------Select max(ID) from tbl ---------------------------------------//

            //var result = db.Tbl_Doctors.Max(x => x.docid);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //-----------------Select min(ID) from tbl ----------------------------------------//

            //var result = db.Tbl_Doctors.Min(x => x.docid);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //-----------------Select ID as ID, ID*ID as ID square from tbl -------------------//

            //var result = db.Tbl_Doctors.Select(x => new
            //{
            //    Id = x.docid,
            //    IdSquare = x.docid * x.docid
            //});
            //ConsoleTable.From(result).Write() ;
            //Console.ReadLine();

            //-----------------Select * from tbl where Name like '%...%' ----------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docname.Contains("Mustafa Alparslan Pamuk"));
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //-----------------Select * from tbl where Name like '%sa%' ----------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docname.StartsWith("sa"));
            //ConsoleTable.From(result).Write();                                                    //Start with "sa".
            //Console.ReadLine();

            //-----------------Select * from tbl where Name like '%fg%' ----------------------//

            //var result = db.Tbl_Doctors.Where(x => x.docname.EndsWith("fg"));
            //ConsoleTable.From(result).Write();                                                       //Ends with "fg".
            //Console.ReadLine();


            //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   
            //==//   //==//   //==//   //==//   //==//   JOIN AND GROUP BY QUERIES //==//   //==//   //==//   //==//   //==//   //==//   
            //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//   //==//      

            //---- select name, name  from tbl join  tbl on tbl.column=tbl.column ------------------------------------//

            //var result = from d in db.Tbl_Doctors
            //             join a in db.Tbl_Appointments
            //             on d.docid equals a.appointmentid
            //             select new
            //             {
            //                 d.docname,
            //                 a.patientcomplaint
            //             };
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //---- select name, name, name from tbl join tbl on tbl.column=tbl.column Order By column desc -----------//

            //var result = from d in db.Tbl_Doctors
            //             join a in db.Tbl_Appointments
            //             on d.docid equals a.appointmentid
            //             orderby d.docpassword descending
            //             select new
            //             {
            //                 d.docname,
            //                 a.patientcomplaint,
            //                 d.docpassword
            //             };
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //---- select id, count(*) as smth from tbl Group By ID ---------------------------------------------------//

            //var result = from d in db.Tbl_Doctors
            //             group d by d.docid into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOf = g.Count()
            //             };
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //---- select name, Count(*) as smth from tbl join tbl on  tbl.column=tbl.column Group By name -----------//

            //var result = from d in db.Tbl_Doctors
            //             join a in db.Tbl_Appointments
            //             on d.docid equals a.appointmentid
            //             group a by a.appointmentbranch into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts = g.Count() 
            //             };
            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //---- select categoryname,Count(*)  as  Number of Products, 
            //---- sum(unitprice) as TotalPrice,
            //---- max(unitprice) as MaxPrice,
            //---- min(unitprice) as MinPrice
            //---- from tbl join tbl on tbl.column=tbl.column Group By column -----------//-----------//-----------//-----------//

            //var result = from p in db.Tbl_Doctors
            //             join c in db.Tbl_Appointments
            //             on p.docid equals c.appointmentid
            //             group new { c, p } by new { c.appointmentbranch } into g
            //             select new
            //             {
            //                 g.Key.appointmentbranch,
            //                 NumberOfProducts = g.Count(),
            //                 TotalPrice =g.Sum(x=>x.p.doctc),
            //                 MaxPrice = g.Max(x=>x.p.doctc),
            //                 MinPrice= g.Min(x=>x.p.doctc)

            //             };

            //ConsoleTable.From(result).Write();
            //Console.ReadLine();

            //---- select categoryname,Count(*)  as  Number of Products, 
            //---- sum(unitprice) as TotalPrice,
            //---- max(unitprice) as MaxPrice,
            //---- min(unitprice) as MinPrice
            //---- from tbl join tbl on tbl.column=tbl.column Group By column
            //---- having sum(Unitprice)>300 -----------//-----------//-----------//-----------//-----------//-----------//-------//

            //var result = (from p in db.Tbl_Doctors
            //             join c in db.Tbl_Appointments
            //             on p.docid equals c.appointmentid
            //             group new { c, p } by new { c.appointmentbranch } into g
            //             select new
            //             {
            //                 g.Key.appointmentbranch,
            //                 NumberOfProducts = g.Count(),
            //                 TotalPrice = g.Sum(x => x.p.doctc),
            //                 MaxPrice = g.Max(x => x.p.doctc),
            //                 MinPrice = g.Min(x => x.p.doctc)

            //             }).Where(x=> x.TotalPrice>300);

            //ConsoleTable.From(result).Write();
            //Console.ReadLine();


            //------------------------------------------END OF JOİN QUERIES---------------------------------------\\

            //--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\

            //--Difference between Immediate mode and Defered mode--\\

            //var MustafaAlparslanPamuk = db.Tbl_Doctors.ToList(); ||*Immediate Mode*|| != EagerLoading

            //var MustafaAlparslanPamuk = db.Tbl_Doctors;  ||*Defered Mode*|| != LazyLoading

            //--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\//--||--&&--||\\


            //// ----------> LazyLoading
            //var Alparslan = db.Tbl_Doctors.Find(1);
            //var pamuk = db.Tbl_Appointments.Where(x => x.appointmentid == Alparslan.docid);
            //foreach (var product in pamuk)
            //{
            //    Console.WriteLine(product.appointmentbranch);
            //    Console.ReadLine();
            //}

            //// ----------> EagerLoading

            //var Alparslan = db.Tbl_Doctors.Include("Products").FirstOrDefault(x=> x.docid == 1);
            //var pamuk = Alparslan.docid;
            //foreach (var product in pamuk)
            //{
            //    Console.WriteLine(product.appointmentbranch);
            //    Console.ReadLine();
            //}


        



        }
    }
}
