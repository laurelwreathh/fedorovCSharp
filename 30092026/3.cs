using System;
using System.Collections.Generic;
using System.IO;

namespace EnterpriseEquipmentDemo
{
    class Equipment
    {
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> registrationQueue = new List<Equipment>
            {
                new Equipment { ModelName = "Сервер SRV-200", SerialNumber = "SN-99482" },
                new Equipment { ModelName = "Коммутатор SW-10", SerialNumber = "" },
                new Equipment { ModelName = "Маршрутизатор RT-5", SerialNumber = "SN-11023" }
            };

            Console.WriteLine("Запуск процедуры регистрации нового оборудования...");

            RegisterEquipmentBatch(registrationQueue);

            Console.WriteLine("Процедура регистрации завершена.");
        }


        static void RegisterEquipmentBatch(List<Equipment> items)
        {
            foreach (var item in items)
            {
                try
                {
                    if (string.IsNullOrEmpty(item.SerialNumber))
                    {
                        throw new Exception("Серийный номер отсутствует");
                    }

                    RegisterInSystem(item);
                }
                catch (Exception ex)
                {
                    string log =
                        $"[{DateTime.Now}] | Модель: {item.ModelName} | Сбой: {ex.Message}\n";

                    string path =
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        + "\\equipment_errors.log";

                    File.AppendAllText(path, log);

                    Console.WriteLine("Ошибка записана в файл.");
                }
            }
        }


        static void RegisterInSystem(Equipment eq)
        {
            Console.WriteLine(
                $"[СИСТЕМА] Оборудование '{eq.ModelName}' (S/N: {eq.SerialNumber}) успешно внесено в реестр.");
        }
    }
}