using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace consume_dll
{
    class Program
    {
        [DllImport("simplelibrary.dll", EntryPoint = "Add", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int x, int y);

        [DllImport("simplelibrary.dll", EntryPoint = "Pow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pow(ref int x, double y);
        static void Main(string[] args)
        {
            int res = Add(3, 8);
            Console.WriteLine("Add(3, 8) = {0}", res);

            int x = 4;
            double y = 2;
            Pow(ref x, y);
            Console.WriteLine("Pow(4, 2) = {0}", x);
        }
    }
}
