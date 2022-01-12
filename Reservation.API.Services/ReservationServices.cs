using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationServices : IReservationServices
    {
        public ReservationDTO GetResBkgNumber(int BkgNumber)
        {
            return new ReservationDTO
            {
                CheckInDate = DateTime.Now.AddDays(2),
                CheckOutDate = DateTime.Now.AddDays(4),
                Amount = (new Random()).Next(10000, 100000),
                BkgDate = DateTime.Now.AddDays(-2),
                ID = (new Random()).Next(1, 100),
                BkgNumber = BkgNumber


            };
        }
    }
}
