using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("MenuDesigner", Schema = "pos")]
public partial class MenuDesigner
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string? firstMenu { get; set; }

    [StringLength(26)]
    public string? secondMenu { get; set; }

    [StringLength(26)]
    public string? thirdMenu { get; set; }

    [StringLength(26)]
    public string? fourthMenu { get; set; }

    [StringLength(26)]
    public string? fifthMenu { get; set; }

    [StringLength(26)]
    public string? sixthMenu { get; set; }

    public int? firstMenuSelectCount { get; set; }

    public int? secondMenuSelectCount { get; set; }

    public int? thirdMenuSelectCount { get; set; }

    public int? fourthMenuSelectCount { get; set; }

    public int? fifthMenuSelectCount { get; set; }

    public int? sixthMenuSelectCount { get; set; }

    public string? note { get; set; }

    [StringLength(26)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("MenuDesigners")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;

    [ForeignKey("fifthMenu")]
    [InverseProperty("MenuDesignerfifthMenuNavigations")]
    public virtual Preference? fifthMenuNavigation { get; set; }

    [ForeignKey("firstMenu")]
    [InverseProperty("MenuDesignerfirstMenuNavigations")]
    public virtual Preference? firstMenuNavigation { get; set; }

    [ForeignKey("fourthMenu")]
    [InverseProperty("MenuDesignerfourthMenuNavigations")]
    public virtual Preference? fourthMenuNavigation { get; set; }

    [ForeignKey("secondMenu")]
    [InverseProperty("MenuDesignersecondMenuNavigations")]
    public virtual Preference? secondMenuNavigation { get; set; }

    [ForeignKey("sixthMenu")]
    [InverseProperty("MenuDesignersixthMenuNavigations")]
    public virtual Preference? sixthMenuNavigation { get; set; }

    [ForeignKey("thirdMenu")]
    [InverseProperty("MenuDesignerthirdMenuNavigations")]
    public virtual Preference? thirdMenuNavigation { get; set; }
}
