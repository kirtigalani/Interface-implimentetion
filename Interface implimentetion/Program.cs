using System;


 
    interface ICustomer
    {
        void InterfaceMethod();
    }
    interface ICustomer1
    {
        void InterfaceMethod();
    }
    public class Program : ICustomer , ICustomer1
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("ICustomer Interface Method");
        }
        void ICustomer1.InterfaceMethod()
        {
            Console.WriteLine("ICustomer1 Interface Method");
        }
    public static void Main(string[] args)
        {
            Program p = new Program();
            p.InterfaceMethod();
            ((ICustomer1)p).InterfaceMethod();
    }
}

