using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorLibrary
{
    public abstract class BaseRefrigerator
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public EnergyEfficiencyClass EfficiencyClass { get; set; }
        public bool IsTurnedOn { get; set; }
        public int PowerConsumptionWatts { get; set; }

        public int TotalVolume { get; set; }
        public int FridgeVolume { get; set; }

        public double CurrentTemperature { get; set; } = 4.0;

        public BaseRefrigerator() { }

        protected BaseRefrigerator(string brand, string model, EnergyEfficiencyClass efficiency, int power, int totalVol, int fridgeVol)
        {
            Brand = brand;
            Model = model;
            EfficiencyClass = efficiency;
            PowerConsumptionWatts = power;
            TotalVolume = totalVol;
            FridgeVolume = fridgeVol;
            IsTurnedOn = false;
        }

        public virtual void TurnOn() => IsTurnedOn = true;
        public virtual void TurnOff() => IsTurnedOn = false;

        public virtual void SetTemperature(double temp)
        {
            if (temp < 0 || temp > 15)
                throw new InvalidTemperatureException("Помилка: Температура холодильного відділення повинна бути в межах від 0 до 15 градусів.", temp);
            CurrentTemperature = temp;
        }

        public virtual string GetDeviceInfo()
        {
            string status = IsTurnedOn ? "АКТИВНО" : "ВИМКНЕНО";
            return $" | Статус: {status} | Клас енергоефективності: {EfficiencyClass} | Споживання: {PowerConsumptionWatts} Вт" +
                   $"\nОб'єм: {TotalVolume} л (Холодильна камера: {FridgeVolume} л) | Поточна темп.: {CurrentTemperature}°C";
        }
    }
}
