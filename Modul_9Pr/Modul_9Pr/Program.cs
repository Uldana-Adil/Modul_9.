using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_9Pr
{
    public abstract class Storage
    {
        private string name;
        private string model;

        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public abstract double GetMemorySize();

        public abstract void CopyData(double dataSize);

        public abstract double GetFreeMemory();

        public string GetDeviceInfo()
        {
            return $"Name: {name}, Model: {model}, Memory Size: {GetMemorySize()} GB";
        }
    }
    public class Flash : Storage
    {
        private double usb3Speed;
        private double memorySize;

        public Flash(string name, string model, double usb3Speed, double memorySize)
            : base(name, model)
        {
            this.usb3Speed = usb3Speed;
            this.memorySize = memorySize;
        }

        public override double GetMemorySize()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            // Реализация копирования данных на Flash-память
        }

        public override double GetFreeMemory()
        {
            // Реализация получения свободного места на Flash-памяти
            return 0;
        }
    }
    public class DataTransferManager
    {
        private List<Storage> storageDevices;

        public DataTransferManager()
        {
            storageDevices = new List<Storage>();
        }

        public void AddStorageDevice(Storage device)
        {
            storageDevices.Add(device);
        }

        public double CalculateTotalMemory()
        {
            double totalMemory = 0;
            foreach (var device in storageDevices)
            {
                totalMemory += device.GetMemorySize();
            }
            return totalMemory;
        }

        public void CopyDataToDevices(double dataSize)
        {
            foreach (var device in storageDevices)
            {
                device.CopyData(dataSize);
            }
        }

        public double CalculateTimeForCopy(double dataSize)
        {
            
            return 0;
        }

        public int CalculateRequiredDevices(double dataSize)
        {
           
            return 0;
        }
    }


}
