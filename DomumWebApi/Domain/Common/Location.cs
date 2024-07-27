using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Location")]
public partial class Location
{
    [Column("FId")]
    public int Fid { get; set; }

    [StringLength(250)]
    public string? Facility { get; set; }

    [Column("F_No_Rooms")]
    public int? FNoRooms { get; set; }

    [Column("F_Address")]
    [StringLength(500)]
    public string? FAddress { get; set; }

    [Column("F_Contact")]
    [StringLength(150)]
    public string? FContact { get; set; }

    [Column("F_email")]
    [StringLength(250)]
    public string? FEmail { get; set; }

    [Column("Mobile_No")]
    [StringLength(100)]
    public string? MobileNo { get; set; }

    [Column("Landline_No")]
    [StringLength(100)]
    public string? LandlineNo { get; set; }

    [StringLength(250)]
    public string? Mailingaddress { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(150)]
    public string? Pic { get; set; }

    [StringLength(150)]
    public string? Createdby { get; set; }

    [Column("f_CreateDate", TypeName = "datetime")]
    public DateTime? FCreateDate { get; set; }
}
