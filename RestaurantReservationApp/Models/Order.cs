using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservationApp.Models;
public class Order : BaseModel
{
    [ForeignKey("ReservationId")]
    public int ReservationId { get; set; }
    public Reservation Reservation { get; set; }

    [ForeignKey("MenuId")]
    public int MenuId { get; set; }
    public Menu Menu { get; set; }

    public DateTime OrderDate { get; set; }
    public int Quantity { get; set; }
}
