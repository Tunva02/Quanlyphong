using System;
using System.Collections.Generic;

namespace Quanlyphong.Models;

public partial class AdminInfo
{
    public int Idadmin { get; set; }

    public string Fullname { get; set; } = null!;

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string? Address { get; set; }
}
