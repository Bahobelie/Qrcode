using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_allAddressView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? name { get; set; }

    public int gslType { get; set; }

    public string? email { get; set; }

    public string? extension { get; set; }

    public string? fax { get; set; }

    public string? homePhone { get; set; }

    public string? kebele { get; set; }

    public string? linekedIn { get; set; }

    public string? mobilePhone { get; set; }

    public string? pobox { get; set; }

    public string? region { get; set; }

    public string? smtpServer { get; set; }

    public string? socialMedia { get; set; }

    public string? specificLocation { get; set; }

    public string? twitter { get; set; }

    public string? wereda { get; set; }

    public string? workMobile { get; set; }

    public string? physicalAddress { get; set; }

    public string? website { get; set; }

    public string? houseNo { get; set; }

    public string? city { get; set; }
}
