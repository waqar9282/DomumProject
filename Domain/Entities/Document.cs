using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
public partial class Document
{
    public int Id { get; set; }

    [StringLength(250)]
    public string? Name { get; set; }

    [StringLength(550)]
    public string? Description { get; set; }

    [Column("docpath")]
    [StringLength(350)]
    public string? Docpath { get; set; }

    [StringLength(250)]
    public string? DocGroup { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column("isactive")]
    public bool Isactive { get; set; }
}
