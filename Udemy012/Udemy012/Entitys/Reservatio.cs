using System;
using Udemy012.Entitys.Exceptions;

namespace Udemy012.Entitys
{
    public class Reservatio
    {
        private int _Room;
        private DateTime _CheckIn;
        private DateTime _CheckOut;

        public int Room => _Room;

        public DateTime CheckIn => _CheckIn;

        public DateTime CheckOut => _CheckOut;

        public Reservatio(int room)
        {
            _Room = room;
        }

        public Reservatio(int room, DateTime checkIn, DateTime checkOut)
        {
            _CheckIn = checkIn;
            _CheckOut = checkOut;
            _Room = room;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn<DateTime.Now || checkOut<DateTime.Now)
            {
                throw new DomainException("Erro na reserva, as datas de check in e check out dever ser datas futuras.");
            }
            else if (checkIn>checkOut)
            {
                throw new DomainException("Erro na reserva, a data de check out deve ser posterior a data de check in.");
            }
            else
            {
                _CheckIn = checkIn;
                _CheckOut = checkOut;
            }
        }

        public override string ToString()
        {
            return $"Room: {Room.ToString()}, " +
                   $"check-in: {CheckIn.ToString("dd/MM/yyyy")}, " +
                   $"check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                   $"{Duration().ToString()} nights";
        }
    }
}