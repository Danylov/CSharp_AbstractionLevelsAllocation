using System;
using System.Diagnostics;
using AbstractionLevelsAllocation.Classes;
using AbstractionLevelsAllocation.Enums;

namespace AbstractionLevelsAllocation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Automobile autoForBuy;
            Automobile automobile1 = new Automobile(5000);
            Automobile automobile2 = new Automobile(6000);
            
            // 4.	Выбор автомобиля для покупки.
            autoForBuy = (automobile1.Price <= automobile2.Price) ? automobile1 : automobile2; 
            
            // 1.	Управление автомобилем
            autoForBuy.EngineType = EEngineType.ICE;
            autoForBuy.TurnEngine();
            
            // 2.	Поездка на автомобиле.
            autoForBuy.SpeedUp(20f);
            autoForBuy.SpeedDown(10f);
            autoForBuy.turnLeft(90f);
            autoForBuy.turnRight(45f);
            
            // 3.	Повреждение автомобиля.
            Random randomValue = new Random();
            int rValue = randomValue.Next(0, autoForBuy.DamagesCount);
            autoForBuy.Damages[rValue] = 1;

            // 5.	Диагностика неисправленности и ремонт автомобиля.
            for (int i = 0; i < autoForBuy.Damages.Count; i++) 
            {
                if (autoForBuy.Damages[i] == 1) autoForBuy.Damages[i] = 0;
            }
        }
    }
}