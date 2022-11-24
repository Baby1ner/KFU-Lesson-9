using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_9
{
    internal class Report
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Rabotyaga Rabotnik { set; get; }

        public Report(string text, DateTime date, Rabotyaga rabotnik)
        {
            Text = text;
            Date = date;
            Rabotnik = rabotnik;
        }

    }
}
