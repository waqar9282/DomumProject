using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("abbMissingmng")]
public partial class AbbMissingmng
{
    public int Id { get; set; }

    [Column("logyid")]
    public int? Logyid { get; set; }

    [Column("YLRecordID")]
    [StringLength(10)]
    public string YlrecordId { get; set; } = null!;

    [Column("AKRisk")]
    [StringLength(250)]
    public string? Akrisk { get; set; }

    [Column("AKLocation")]
    [StringLength(250)]
    public string? Aklocation { get; set; }

    [StringLength(550)]
    public string? Description { get; set; }

    [StringLength(550)]
    public string? PlacingAth { get; set; }

    [Column("YPSW")]
    [StringLength(550)]
    public string? Ypsw { get; set; }

    [Column("SADN")]
    [StringLength(250)]
    public string? Sadn { get; set; }

    [Column("RTDC")]
    public bool? Rtdc { get; set; }

    [Column("DCRMD", TypeName = "datetime")]
    public DateTime? Dcrmd { get; set; }

    [Column("DCRMT")]
    public TimeOnly? Dcrmt { get; set; }

    [Column("DCRMDname")]
    [StringLength(150)]
    public string? Dcrmdname { get; set; }

    [Column("cad")]
    [StringLength(150)]
    public string? Cad { get; set; }

    [Column("RTP")]
    public bool? Rtp { get; set; }

    [Column("RTPDate", TypeName = "datetime")]
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

    [Column("circumstances")]
    [StringLength(550)]
    public string? Circumstances { get; set; }

    [StringLength(550)]
    public string? Actiontaken { get; set; }

    [Column("RD", TypeName = "datetime")]
    public DateTime? Rd { get; set; }

    [Column("RT")]
    public TimeOnly? Rt { get; set; }

    [Column("PRYP")]
    [StringLength(150)]
    public string? Pryp { get; set; }

    [StringLength(550)]
    public string? CircumstancesofReturn { get; set; }

    [Column("RRTDC")]
    public bool? Rrtdc { get; set; }

    [Column("DCRD", TypeName = "datetime")]
    public DateTime? Dcrd { get; set; }

    [Column("DCRT")]
    public TimeOnly? Dcrt { get; set; }

    [Column("DCRTname")]
    [StringLength(150)]
    public string? Dcrtname { get; set; }

    [Column("rcad")]
    [StringLength(150)]
    public string? Rcad { get; set; }

    [Column("RRTP")]
    public bool? Rrtp { get; set; }

    [Column("RRTPdate", TypeName = "datetime")]
    public DateTime? Rrtpdate { get; set; }

    [Column("RRTPtime")]
    public TimeOnly? Rrtptime { get; set; }

    [Column("RRTPname")]
    [StringLength(150)]
    public string? Rrtpname { get; set; }

    [Column("RRTLAEDT")]
    public bool? Rrtlaedt { get; set; }

    [Column("RRTLAEDTDate", TypeName = "datetime")]
    public DateTime? Rrtlaedtdate { get; set; }

    [Column("RRTLAEDTtime")]
    public TimeOnly? Rrtlaedttime { get; set; }

    [Column("RRTLAEDTname")]
    [StringLength(150)]
    public string? Rrtlaedtname { get; set; }

    [StringLength(550)]
    public string? Preventivemeasures { get; set; }

    [Column("LL")]
    [StringLength(550)]
    public string? Ll { get; set; }

    [StringLength(150)]
    public string? Upload { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
