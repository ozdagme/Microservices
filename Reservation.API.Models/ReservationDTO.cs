﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int ID { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public DateTime? BkgDate { get; set; }
        public double Amount { get; set; }
    }
}
