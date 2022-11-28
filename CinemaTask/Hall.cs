using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTask
{
    internal class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Row;
        public int Column;
        public bool[,] Place;
        public Hall(int id, string name, int row, int column)
        {
            Id = id;
            Name = name;
            Row = row;
            Column = column;
            Place = new bool[row, column];
        }

        public void OrderTicket(int id, string name, string lastName, string startTime, string endTime, int row, int column)
        {
            if (Place[row, column] == true)
            {
                Console.WriteLine("Bu yer artıq tutulmuşdur");
            }
            else
            {
                Console.WriteLine("Bilet sifarişi uğurla tamamlandı");
                Console.WriteLine(@$"Bilet No: {id}
Name: {name}
Lastname: {lastName}
Film Start Time: {startTime}
Film End Time: {endTime}
Row: {row}
Column: {column}");
            }
        }
    }
}
