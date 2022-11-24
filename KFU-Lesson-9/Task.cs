using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_9
{
    internal class Task
    {

        public string Name { get; set; }
        public string Description { set; get; }
        public DateTime DeadLine { get; set; }
        public sstatus Status { get; set; }
        public Rabotyaga Executor { set; get; }
        public Report Report { get; set; }


        public Task(string Name, string Description, DateTime DeadLine, sstatus Status)
        {
            this.Name = Name;
            this.Description = Description;
            this.DeadLine = DeadLine;
            this.Status = Status;

        }


        public bool Dovolen()
        {
            Console.WriteLine($"{Executor.Name} который специализируется на {Executor.Specialization} получил задачу {Name}");
            Console.WriteLine("Ты доволен своей задачей? (да,нет)");
            string otvet = Console.ReadLine();
            if (otvet == "да")
            {
                Status = sstatus.inwork;
                return true;
            }

            else return false;
        }


        public void NewReport()
        {
            Status = sstatus.inwork;
            Console.WriteLine("Введите новый отчет");
            string otchet = Console.ReadLine();
            Report.Text = otchet;
            Report.Date = DateTime.Now;
            Status = sstatus.review;
        }
    }
}
