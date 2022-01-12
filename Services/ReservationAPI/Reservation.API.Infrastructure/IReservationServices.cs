using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Infrastructure
{
    public interface IReservationServices
    {
        public ReservationDTO GetResBkgNumber(int BkgNumber);
    }
}
