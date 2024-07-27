using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Incidentmng")]
public partial class Incidentmng
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("logyid")]
    public int? Logyid { get; set; }

    [Column("YLRecordID")]
    [StringLength(10)]
    public string? YlrecordId { get; set; }

    [Column("RA")]
    [StringLength(250)]
    public string? Ra { get; set; }

    [Column("SOD")]
    [StringLength(250)]
    public string? Sod { get; set; }

    [Column("PPIO")]
    [StringLength(350)]
    public string? Ppio { get; set; }

    [Column("RTOCOM")]
    public bool? Rtocom { get; set; }

    [Column("RTOCOMdate", TypeName = "datetime")]
    public DateTime? Rtocomdate { get; set; }

    [Column("RTOCOMtime")]
    public TimeOnly? Rtocomtime { get; set; }

    [Column("RTOCOMname")]
    [StringLength(150)]
    public string? Rtocomname { get; set; }

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
    [StringLength(250)]
    public string? Rtpname { get; set; }

    [Column("RTLAEDT")]
    public bool? Rtlaedt { get; set; }

    [Column("RTLAEDTdate", TypeName = "datetime")]
    public DateTime? Rtlaedtdate { get; set; }

    [Column("RTLAEDTtime")]
    public TimeOnly? Rtlaedttime { get; set; }

    [Column("RTLAEDTname")]
    [StringLength(250)]
    public string? Rtlaedtname { get; set; }

    [Column("RTO")]
    public bool? Rto { get; set; }

    [Column("RTOdate", TypeName = "datetime")]
    public DateTime? Rtodate { get; set; }

    [Column("RTOtime")]
    public TimeOnly? Rtotime { get; set; }

    [Column("RTOname")]
    [StringLength(250)]
    public string? Rtoname { get; set; }

    [Column("PROFE")]
    [StringLength(550)]
    public string? Profe { get; set; }

    [Column("ofti")]
    [StringLength(550)]
    public string? Ofti { get; set; }

    [StringLength(550)]
    public string? PotentialRisk { get; set; }

    [Column("DCSLL")]
    [StringLength(550)]
    public string? Dcsll { get; set; }

    [Column("OMALL")]
    [StringLength(550)]
    public string? Omall { get; set; }

    [StringLength(150)]
    public string? Upload { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
