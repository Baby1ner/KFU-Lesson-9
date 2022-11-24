using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_9
{
    internal class Rabotyaga
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Rabotyaga(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }


        public void Print()
        {
            Console.WriteLine($"{Name} специализируется на {Specialization}");
        }



    }
}
