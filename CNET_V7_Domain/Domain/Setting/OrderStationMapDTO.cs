﻿using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class OrderStationMapDTO{
    public int Id { get; set; }
    public int PosDevice { get; set; }
    public int Preference { get; set; }
    public int StationDevice { get; set; }
    public string? Remark { get; set; }
}
