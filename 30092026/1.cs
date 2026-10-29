//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace EnterpriseStorageDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] warehouseStock =
//            {
//                "Корпус A-10",
//                "Плата ЦП-v2",
//                "Модуль ОЗУ-8G",
//                "Блок питания-500W"
//            };

//            int[] requestedIndices = { 0, 2, 1, 4, 3 };

//            Console.WriteLine("Запуск процедуры отгрузки компонентов со склада...");

//            try
//            {
//                List<string> dispatchList = ExtractCargo(warehouseStock, requestedIndices);

//                Console.WriteLine($"Успешно подготовлено к отгрузке: {dispatchList.Count} наим.");
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                string errorText =
//                    $"Time: {DateTime.Now}\n" +
//                    $"Problem index: 4\n" +
//                    $"Error: {ex.Message}\n";

//                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
//                               + "\\warehouse_errors.log";

//                File.WriteAllText(path, errorText);

//                Console.WriteLine("Error saved to log file.");
//            }
//        }


//        static List<string> ExtractCargo(string[] stock, int[] indices)
//        {
//            List<string> order = new List<string>();

//            for (int i = 0; i < indices.Length; i++)
//            {
//                int targetIndex = indices[i];

//                string item = stock[targetIndex];

//                order.Add(item);

//                Console.WriteLine($"[OK] Компонент '{item}' добавлен в заказ.");
//            }

//            return order;
//        }
//    }
//}