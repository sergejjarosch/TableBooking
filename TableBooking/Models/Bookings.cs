﻿namespace TableBooking.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int PeopleCount { get; set; }

        public string Phone { get; set; }
    }
}
