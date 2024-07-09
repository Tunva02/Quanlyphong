using System;
using System.Collections.Generic;

namespace Quanlyphong.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? AccountId { get; set; }

    public int? RoomId { get; set; }

    public DateOnly? CheckInDate { get; set; }

    public DateOnly? CheckOutDate { get; set; }

    public decimal? TotalCost { get; set; }

    public string? PaymentStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Room? Room { get; set; }
}
