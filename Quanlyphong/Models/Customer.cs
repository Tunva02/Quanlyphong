using System;
using System.Collections.Generic;

namespace Quanlyphong.Models;

public partial class Customer
{
    public int Idcustomer { get; set; }

    public string Fullname { get; set; } = null!;

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string? Address { get; set; }

    public string? Sex { get; set; }

    public DateOnly Date { get; set; }
}
