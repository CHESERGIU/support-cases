﻿using System;

namespace CarService
{
    public static class Program
    {
        public static void Main()
        {
            var a = new Ticket(carNumber: "CJ01ABC", problem: "Direction check", priority: WaitingTimes.Urgent);
            var b = new Ticket(carNumber: "CJ02DEF", problem: "Lights not working", priority: WaitingTimes.DeadLine);
            var c = new Ticket(carNumber: "CJ02GHI", problem: "Change oil", priority: WaitingTimes.Scheduled);

            Ticket[] tickets = { a, b, c };
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.CarNumber + " - " + ticket.Problem + " - " + ticket.Priority);
            }

            Console.Read();
        }
    }
}
