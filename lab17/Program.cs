using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> account1 = new BankAccount<int>();
            Console.WriteLine("Введите номер счета");
            try
            {
                account1.Num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            account1.Set();
            account1.Print();

            BankAccount<string> account2 = new BankAccount<string>();
            Console.WriteLine("Введите номер счета");
            account2.Num = Console.ReadLine();
            account2.Set();
            account2.Print();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        public T Num { get; set; }
        private double Remain { get; set; }
        private string Name { get; set; }

        public void Set()
        {
            Console.WriteLine("Введите остаток");
            Remain = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Номер счета - {0}", Num);
            Console.WriteLine("Остаток - {0}", Remain);
            Console.WriteLine("ФИО - {0}", Name);
        }


    }
}
