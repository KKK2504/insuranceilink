using System;
using System.Collections.Generic;

namespace PaymentAPI.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public int CompanyId { get; set; }

    public string PolicyDetails { get; set; } = null!;
}
