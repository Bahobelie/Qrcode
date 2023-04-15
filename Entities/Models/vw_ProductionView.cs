using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ProductionView
{
    [StringLength(26)]
    public string assemblyproformacode { get; set; } = null!;

    public int assemblyproformadef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime assemblyproformadate { get; set; }

    [StringLength(26)]
    public string? assemblynumber { get; set; }

    public int assemblydef { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal assemblyquantity { get; set; }

    [StringLength(26)]
    public string creditinvoicenumber { get; set; } = null!;

    public int creditinvoicedef { get; set; }

    [StringLength(26)]
    public string customer { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? creditinvoicedate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? crvdate { get; set; }

    [StringLength(26)]
    public string jobordernumber { get; set; } = null!;

    [StringLength(26)]
    public string boardtype { get; set; } = null!;

    [StringLength(26)]
    public string startingdate { get; set; } = null!;

    [StringLength(26)]
    public string promisseddeliverydate { get; set; } = null!;

    public int JobOrderdef { get; set; }

    [StringLength(26)]
    public string assignedtechnicalname { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string testingfindings { get; set; } = null!;

    public int? remainingassemblyboard { get; set; }

    [StringLength(26)]
    public string packingdate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? summerydate { get; set; }

    public int? Rowmaterialdef { get; set; }

    [StringLength(100)]
    public string remark { get; set; } = null!;
}
