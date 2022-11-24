using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_9
{
    internal class Project
    {

        public string Description { get; set; }
        public string Customer { get; set; }
        public Rabotyaga TimLId { get; set; }
        public DateTime DeadLine { get; set; }
        public status Status { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string description, string customer, Rabotyaga timLId, DateTime deadLine, status status)
        {
            Description = description;
            Customer = customer;
            TimLId = timLId;
            DeadLine = deadLine;
            Status = status;
        }

        public void Print()
        {
            Console.WriteLine($"{TimLId.Name} говорит, что у их команды новый проект от {Customer},\nим надо {Description} до {DeadLine}");
        }


        public void Taskk(List<Task> list)
        {
            if (Status == status.project)
            {
                Tasks = list;
                Status = status.execution;
            }
            else Console.WriteLine("В этот проект нельзя добавлять задачи");
        }



        public void TaskLeader(List<Rabotyaga> rabs)
        {
            List<Rabotyaga> a = new List<Rabotyaga>();
            List<Task> list = new List<Task>();
            for (int i = 0; i < rabs.Count; i++)
            {
                Tasks[i].Executor = rabs[i];
                Tasks[i].Status = sstatus.appointed;
            }
        }




        public void ReportCheck()
        {
            bool c = false;
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Status != sstatus.complited)
                {
                    Console.WriteLine($"{Tasks[i].Executor.Name} написал в своем отчете:");
                    Console.WriteLine(Tasks[i].Report.Text);
                    Console.WriteLine("Вас устраивает этот отчет?(да, нет)");
                    string answer = Console.ReadLine();
                    if (answer == "да") Tasks[i].Status = sstatus.complited;
                    else
                    {
                        c = true;
                        Console.WriteLine("Вы все еще хотите выполнить это задание? (да,нет)");
                        string answ = Console.ReadLine();
                        if (answ == "да") Tasks[i].NewReport();
                        else Tasks.RemoveAt(i);
                    }
                }

            }
            if (c) ReportCheck();
            else
            {
                Console.WriteLine("Поздравляю вы завершили проект");
                Status = status.closed;
            }


        }


    }
}
