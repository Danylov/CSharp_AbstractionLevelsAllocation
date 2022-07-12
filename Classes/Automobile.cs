using System;
using System.Collections.Generic;
using System.Diagnostics;
using AbstractionLevelsAllocation.Enums;
using AbstractionLevelsAllocation.Interfaces;

namespace AbstractionLevelsAllocation.Classes
{
    public class Automobile : IEngine, IControl
    {
        private bool engineState;
        private float speed;
        private float rotation;
        private double price;
        private int damagesCount;
        private List<int> damages;
        
        public int DamagesCount
        {
            get => damagesCount;
            set => damagesCount = value;
        }

        public List<int> Damages
        {
            get => damages;
            set => damages = value;
        }

        public Automobile(double price)
        {
            this.price = price;
            damagesCount = Enum.GetValues(typeof(EDamageType)).Length;
            damages = new List<int>(damagesCount);
            for (int i = 0; i < damagesCount; i++) damages.Add(0);
        }

        public bool EngineState
        {
            get => engineState;
            set => engineState = value;
        }
        
        public float Speed
        {
            get => speed;
            set => speed = value;
        }

        public float Rotation
        {
            get => rotation;
            set => rotation = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public EEngineType EngineType { get; set; }
        
        public EDamageType DamageType { get; set; }

        public void TurnEngine()
        {
            EngineState = !EngineState;
        }

        public void SpeedUp(float deltaSpeed)
        {
            Speed += deltaSpeed;
        }

        public void SpeedDown(float deltaSpeed)
        {
            Speed -= deltaSpeed;
        }

         public void turnLeft(float deltaAngle)
         {
             Rotation -= deltaAngle;
         }

         public void turnRight(float deltaAngle)
         {
             Rotation += deltaAngle;
         }

         public double getPrice()
         {
             return price;
         }
    }
}