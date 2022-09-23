﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateCityBuildingSimulator.Game.Building
{
    public interface IBuildable : ICloneable
    {
        int ProvideCost();
        float ProvideMultiplier();
    }
}
