using System;
using System.Collections.Generic;

namespace DZ;

public partial class Guest
{
    public int Id { get; set; }

    public string? FulName { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Status { get; set; }

    public byte[]? Photo { get; set; }

    public string? DateOfEnter { get; set; }

    public string? DateOfDeparture { get; set; }

    public string? NumberOfRoom { get; set; }
}
