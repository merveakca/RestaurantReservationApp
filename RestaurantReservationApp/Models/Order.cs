using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationApp.Models;
public class Order : BaseModel
{
    public int ReservationId { get; set; }
    [ForeignKey("ReservationId")]
    public Reservation Reservation { get; set; }

    public int MenuId { get; set; }
    [ForeignKey("MenuId")]
    public Menu Menu { get; set; }

    public DateTime? OrderDate { get; set; }
    public int Quantity { get; set; }
}
