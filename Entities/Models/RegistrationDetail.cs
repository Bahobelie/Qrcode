using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RegistrationDetail", Schema = "PMS")]
[Index("rateCodeDetail", "roomType", "room", "voucher", "market", "Date", "adult", "child", "roomCount", "rateAmount", "actualRTC", Name = "_dta_index_RegistrationDetail_5_1948026171__K10_K8_K9_K3_K15_K4_K5_K6_K7_K11_K12")]
public partial class RegistrationDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public int? adult { get; set; }

    public int? child { get; set; }

    public int? roomCount { get; set; }

    [StringLength(26)]
    public string? roomType { get; set; }

    [StringLength(26)]
    public string? room { get; set; }

    [StringLength(26)]
    public string? rateCodeDetail { get; set; }

    [Column(TypeName = "money")]
    public decimal? rateAmount { get; set; }

    [StringLength(26)]
    public string? actualRTC { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? adjustment { get; set; }

    public bool? isFixedRate { get; set; }

    [StringLength(26)]
    public string? market { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    public bool? isClosed { get; set; }

    public int? year { get; set; }

    public int? month { get; set; }

    public int? day { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("registrationDetailNavigation")]
    public virtual ICollection<PackagesToPost> PackagesToPosts { get; } = new List<PackagesToPost>();

    [ForeignKey("rateCodeDetail")]
    [InverseProperty("RegistrationDetails")]
    public virtual RateCodeDetail? rateCodeDetailNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("RegistrationDetails")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
