using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Card
{
    public int Id { get; set; }

    public int CardType { get; set; }

    public int? Model { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant CardTypeNavigation { get; set; } = null!;

    public virtual ICollection<IssuedCard> IssuedCards { get; } = new List<IssuedCard>();

    public virtual SystemConstant? ModelNavigation { get; set; }
}
