using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("Accidentmng")]
public partial class Accidentmng
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("logyid")]
    public int? Logyid { get; set; }

    [Column("YLRecordID")]
    [StringLength(10)]
    public string YlrecordId { get; set; } = null!;

    [Column("RA")]
    [StringLength(150)]
    public string? Ra { get; set; }

    [Column("PPWAccidentoccurred")]
    [StringLength(550)]
    public string? Ppwaccidentoccurred { get; set; }

    [StringLength(550)]
    public string? Personresponsible { get; set; }

    [Column("LASocialWorker")]
    [StringLength(150)]
    public string? LasocialWorker { get; set; }

    [StringLength(150)]
    public string? Personcompletingreport { get; set; }

    [StringLength(550)]
    public string? AccidentDescription { get; set; }

    [Column("detailofinjury")]
    [StringLength(550)]
    public string? Detailofinjury { get; set; }

    [Column("medicaltreatment")]
    [StringLength(550)]
    public string? Medicaltreatment { get; set; }

    [Column("YPSHospitalgp")]
    [StringLength(550)]
    public string? Ypshospitalgp { get; set; }

    [Column("fupsupport")]
    [StringLength(550)]
    public string? Fupsupport { get; set; }

    [StringLength(550)]
    public string? LessonsLearned { get; set; }

    public bool? Plantobereviewed { get; set; }

    public bool? ReportOncallmanager { get; set; }

    [Column("RoCMdate", TypeName = "datetime")]
    public DateTime? RoCmdate { get; set; }

    [Column("RoCMTime")]
    public TimeOnly? RoCmtime { get; set; }

    [Column("RoCMName")]
    [StringLength(150)]
    public string? RoCmname { get; set; }

    [Column("cad")]
    [StringLength(150)]
    public string? Cad { get; set; }

    [Column("RTP")]
    public bool? Rtp { get; set; }

    [Column("RTPdate", TypeName = "datetime")]
    public DateTime? Rtpdate { get; set; }

    [Column("RTPtime")]
    public TimeOnly? Rtptime { get; set; }

    [Column("RTPname")]
    [StringLength(150)]
    public string? Rtpname { get; set; }

    [Column("RTLAEDT")]
    public bool? Rtlaedt { get; set; }

    [Column("RTLAEDTdate", TypeName = "datetime")]
    public DateTime? Rtlaedtdate { get; set; }

    [Column("RTLAEDTtime")]
    public TimeOnly? Rtlaedttime { get; set; }

    [Column("RTLAEDTname")]
    [StringLength(150)]
    public string? Rtlaedtname { get; set; }

    [Column("REmailSW")]
    public bool? RemailSw { get; set; }

    [Column("REmailSWdate", TypeName = "datetime")]
    public DateTime? RemailSwdate { get; set; }

    [Column("REmailSWtime")]
    public TimeOnly? RemailSwtime { get; set; }

    [Column("REmailSWname")]
    [StringLength(150)]
    public string? RemailSwname { get; set; }

    [Column("RTO")]
    public bool? Rto { get; set; }

    [Column("RTOdate", TypeName = "datetime")]
    public DateTime? Rtodate { get; set; }

    [Column("RTOtime")]
    public TimeOnly? Rtotime { get; set; }

    [Column("RTOname")]
    [StringLength(150)]
    public string? Rtoname { get; set; }

    [StringLength(150)]
    public string? Upload { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
