using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("std_reg")]
public partial class StdReg
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("registration_id_conf")]
    [StringLength(100)]
    public string? RegistrationIdConf { get; set; }

    [Column("std_name")]
    [StringLength(70)]
    public string? StdName { get; set; }

    [Column("std_father_name")]
    [StringLength(70)]
    public string? StdFatherName { get; set; }

    [Column("std_cnic")]
    [StringLength(50)]
    public string? StdCnic { get; set; }

    [Column("std_father_cnic")]
    [StringLength(50)]
    public string? StdFatherCnic { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [StringLength(50)]
    public string? Gender { get; set; }

    [Column("institution_id")]
    public int? InstitutionId { get; set; }

    [Column("curr_inst_name")]
    [StringLength(50)]
    public string? CurrInstName { get; set; }

    [Column("migration_id")]
    [StringLength(50)]
    public string? MigrationId { get; set; }

    [Column("status")]
    [StringLength(100)]
    public string? Status { get; set; }

    [Column("picture")]
    [StringLength(500)]
    public string? Picture { get; set; }

    [Column("remarks")]
    [StringLength(2000)]
    public string? Remarks { get; set; }

    [Column("record_created_date", TypeName = "datetime")]
    public DateTime? RecordCreatedDate { get; set; }

    [Column("createdby")]
    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfEntryToFacility { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfLeavingFacility { get; set; }

    [Column("ssc_roll_no")]
    [StringLength(50)]
    public string? SscRollNo { get; set; }

    [Column("ssc_passing_year")]
    public int? SscPassingYear { get; set; }

    [Column("ssc_reg_no")]
    [StringLength(50)]
    public string? SscRegNo { get; set; }

    [Column("ssc_tot")]
    public int? SscTot { get; set; }

    [Column("ssc_marks")]
    public int? SscMarks { get; set; }

    [Column("ssc_board_university")]
    [StringLength(250)]
    public string? SscBoardUniversity { get; set; }

    [Column("ssc_cert")]
    [StringLength(500)]
    public string? SscCert { get; set; }

    [Column("inter_roll_no")]
    [StringLength(50)]
    public string? InterRollNo { get; set; }

    [Column("inter_passing_year")]
    public int? InterPassingYear { get; set; }

    [Column("inter_reg_no")]
    [StringLength(50)]
    public string? InterRegNo { get; set; }

    [Column("inter_tot")]
    public int? InterTot { get; set; }

    [Column("inter_marks")]
    public int? InterMarks { get; set; }

    [Column("inter_cert")]
    [StringLength(500)]
    public string? InterCert { get; set; }

    [Column("inter_board_university")]
    [StringLength(250)]
    public string? InterBoardUniversity { get; set; }

    [Column("undergrad_entry_test")]
    [StringLength(50)]
    public string? UndergradEntryTest { get; set; }

    [Column("grad_roll_no")]
    [StringLength(50)]
    public string? GradRollNo { get; set; }

    [Column("grad_passing_year")]
    public int? GradPassingYear { get; set; }

    [Column("grad_reg_no")]
    [StringLength(50)]
    public string? GradRegNo { get; set; }

    [Column("grad_tot")]
    [StringLength(50)]
    public string? GradTot { get; set; }

    [Column("grad_marks")]
    [StringLength(50)]
    public string? GradMarks { get; set; }

    [Column("grad_board_university")]
    [StringLength(250)]
    public string? GradBoardUniversity { get; set; }

    [Column("last_attended_board_uni")]
    [StringLength(250)]
    public string? LastAttendedBoardUni { get; set; }

    [Column("noc")]
    [StringLength(500)]
    public string? Noc { get; set; }

    [Column("category_of_seat")]
    [StringLength(50)]
    public string? CategoryOfSeat { get; set; }

    [Column("domicile")]
    [StringLength(50)]
    public string? Domicile { get; set; }

    [Column("permanent_add")]
    [StringLength(250)]
    public string? PermanentAdd { get; set; }

    [Column("tele_contact")]
    [StringLength(50)]
    public string? TeleContact { get; set; }

    [Column("postgrad_entry_test")]
    [StringLength(50)]
    public string? PostgradEntryTest { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }

    [Column("S_id")]
    public int? SId { get; set; }

    [Column("classRoll")]
    [StringLength(50)]
    public string? ClassRoll { get; set; }

    [Column("typ")]
    [StringLength(50)]
    public string? Typ { get; set; }

    [Column("UgETtot")]
    public int? UgEttot { get; set; }

    [Column("UgETobt")]
    public int? UgEtobt { get; set; }

    [Column("UgETpic")]
    [StringLength(500)]
    public string? UgEtpic { get; set; }

    [Column("grad_cert")]
    [StringLength(500)]
    public string? GradCert { get; set; }

    [Column("PgETtot")]
    public int? PgEttot { get; set; }

    [Column("PgETobt")]
    public int? PgEtobt { get; set; }

    [Column("PgETpic")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PgEtpic { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegAllocDate { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? ObjRej { get; set; }

    public bool? RegIssued { get; set; }

    public bool? Provisional { get; set; }

    [Column("intergroup")]
    [StringLength(50)]
    public string? Intergroup { get; set; }

    [Column("matricgroup")]
    [StringLength(50)]
    public string? Matricgroup { get; set; }

    [Column("SAT_physics")]
    [StringLength(50)]
    public string? SatPhysics { get; set; }

    [Column("SAT_Biology")]
    [StringLength(50)]
    public string? SatBiology { get; set; }

    [Column("SAT_Chemistry")]
    [StringLength(50)]
    public string? SatChemistry { get; set; }

    [Column("SAT_Flag")]
    [StringLength(50)]
    public string? SatFlag { get; set; }

    [Column("gradgroup")]
    [StringLength(50)]
    public string? Gradgroup { get; set; }

    [Column("UGET_Type")]
    [StringLength(50)]
    public string? UgetType { get; set; }

    [Column("UGET_PassYr")]
    public int? UgetPassYr { get; set; }

    [Column("UGET_TestBody")]
    [StringLength(300)]
    public string? UgetTestBody { get; set; }

    [Column("PGET_Type")]
    [StringLength(50)]
    public string? PgetType { get; set; }

    [Column("PGET_PassYr")]
    public int? PgetPassYr { get; set; }

    [Column("PGET_TestBody")]
    [StringLength(300)]
    public string? PgetTestBody { get; set; }

    [Column("Post_rn")]
    [StringLength(50)]
    public string? PostRn { get; set; }

    [Column("PRN_roll_no")]
    [StringLength(50)]
    public string? PrnRollNo { get; set; }

    [Column("PRN_passing_year")]
    [StringLength(50)]
    public string? PrnPassingYear { get; set; }

    [Column("PRN_reg_no")]
    [StringLength(50)]
    public string? PrnRegNo { get; set; }

    [Column("PRN_tot")]
    [StringLength(50)]
    public string? PrnTot { get; set; }

    [Column("PRN_marks")]
    [StringLength(50)]
    public string? PrnMarks { get; set; }

    [Column("PRN_board_university")]
    [StringLength(50)]
    public string? PrnBoardUniversity { get; set; }

    [StringLength(50)]
    public string? Condence { get; set; }

    [Column("Condence_roll_no")]
    [StringLength(50)]
    public string? CondenceRollNo { get; set; }

    [Column("Condence_passing_year")]
    [StringLength(50)]
    public string? CondencePassingYear { get; set; }

    [Column("Condence_reg_no")]
    [StringLength(50)]
    public string? CondenceRegNo { get; set; }

    [Column("Condence_tot")]
    [StringLength(50)]
    public string? CondenceTot { get; set; }

    [Column("Condence_marks")]
    [StringLength(50)]
    public string? CondenceMarks { get; set; }

    [Column("Condence_board_university")]
    [StringLength(50)]
    public string? CondenceBoardUniversity { get; set; }

    [StringLength(50)]
    public string? Postgrad { get; set; }

    [Column("Postgrad_roll_no")]
    [StringLength(50)]
    public string? PostgradRollNo { get; set; }

    [Column("Postgrad_passing_year")]
    [StringLength(50)]
    public string? PostgradPassingYear { get; set; }

    [Column("Postgrad_reg_no")]
    [StringLength(50)]
    public string? PostgradRegNo { get; set; }

    [Column("Postgrad_tot")]
    [StringLength(50)]
    public string? PostgradTot { get; set; }

    [Column("Postgrad_marks")]
    [StringLength(50)]
    public string? PostgradMarks { get; set; }

    [Column("Postgrad_board_university")]
    [StringLength(50)]
    public string? PostgradBoardUniversity { get; set; }

    [Column("Phdent_rlno")]
    [StringLength(50)]
    public string? PhdentRlno { get; set; }

    [Column("Phd_tot")]
    [StringLength(50)]
    public string? PhdTot { get; set; }

    [Column("Phd_obt")]
    [StringLength(50)]
    public string? PhdObt { get; set; }

    [Column("phdtest_type")]
    [StringLength(50)]
    public string? PhdtestType { get; set; }

    [Column("phdtest_year")]
    [StringLength(50)]
    public string? PhdtestYear { get; set; }

    [Column("phdtest_body")]
    [StringLength(50)]
    public string? PhdtestBody { get; set; }

    [Column("Postgrad_mphil_pic")]
    [StringLength(50)]
    public string? PostgradMphilPic { get; set; }

    [Column("Phdtest_pic")]
    [StringLength(50)]
    public string? PhdtestPic { get; set; }

    [StringLength(500)]
    public string? Verifications { get; set; }

    [StringLength(500)]
    public string? Email { get; set; }

    [StringLength(250)]
    public string? EyeColour { get; set; }

    [StringLength(250)]
    public string? Height { get; set; }

    [StringLength(500)]
    public string? NameandboroughofSocialServicesdepartment { get; set; }

    [StringLength(500)]
    public string? SocialWorkersname { get; set; }

    [StringLength(500)]
    public string? SocialWorkerContactdetails { get; set; }

    [StringLength(150)]
    public string? Parentnames { get; set; }

    [StringLength(150)]
    public string? Parentnamesnumbers { get; set; }

    [StringLength(150)]
    public string? Otherfamilycontactdetails { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecordCreatedate { get; set; }
}
