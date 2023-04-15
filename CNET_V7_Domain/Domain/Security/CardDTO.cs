using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class CardDTO{
    public int Id { get; set; }
    public int CardType { get; set; }
    public int? Model { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public string? Status { get; set; }
    public string? Remark { get; set; }
}
