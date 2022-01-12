using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {

        private readonly IReservationServices ReservationServices;
        public ReservationController(IReservationServices reservationServices)
        {
            ReservationServices = reservationServices;
        }


        [HttpGet("{Id}")]
        public Reservation.API.Models.ReservationDTO Get(int Id)
        {
            return ReservationServices.GetResBkgNumber(Id);
        }
    }
}
