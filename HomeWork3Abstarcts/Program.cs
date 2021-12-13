using System;

namespace HomeWork3Abstarcts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract classlar da tıpkı interface'ler gibi new'lenemezler.
            Database database = new Sql();
            database.Add();//Add methodu abstract içinde default olarak tanımlandığı için default gelecektir.
            database.Delete();//Delete methodu ise abstract classı inherit eden diğer classlarda farklı olduğu için interfaceler gibi implemente edilir.
            Database database2 = new Oracle();
            database2.Add();//Add methodu implemente olmasa bile burada çağırılabiliyor çünkü oracle ve sql sınıfları  database abstract sınıfnı inherit ediyor. (Abstract Özellik)
            database2.Delete();//Delete methodu tıpkı interfaceler gibi zorunlu implemente edildi. 
        }
    }

    abstract class Database
    {

        //Burada Add methodunu default olarak belirliyorum. Methodumu sadece public void Add() olarak oluşturuyorum...
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }

        //Burada ise Delete Methodumu public abstract void Delete şeklinde oluşyuruyorum.
        //Bu sayede oluşturduğum bu abstract method, abstract sınıfını inherit eden diğer sınıflar için hem implemente edilmesi zorunlu olacak,
        //hem de farklı şekilde çalıştırılabilecek.
        public abstract void Delete();
       
    }
    class Sql : Database
    {
        //Sadece delete methodu geldi, çünkü abstract method.
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        //Sadece delete methodu geldi çünkü abstract method.
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle.");
        }
    }

}
