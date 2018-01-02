using System;

namespace SampleApp
{
    public delegate void MyDel();

    class EventProgram
    {
        event MyDel ItemsRejected;
        event MyDel ItemsPresented;
        public EventProgram()
        {
            this.ItemsRejected += new MyDel(this.ItemsRejected_handler);
            this.ItemsPresented += new MyDel(this.ItemsPresented_handler);
        }

        public void ItemsRejected_handler()
        {
            Console.WriteLine(">>> ItemsRejected");
            Console.WriteLine("<<< ItemsRejected");
        }

        public void ItemsPresented_handler()
        {
            Console.WriteLine(">>> ItemsPresented");
            Console.WriteLine(">>> ItemsPresented");
        }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            obj1.ItemsPresented();
            obj1.ItemsRejected();
        }

    }
}