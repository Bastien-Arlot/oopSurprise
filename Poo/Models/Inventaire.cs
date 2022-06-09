using System;

namespace Poo
{
    public class Inventaire
    {
        public static Inventaire FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');
            Inventaire line = new Inventaire(
                Convert.ToInt32(values[0]),
                Convert.ToString(values[1]));
            return line;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Inventaire(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Prettify()
        {
            return $"{Id}, {Name}";
        }
    }
}