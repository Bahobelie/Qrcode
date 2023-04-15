using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class MenuDesigner
{
    public int Id { get; set; }

    public int Pointer { get; set; }

    public string? FirstMenu { get; set; }

    public string? SecondMenu { get; set; }

    public string? ThirdMenu { get; set; }

    public string? FourthMenu { get; set; }

    public string? SixthMenu { get; set; }

    public int? FirstMenuSelectCount { get; set; }

    public int? SecondMenuSelcetCount { get; set; }

    public int? ThirdMenuSelectCount { get; set; }

    public int? FourthMenuSelectCount { get; set; }

    public int? FifthMenuSelectCount { get; set; }

    public int? SixthMenuSelectCount { get; set; }

    public string? Note { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant PointerNavigation { get; set; } = null!;
}
