using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Country
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? Name { get; set; }

    public string? PoliticalName { get; set; }

    public int? Continent { get; set; }

    public string? TelephoneCode { get; set; }

    public string? TimeZone { get; set; }

    public string? Nationality { get; set; }

    public string? IcaocountryCode { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Article> Articles { get; } = new List<Article>();

    public virtual ICollection<ConsigneeUnit> ConsigneeUnits { get; } = new List<ConsigneeUnit>();

    public virtual ICollection<Consignee> Consignees { get; } = new List<Consignee>();

    public virtual ICollection<Currency> Currencies { get; } = new List<Currency>();

    public virtual ICollection<SubCountry> SubCountries { get; } = new List<SubCountry>();
}
