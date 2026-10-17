using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorLibrary
{
    public class SmartFridge : RefrigeratorWithFreezer
    {
        public bool IsConnectedToWiFi { get; set; }
        public double ScreenSize { get; set; }

        public SmartFridge() { }

        public SmartFridge(string brand, string model, EnergyEfficiencyClass efficiency, int power, int totalVol, int fridgeVol, string freezerPos, int freezerVol, double screenSize)
            : base(brand, model, efficiency, power, totalVol, fridgeVol, freezerPos, freezerVol)
        {
            ScreenSize = screenSize;
            IsConnectedToWiFi = false;
        }

        public void ConnectToNetwork(string ssid)
        {
            if (!IsTurnedOn) return;
            IsConnectedToWiFi = true;
        }

        public void SuggestRecipes()
        {
            if (!IsConnectedToWiFi) return;
        }

        public override string GetDeviceInfo()
        {
            string networkStatus = IsConnectedToWiFi ? "Онлайн" : "Офлайн";
            return base.GetDeviceInfo() + $"\nSmart-Панель: {ScreenSize} дюймів | Мережа: {networkStatus}";
        }
    }
}
