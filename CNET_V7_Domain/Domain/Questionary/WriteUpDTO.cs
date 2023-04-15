using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.QuestionarySchema;
public partial class WriteUpDTO{
    public int Id { get; set; }
    public int? Question { get; set; }
    public int? NoOfBlank { get; set; }
    public int? CharacterLength { get; set; }
    public string? Remark { get; set; }
}
