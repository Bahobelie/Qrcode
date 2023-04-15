using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Project", Schema = "Internal")]
public partial class Project
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [StringLength(26)]
    public string orgUnitDefn { get; set; } = null!;

    [StringLength(26)]
    public string caseCode { get; set; } = null!;

    [StringLength(26)]
    public string caseCause { get; set; } = null!;

    [StringLength(26)]
    public string serviceType { get; set; } = null!;

    [StringLength(26)]
    public string transportationType { get; set; } = null!;

    [StringLength(250)]
    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime datetime { get; set; }
}
