using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorLibrary
{
    public class RefrigeratorWithFreezer : Refrigerator
    {
        public int FreezerVolume { get; set; }
        public string FreezerPosition { get; set; }

        public double CurrentFreezerTemperature { get; set; } = -18.0;

        public RefrigeratorWithFreezer() { }

        public RefrigeratorWithFreezer(string brand, string model, EnergyEfficiencyClass efficiency, int power, int totalVol, int fridgeVol, string freezerPos, int freezerVol)
            : base(brand, model, efficiency, power, totalVol, fridgeVol)
        {
            FreezerPosition = freezerPos;
            FreezerVolume = freezerVol;
        }

        public override string GetDeviceInfo()
        {
            return base.GetDeviceInfo() + $"\nМорозильна камера: {FreezerVolume} л (Розташування: {FreezerPosition}) | Темп. морозилки: {CurrentFreezerTemperature}°C";
        }

        public void SetFreezerTemp(double temp)
        {
            if (temp > 0 || temp < -30)
                throw new InvalidTemperatureException("Помилка: Температура морозильного відділення повинна бути в межах від -30 до 0 градусів.", temp);
            CurrentFreezerTemperature = temp;
        }
    }
}
