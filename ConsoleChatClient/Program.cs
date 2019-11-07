using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ApplicationBase app = new ApplicationBase();
            app.StartApplication();

            Console.CursorVisible = true;
        }
    }
}
