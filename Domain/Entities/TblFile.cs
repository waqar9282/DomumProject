using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("tblFiles")]
public partial class TblFile
{
    public int Id { get; set; }

    public long? Stid { get; set; }

    [StringLength(500)]
    public string? Name { get; set; }

    [Column("filename")]
    [StringLength(500)]
    public string? Filename { get; set; }
}
