using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1,2,3");
            Bank bank1 = new Bank(1234, Bank.tip.current);
            Bank bank2 = new Bank(1000,Bank.tip.current);
            bank1.Print();
            bank2.Print();
            bank1.Takeoff();
            bank1.Takeon();
            bank1.transfer(bank2,234);
            bank1.PrintMoneySell();
            bank2.PrintMoneySell();
            bank1.Print();
            bank2.Print();
            bank1.Dispose();





            
            Console.WriteLine("Домашнее задание 1");
            Song newSong = new Song("Banka parilka", "MC POX");
            Song newSong1 = new Song("Мой Байк", "СЕРЕГА ПИРАТ", newSong);
            Song newSong2 = new Song();
            newSong.Title();
            newSong1.Title();
            newSong2.Title();
            
        }
    }
}
