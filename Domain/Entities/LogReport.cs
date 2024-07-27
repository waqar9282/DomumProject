using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("LogReport")]
public partial class LogReport
{
    public int Id { get; set; }

    [Column("YId")]
    public int? Yid { get; set; }

    [Column("RId")]
    public int? Rid { get; set; }

    [Column("LIID")]
    [StringLength(10)]
    public string? Liid { get; set; }

    [StringLength(150)]
    public string? LogReportType { get; set; }

    [StringLength(50)]
    public string? LogType { get; set; }

    [StringLength(1000)]
    public string? LogRemarks { get; set; }

    public int? Flag { get; set; }

    public int? EditFlag { get; set; }

    public bool? Status { get; set; }

    public TimeOnly? EventTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EventDate { get; set; }

    [Column("KWid")]
    [StringLength(50)]
    public string? Kwid { get; set; }

    [Column("WSHour")]
    public int? Wshour { get; set; }

    [StringLength(50)]
    public string? Appointmentwith { get; set; }

    public TimeOnly? AppointmentTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Appointmentdate { get; set; }

    [StringLength(500)]
    public string? AppointmentAddress { get; set; }

    [StringLength(50)]
    public string? Page { get; set; }

    [StringLength(550)]
    public string? Attachment { get; set; }

    public int? Createdbyid { get; set; }

    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }
}
