using System;
using System.Collections.Generic;

namespace Quanlyphong.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? Role { get; set; }

    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
