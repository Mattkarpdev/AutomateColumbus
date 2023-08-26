using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACapp.Models;

public partial class Device
{
    [Key]
    public int device_id { get; set; }

    public string device_name { get; set; } = null!;

    public decimal device_price { get; set; }

    public decimal installation_cost { get; set; }
}
