using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("EventDetail", Schema = "cnetEvent")]
public partial class EventDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? space { get; set; }

    [StringLength(26)]
    public string? spaceArrangment { get; set; }

    public int? noOfPerson { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimeStamp { get; set; }

    [StringLength(1000)]
    public string? remark { get; set; }

    [InverseProperty("eventDetailNavigation")]
    public virtual ICollection<EvenetRequiremenet> EvenetRequiremenets { get; } = new List<EvenetRequiremenet>();
}
