using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("session_detail")]
public partial class SessionDetail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("session")]
    [StringLength(300)]
    public string? Session { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("createdby")]
    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column("Inst_code")]
    [StringLength(10)]
    public string? InstCode { get; set; }

    [Column("dateAdded", TypeName = "datetime")]
    public DateTime? DateAdded { get; set; }

    [Column("prog_name")]
    [StringLength(150)]
    public string? ProgName { get; set; }

    public int? AllocatedSeats { get; set; }

    [Column("P_Type")]
    [StringLength(50)]
    public string? PType { get; set; }

    public int? InterPercent { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Qualifications { get; set; }

    public bool? PreEng { get; set; }

    public bool? GenderSpecification { get; set; }

    public int FemaleSeats { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DurStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DurEnd { get; set; }
}
