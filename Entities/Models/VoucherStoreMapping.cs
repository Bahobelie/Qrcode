using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherStoreMapping", Schema = "common")]
[Index("code", Name = "IX_VoucherStoreMapping", IsUnique = true)]
[Index("voucherDefn", Name = "Voucher_Store_Mapping_VdefIndex")]
public partial class VoucherStoreMapping
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string store { get; set; } = null!;

    public bool isSource { get; set; }

    public bool isDefault { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [ForeignKey("store")]
    [InverseProperty("VoucherStoreMappings")]
    public virtual OrganizationUnitDefinition storeNavigation { get; set; } = null!;

    [ForeignKey("voucherDefn")]
    [InverseProperty("VoucherStoreMappings")]
    public virtual VoucherDefinition voucherDefnNavigation { get; set; } = null!;
}
