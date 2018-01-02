using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{
    public delegate void MyDel();
    class EventManager
    {
        public event MyDel ItemsRejected;
        public event MyDel ItemsPresented;
        public EventManager()
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
            Console.WriteLine("<<< ItemsPresented");
        }
    }
}
