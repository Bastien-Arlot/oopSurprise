using System;

namespace Poo
{
    public class Items
    {
        public static Items FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');
            Items item = new Items(
                Convert.ToInt32(values[0]),
                Convert.ToString(values[1]));
            return item;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Items(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Prettify()
        {
            return $"{Name}";
        }

      
    }
}