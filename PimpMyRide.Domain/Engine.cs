﻿namespace PimpMyRide.Domain
{
    public class Engine : Part
    {
        public Engine(int durability, decimal buyPrice, decimal repairPrice, int capacity) 
            : base(durability, buyPrice, repairPrice, capacity)
        {
        }
    }
}