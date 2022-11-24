using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Bank
    {
        public enum tip
        {
            current,
            saving
        }
        private int Id = 0;
        private int Balans;
        private tip Type;
        private static int Idk;
        private Queue<BankTransaction> queue = new Queue<BankTransaction>();

        public Bank(int Balans, tip Type)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
            this.Type = Type;
        }


        public Bank(int Balans)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
        }

        public Bank(tip Type)
        {
            Idk++;
            Id = Idk;
            this.Type = Type;
        }

        public void Takeoff()
        {
            Console.WriteLine("Введите сумму, которую хотите снять");
            int off = int.Parse(Console.ReadLine());
            BankTransaction bankTransaction = new BankTransaction(-off);

            if (Balans > off)
            {
                Balans -= off;
                queue.Enqueue(bankTransaction);
            }
            else
            {
                Console.WriteLine("Неправильно попробуй еще раз");
                Takeoff();
            }
        }
        public void Takeon()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int on = int.Parse(Console.ReadLine());
            BankTransaction bankTransaction = new BankTransaction(on);
            queue.Enqueue(bankTransaction);
            Balans += on;
        }
        public void transfer(Bank Bank, int sum)
        {
            if (Balans > sum)
            {
                BankTransaction bankTransaction = new BankTransaction(-sum);
                BankTransaction bankTransaction2 = new BankTransaction(sum);

                queue.Enqueue(bankTransaction);
                Balans -= sum;
                Bank.Balans += sum;
                Bank.queue.Enqueue(bankTransaction2);
            }
            else Console.WriteLine("Не хватает денег для перевода");
        }
        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
        public void PrintMoneySell()
        {
            foreach (BankTransaction item in queue)
                item.PrintInfo();

        }




        public void Dispose()
        {
            StreamWriter text = new StreamWriter("C:\\Users\\User\\source\\repos\\KFU-Lesson-9\\T00Much\\TextFile1.txt");

            foreach (BankTransaction item in queue)
            {
                string pivas = item.Printt();
                text.WriteLineAsync(pivas);

            }
            text.Close();
            GC.SuppressFinalize(this);
        }

    }
}
