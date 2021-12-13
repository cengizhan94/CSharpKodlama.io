using System;

namespace HomeWork2Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {//Interfaceler new'lenemez
            //IPersonManager manager = new CustomerManager();
            //manager.Add();
            //IPersonManager manager2 = new EmployeeManager();
            //manager2.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
        }
    }

    
    interface IPersonManager
    {
        //Unımplemented operation
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        
        public void Add()
        {
            Console.WriteLine("Customer Added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated.");
        }
    }

    //For JavaScript --> inheritance - implements || classes - extends
    //For C# --> :
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added.");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
            //personManager.Update();
        }

    }
}
