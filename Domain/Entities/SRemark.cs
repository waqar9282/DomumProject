using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("S_Remarks")]
public partial class SRemark
{
    [Column("id")]
    public int Id { get; set; }

    public string? Sremk { get; set; }

    public int? Stid { get; set; }
}
