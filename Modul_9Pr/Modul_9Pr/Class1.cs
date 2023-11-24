using Modul_9Pr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Class1
{
    public static object DVDType { get; private set; }

    static void Main()
    {
        DataTransferManager transferManager = new DataTransferManager();

        // Добавляем устройства
        transferManager.AddStorageDevice(new Flash("Flash1", "Model1", 100, 64));
        transferManager.AddStorageDevice(new DVD("DVD1", "Model2", 5, 9, DVDType.SingleLayer));
        transferManager.AddStorageDevice(new HDD("HDD1", "Model3", 30, 2, 1024));

        // Выполняем операции
        double totalMemory = transferManager.CalculateTotalMemory();
        Console.WriteLine($"Total Memory: {totalMemory} GB");

        double dataSize = 780; // Размер файла в Мб
        transferManager.CopyDataToDevices(dataSize);

        double timeForCopy = transferManager.CalculateTimeForCopy(dataSize);
        Console.WriteLine($"Estimated Time for Copy: {timeForCopy} seconds");

        int requiredDevices = transferManager.CalculateRequiredDevices(dataSize);
        Console.WriteLine($"Required Devices: {requiredDevices}");

        Console.ReadLine();
    }
}

