using System;
using System.Collections.Generic;

namespace Quanlyphong.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public string? RoomNumber { get; set; }

    public string? Type { get; set; }

    public decimal? Price { get; set; }

    public string? Status { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
