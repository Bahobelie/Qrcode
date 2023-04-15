using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VOD_View
{
    [StringLength(26)]
    public string media { get; set; } = null!;

    [StringLength(26)]
    public string movie { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(1000)]
    public string streamURL { get; set; } = null!;

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string category { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    [Column(TypeName = "date")]
    public DateTime releaseDate { get; set; }

    [StringLength(26)]
    public string duration { get; set; } = null!;

    public string director { get; set; } = null!;

    public string actors { get; set; } = null!;

    public string plot { get; set; } = null!;

    [StringLength(26)]
    public string typeCode { get; set; } = null!;

    [StringLength(26)]
    public string categoryCode { get; set; } = null!;

    [StringLength(256)]
    public string? attachmentURL { get; set; }

    public byte[]? attachment { get; set; }

    [StringLength(26)]
    public string? articleCode { get; set; }

    public string? articleName { get; set; }

    [Column(TypeName = "money")]
    public decimal? priceValue { get; set; }

    public int? index { get; set; }

    public bool? active { get; set; }

    [StringLength(26)]
    public string? currency { get; set; }

    [StringLength(8)]
    public string? sign { get; set; }

    [StringLength(8)]
    public string? abbreviation { get; set; }

    [StringLength(50)]
    public string? Expr1 { get; set; }

    public string? writer { get; set; }

    public string? producer { get; set; }

    [StringLength(26)]
    public string? dimension { get; set; }

    [StringLength(26)]
    public string? movielanguage { get; set; }

    [StringLength(26)]
    public string? subtitlelanguage { get; set; }

    [StringLength(26)]
    public string? rating { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(26)]
    public string? AttachmentCatagory { get; set; }
}
