using System;
using Exercicio19.Entities.Exceptions;

namespace Exercicio19.Entities
{
    class Reservation
    {
        public int Room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int room, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after Check-in date");
            }
            Room = room;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after Check-in date");

            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + Room + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights.";
        }
    }
}
