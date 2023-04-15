using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RegistrationExtension", Schema = "PMS")]
[Index("voucher", "paymentType", "code", Name = "_dta_index_RegistrationExtension_5_853122330__K3_K8_K2_4_5_6_11")]
public partial class RegistrationExtension
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? arrivalDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? departureDate { get; set; }

    [StringLength(26)]
    public string? OrganizationUnitDefinition { get; set; }

    [StringLength(26)]
    public string? resType { get; set; }

    [StringLength(26)]
    public string? Specials { get; set; }

    [StringLength(26)]
    public string? paymentType { get; set; }

    [StringLength(26)]
    public string? origin { get; set; }

    [Column(TypeName = "money")]
    public decimal? exchangeRate { get; set; }

    public bool? ismaster { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("registrationHeaderNavigation")]
    public virtual ICollection<Block> Blocks { get; } = new List<Block>();

    [InverseProperty("registrationNavigation")]
    public virtual ICollection<ResidentSummary> ResidentSummaries { get; } = new List<ResidentSummary>();

    [ForeignKey("Specials")]
    [InverseProperty("RegistrationExtensionSpecialsNavigations")]
    public virtual Lookup? SpecialsNavigation { get; set; }

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<TranRoutingHeader> TranRoutingHeaders { get; } = new List<TranRoutingHeader>();

    [ForeignKey("paymentType")]
    [InverseProperty("RegistrationExtensionpaymentTypeNavigations")]
    public virtual Lookup? paymentTypeNavigation { get; set; }

    [ForeignKey("resType")]
    [InverseProperty("RegistrationExtensionresTypeNavigations")]
    public virtual Lookup? resTypeNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("RegistrationExtensions")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
