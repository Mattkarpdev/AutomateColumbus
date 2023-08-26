using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACapp.Models;

public partial class Quote_Input
{
    [Key]
    public int quote_input_id { get; set; }

    public int? input_id {get; set; }

    public string? email { get; set; }

    public string? phone_number { get; set; }

    public string? name { get; set; }
}
