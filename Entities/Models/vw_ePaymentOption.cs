using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ePaymentOption
{
    [StringLength(26)]
    public string Device { get; set; } = null!;

    public string deviceArticle { get; set; } = null!;

    [StringLength(26)]
    public string DeviceOrgUnitDef { get; set; } = null!;

    [StringLength(50)]
    public string org { get; set; } = null!;

    [StringLength(26)]
    public string ProviderOrgUnitDef { get; set; } = null!;

    [StringLength(50)]
    public string PaymentOptionName { get; set; } = null!;

    [StringLength(26)]
    public string ProviderTin { get; set; } = null!;

    public string? ProviderOrganizationName { get; set; }
}
