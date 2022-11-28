﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTask
{
    internal class Program
    {
        static void Main()
        {
            Cinema May28 = new Cinema(1, "28 May");
            Cinema Genclik = new Cinema(2, "Genclik");
            Cinema Elmler = new Cinema(3, "Elmler");

            Hall hall1 = new Hall(1, "Hall 1", 10, 15, May28);
            Hall hall2 = new Hall(1, "Hall 2", 12, 16, May28);

            hall1.Place[3, 4] = 1; // dolu
            hall1.Place[3, 5] = 1; // dolu

            hall1.OrderTicket(14314, "Murad", "Agazade", "18:00", "20:00", 6,4);

        }
    }
}
