using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACapp.Models;

public partial class User_Input
{
    [Key]
  
    public int input_id { get; set; }

    public DateTime? date { get; set; }

    public int? num_windows { get; set; }

    public int? num_doors { get; set; }

    public int? video_doorbell { get; set; }

    public int? cost_install { get; set; }

    public int? cost_equipment { get; set; }
}
