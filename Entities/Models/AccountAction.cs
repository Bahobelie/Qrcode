using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AccountAction", Schema = "common")]
public partial class AccountAction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ActionRequired { get; set; } = null!;

    [StringLength(26)]
    public string Account { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Remark { get; set; } = null!;

    [ForeignKey("Account")]
    [InverseProperty("AccountActions")]
    public virtual Account AccountNavigation { get; set; } = null!;
}
