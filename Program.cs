using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            VesoArray myarr = new VesoArray();
            myarr.push('a');
            myarr.push('b');
            myarr.push('c');
            myarr.push('d');
            myarr.Remove(2);
        }
    }
} 
