using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_9
{
    public enum sstatus
    {
        inwork,
        appointed,
        review,
        complited
    }
    public enum status
    {
        project,
        execution,
        closed
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rabotyaga Toomakov = new Rabotyaga("Тумаков", "Сортировка");
            Rabotyaga FrontEnd = new Rabotyaga("Саша", "Фронтенд(интерфейс)");
            Rabotyaga BackEnd = new Rabotyaga("Макс", "Бэкенд(код сайта)");
            Rabotyaga Advertising1 = new Rabotyaga("Маша", "Реклама");
            Rabotyaga Advertising2 = new Rabotyaga("Артме", "Реклама");
            Rabotyaga Tester1 = new Rabotyaga("Настя", "Тестировщик");
            Rabotyaga Tester2 = new Rabotyaga("Алег", "Тестировщик");
            Rabotyaga Analyst = new Rabotyaga("Паша", "Аналитик");
            Rabotyaga Cook = new Rabotyaga("Зина", "Повар");
            Rabotyaga Creator = new Rabotyaga("Виталя", "Креатор");
            Rabotyaga TimLId = new Rabotyaga("Азат", "ТимЛИд");
            List<Rabotyaga> rabs = new List<Rabotyaga>() {Toomakov, Analyst, Cook, Tester1, Tester2, Advertising1, Advertising2, BackEnd, FrontEnd,Creator};
            Project project = new Project("Создать сайт для хранения файлов", "ООО Храни.Файлы", TimLId, new DateTime(2023,1,1),status.project);
            project.Print();

            
            Task taskToomakov = new Task("Cортировка", "Нужно написать алгоритм который будет сортировать файлы", new DateTime(2022, 12, 10), sstatus.appointed);
            Task taskAnalyst = new Task("Готовка", "Приготовить еды всему персоналу", new DateTime(2022, 11, 24 ), sstatus.appointed);
            Task taskCook = new Task("Анализирование", "Проанализировать окупится ли данный проект через полгода", new DateTime(2022, 12, 1), sstatus.appointed);
            Task taskTester1 = new Task("Тест","Протестировать сайт на наличие багов",new DateTime(2022,12,25),sstatus.appointed);
            Task taskTester2 = new Task("Тест", "Протестировать сайт на наличие багов", new DateTime(2022, 12, 25), sstatus.appointed);
            Task taskAdvertising1 = new Task("Реклама в ютубе","Договориться с популярным ютубером на рекламу",new DateTime(2022,12,20),sstatus.appointed);
            Task taskAdvertising2 = new Task("Реклама на сайтах", "Договориться с популярными сайтами на размещение рекламы", new DateTime(2022, 12, 20), sstatus.appointed);
            Task taskBackEnd = new Task("Бекенд","Написать серверную часть сайта",new DateTime(2022,12,20),sstatus.appointed);
            Task taskFrontEnd = new Task("Фронтенд", "Написать пользовательскую часть сайта", new DateTime(2022, 12, 20), sstatus.appointed);
            Task taskCreator = new Task("Креативность","Придумать название для сайта", new DateTime(2022,12,5),sstatus.appointed);
            List<Task> list = new List<Task>() { taskToomakov, taskAnalyst, taskCook, taskTester1, taskTester2, taskAdvertising1, taskAdvertising2, taskBackEnd, taskFrontEnd, taskCreator };
            project.Taskk(list);
            project.TaskLeader(rabs);



            List<Task> figlist = new List<Task>();
            List<Rabotyaga> rabloh = new List<Rabotyaga>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Dovolen())
                {
                    rabloh.Add(list[i].Executor);
                    list[i].Executor = null;
                    figlist.Add(list[i]);
                    
                }
            }
            

            for (int i = 0; i < figlist.Count; i++)
            {
                Console.WriteLine($"Впишите имя того, кто должен выполнить эту задачу:{figlist[i].Name}");
                string name = Console.ReadLine();
                bool das = true;
                for (int j = 0; j < rabloh.Count; j++)
                {
                    if (rabloh[j].Name == name)
                    {
                        figlist[i].Executor = rabloh[j];
                        das = !das;
                    }
                }
                if (das) Console.WriteLine("У нас нет сотрудника с таким именем");
            }


            Report reportToomakov = new Report("Выполнил сортировку все работает",new DateTime(2022,11,1),Toomakov);
            taskToomakov.Report = reportToomakov;
            taskToomakov.Status = sstatus.review;
            Report reportFrontEnd = new Report("Сделал пользовательскую часть сайта прекрасно", new DateTime(2022,11,5),FrontEnd);
            taskFrontEnd.Report = reportFrontEnd;
            taskFrontEnd.Status = sstatus.review;
            Report reportBackEnd = new Report("Сделал свою работу ", new DateTime(2022, 11, 5), BackEnd);
            taskBackEnd.Report = reportBackEnd;
            taskBackEnd.Status = sstatus.review;
            Report reportAdvertising1 = new Report("Багов с сайтом не обнаружено", new DateTime(2022,11,15),Advertising1);
            taskAdvertising1.Report = reportAdvertising1;
            taskAdvertising1.Status = sstatus.review;
            Report reportAdvertising2 = new Report("Багов с сайтом не обнаружено", new DateTime(2022, 11, 17), Advertising2);
            taskAdvertising2.Report = reportAdvertising2;
            taskAdvertising2.Status = sstatus.review;
            Report reportTester1 = new Report("Договорился с ютубером у которого 1000 подписчиков", new DateTime(2022,11,10),Tester1);
            taskTester1.Report = reportTester1;
            taskTester1.Status = sstatus.review;
            Report reportTester2 = new Report("Договорился на рекламу с очень популярным сайтом", new DateTime(2022,11,4),Tester2);
            taskTester2.Report = reportTester2;
            taskTester2.Status = sstatus.review;
            Report reportAnalyst = new Report("С учетом наших затрат сайт окупится", new DateTime(2022,11,3),Analyst);
            taskAnalyst.Report = reportAnalyst;
            taskAnalyst.Status = sstatus.review;
            Report reportCook = new Report("Приготовила всем еды", new DateTime(2022,11,24),Cook);
            taskCook.Report = reportCook;
            taskCook.Status = sstatus.review;
            Report reportCreator = new Report("Придумал название сортир звучит лаконично", new DateTime(2022,11,3),Creator);
            taskCreator.Report = reportCreator;
            taskCreator.Status = sstatus.review;


            project.ReportCheck();







        }
    }




























}
