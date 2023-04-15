using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class SeatTransactionDTO{
    public int Id { get; set; }
    public int Lineitem { get; set; }
    public int Movieschedule { get; set; }
    public int Seatarrangement { get; set; }
    public int Voudef { get; set; }
    public string? Remark { get; set; }
}
