using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
public partial class Room
{
    [Column("RId")]
    public int Rid { get; set; }

    [Column("FId")]
    public int? Fid { get; set; }

    [StringLength(150)]
    public string? RoomNo { get; set; }

    [StringLength(50)]
    public string? RoomContact { get; set; }

    [StringLength(500)]
    public string? RoomDescription { get; set; }

    [StringLength(150)]
    public string? Roomemail { get; set; }

    [Column("pic")]
    [StringLength(150)]
    public string? Pic { get; set; }

    public bool? IsActive { get; set; }

    public bool? Occupied { get; set; }

    [StringLength(150)]
    public string? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createdate { get; set; }
}
