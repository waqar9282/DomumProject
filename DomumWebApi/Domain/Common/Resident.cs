using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DomumWebApi.Domain.Common;

[Keyless]
[Table("Resident")]
public partial class Resident
{
    public int Id { get; set; }

    public int? Facilityid { get; set; }

    [StringLength(250)]
    public string? Facility { get; set; }

    public int? SocialWorkerId { get; set; }

    [StringLength(250)]
    public string? SocialWorkerName { get; set; }

    public int? RoomId { get; set; }

    [StringLength(50)]
    public string? RoomNo { get; set; }

    [StringLength(150)]
    public string? Pic { get; set; }

    [Column("EDTContact")]
    [StringLength(150)]
    public string? Edtcontact { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfEntryToFacility { get; set; }

    [StringLength(150)]
    public string? ResidentName { get; set; }

    [StringLength(150)]
    public string? MiddleName { get; set; }

    [StringLength(150)]
    public string? LastName { get; set; }

    [StringLength(150)]
    public string? Religion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(50)]
    public string? Gender { get; set; }

    [StringLength(50)]
    public string? Ethnicity { get; set; }

    [StringLength(50)]
    public string? HairColour { get; set; }

    [StringLength(50)]
    public string? EyeColour { get; set; }

    [StringLength(50)]
    public string? Heigth { get; set; }

    [StringLength(100)]
    public string? Education { get; set; }

    [StringLength(100)]
    public string? ParentName { get; set; }

    [StringLength(500)]
    public string? HealthIssues { get; set; }

    [StringLength(500)]
    public string? Specialdietaryrequirements { get; set; }

    [StringLength(200)]
    public string? Allergies { get; set; }

    [StringLength(100)]
    public string? Doctor { get; set; }

    [StringLength(100)]
    public string? DoctorContact { get; set; }

    [StringLength(500)]
    public string? DoctorAddress { get; set; }

    [StringLength(100)]
    public string? Optician { get; set; }

    [StringLength(100)]
    public string? OpticianContact { get; set; }

    [StringLength(500)]
    public string? OpticianAddress { get; set; }

    [StringLength(100)]
    public string? Dentist { get; set; }

    [StringLength(100)]
    public string? DentistContact { get; set; }

    [StringLength(500)]
    public string? DentistAddress { get; set; }

    [StringLength(100)]
    public string? Hospital { get; set; }

    [StringLength(100)]
    public string? HospitalContact { get; set; }

    [StringLength(500)]
    public string? HospitalAddress { get; set; }

    [Column("Hospital_Ref_No")]
    [StringLength(500)]
    public string? HospitalRefNo { get; set; }

    [Column("CAMH")]
    [StringLength(100)]
    public string? Camh { get; set; }

    [Column("CAMHContact")]
    [StringLength(100)]
    public string? Camhcontact { get; set; }

    [Column("CAMHAddress")]
    [StringLength(500)]
    public string? Camhaddress { get; set; }

    [StringLength(500)]
    public string? Anyotherinfo { get; set; }

    [Column("NHSNO")]
    [StringLength(500)]
    public string? Nhsno { get; set; }

    [StringLength(500)]
    public string? Solicitor { get; set; }

    [StringLength(500)]
    public string? SolicitorFirm { get; set; }

    [StringLength(500)]
    public string? SolicitorRef { get; set; }

    [StringLength(500)]
    public string? SolicitorEmail { get; set; }

    [StringLength(500)]
    public string? SolicitorPhone { get; set; }

    [StringLength(500)]
    public string? SolicitorAddress { get; set; }

    [StringLength(500)]
    public string? Collegename { get; set; }

    [StringLength(500)]
    public string? Collegeid { get; set; }

    [StringLength(500)]
    public string? CollegecontactName { get; set; }

    [StringLength(500)]
    public string? CollegePhone { get; set; }

    [StringLength(500)]
    public string? CollegeEmail { get; set; }

    [StringLength(500)]
    public string? CollegeMobilenumber { get; set; }

    [Column("IROName")]
    [StringLength(500)]
    public string? Ironame { get; set; }

    [Column("IROcontactno")]
    [StringLength(500)]
    public string? Irocontactno { get; set; }

    [Column("IROEmail")]
    [StringLength(500)]
    public string? Iroemail { get; set; }

    [StringLength(500)]
    public string? Nationality { get; set; }

    [StringLength(100)]
    public string? PhoneNumber { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(500)]
    public string? PermanentAddress { get; set; }

    public bool? IsActive { get; set; }

    public bool? EditFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createdatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeactivationDate { get; set; }
}
