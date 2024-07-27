using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("institution")]
public partial class Institution
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("inst_name")]
    [StringLength(250)]
    public string? InstName { get; set; }

    [Column("inst_address")]
    [StringLength(100)]
    public string? InstAddress { get; set; }

    [Column("inst_type")]
    [StringLength(50)]
    public string? InstType { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("prog_name")]
    [StringLength(80)]
    public string? ProgName { get; set; }

    [Column("prog_type")]
    [StringLength(50)]
    public string? ProgType { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("createdby")]
    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column("inst_code")]
    [StringLength(10)]
    public string? InstCode { get; set; }

    [StringLength(50)]
    public string? AssignedTo { get; set; }
}
