using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorLibrary
{
    public class HotelMinibar : Refrigerator
    {
        public bool IsSnoozeActive { get; set; }

        public HotelMinibar() { }

        public HotelMinibar(string brand, string model, EnergyEfficiencyClass efficiency, int power, int vol)
            : base(brand, model, efficiency, power, vol, vol) { }

        public void ActivateSnooze(int hours)
        {
            if (hours < 1 || hours > 8) return;
            IsSnoozeActive = true;
        }

        public void QuickCool() => CurrentTemperature = 1.0;
    }
}
