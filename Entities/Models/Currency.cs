using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Currency", Schema = "common")]
[Index("code", Name = "IX_Currency", IsUnique = true)]
public partial class Currency
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string country { get; set; } = null!;

    [StringLength(8)]
    public string? sign { get; set; }

    [StringLength(8)]
    public string? abbreviation { get; set; }

    public bool isDefault { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("CurrencyNavigation")]
    public virtual ICollection<CurrencyPreference> CurrencyPreferences { get; } = new List<CurrencyPreference>();

    [InverseProperty("currencyNavigation")]
    public virtual ICollection<Denomination> Denominations { get; } = new List<Denomination>();

    [InverseProperty("currencyNavigation")]
    public virtual ICollection<ExchangeRate> ExchangeRates { get; } = new List<ExchangeRate>();

    [InverseProperty("currencyCodeNavigation")]
    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    [InverseProperty("currencyPreferenceNavigation")]
    public virtual ICollection<PackageHeader> PackageHeaders { get; } = new List<PackageHeader>();

    [InverseProperty("currencyNavigation")]
    public virtual ICollection<TransactionCurrency> TransactionCurrencies { get; } = new List<TransactionCurrency>();

    [InverseProperty("currencyNavigation")]
    public virtual ICollection<Value> Values { get; } = new List<Value>();

    [ForeignKey("country")]
    [InverseProperty("Currencies")]
    public virtual Country countryNavigation { get; set; } = null!;
}
