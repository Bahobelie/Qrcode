using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class FieldFormat
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public int? Pointer { get; set; }

    public int? TargetPointer { get; set; }

    public int? Index { get; set; }

    public int? Width { get; set; }

    public string? Font { get; set; }

    public string? Color { get; set; }

    public int? Caption { get; set; }

    public bool? IsRequired { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? PointerNavigation { get; set; }

    public virtual SystemConstant? TargetPointerNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
