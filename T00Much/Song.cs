using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Song
    {
        string name;
        string autor;
        public Song prev;



        public Song(string name, string autor)
        {
            this.name = name;
            this.autor = autor;
            prev = null;
        }

        public Song(string name, string autor, Song prev)
        {
            this.name = name;
            this.autor = autor;
            this.prev = prev;
        }

        public Song() { }



        public void Name()
        {
            Console.WriteLine("Введите название песни: ");
            name = Console.ReadLine();
            Console.WriteLine("Песня добавлена");
        }
        public void Autor()
        {
            Console.WriteLine("Введите автора: ");
            autor = Console.ReadLine();
            Console.WriteLine("Автор добавлен");
        }



        public override bool Equals(object d)
        {
            Song e = d as Song;
            if (e != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void Title()
        {
            Console.WriteLine($"Название песни: {name}\nАвтор песни: {autor}");
        }

    }
}
