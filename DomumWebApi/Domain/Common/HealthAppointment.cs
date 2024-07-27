using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Health_Appointments")]
public partial class HealthAppointment
{
    public int Id { get; set; }

    [StringLength(150)]
    public string? Type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    public bool? Status { get; set; }
}
