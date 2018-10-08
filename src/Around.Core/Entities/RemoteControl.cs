﻿using Around.Core.Enums;
using System.Collections.Generic;

namespace Around.Core.Entities
{
    public class RemoteControl
    {
        public ControlType ControlType { get; }

        public bool HasBuiltInDisplay { get; }

        public bool MobileDeviceMount { get; }

        public List<string> Connectors { get; } 

        public double MaximumRadius { get; }

    }
}
