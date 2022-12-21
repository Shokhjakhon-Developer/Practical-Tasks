﻿namespace Practical_Task_3;



    public class Bus: Vehicle
    {
        private const string Description = "\nBus Characteristics \n";
        public Bus(int power, double volume, string type,
            string serialNum, int wheelsNum, int chassisNum, int maxLoad,
            string transmissionType, int numOfGears, string manufacturer) : base(power, volume, type, serialNum,
            wheelsNum, chassisNum, maxLoad, transmissionType, numOfGears, manufacturer){}
        

        public override string ToString()
        {
            return Description + GetEngineInfo() + GetChassisInfo() + GetTransmissionInfo();
        }
    }
