//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace EnterpriseDirectoryDemo
//{
//    class Employee
//    {
//        public string FullName { get; set; }
//        public string Department { get; set; }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> incomingPayloads = new List<Employee>
//            {
//                new Employee { FullName = "Иванов И.И.", Department = "IT" },
//                null,
//                new Employee { FullName = null, Department = "HR" },
//                new Employee { FullName = "Петров П.П.", Department = "Finance" }
//            };


//            Console.WriteLine("Запуск пакетной обработки профилей сотрудников...");

//            ProcessDirectoryUpdate(incomingPayloads);

//            Console.WriteLine("Пакетная обработка завершена.");
//        }


//        static void ProcessDirectoryUpdate(List<Employee> employees)
//        {
//            for (int i = 0; i < employees.Count; i++)
//            {
//                try
//                {
//                    Employee emp = employees[i];

//                    if (emp == null)
//                    {
//                        throw new Exception("Employee object is null");
//                    }

//                    if (emp.FullName == null)
//                    {
//                        throw new Exception("Employee name is null");
//                    }

//                    string uppercaseName = emp.FullName.ToUpper();

//                    string formattedRecord =
//                        string.Concat(
//                            "Employee: ",
//                            uppercaseName,
//                            " [Department: ",
//                            emp.Department,
//                            "]"
//                        );

//                    Console.WriteLine(
//                        $"[DATABASE] Record created successfully: {formattedRecord}");
//                }
//                catch (Exception ex)
//                {
//                    string errorText =
//                        $"Time: {DateTime.Now}\n" +
//                        $"Problem index: {i}\n" +
//                        $"Error: {ex.Message}\n\n";


//                    string path =
//                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
//                        + "\\directory_errors.log";


//                    File.AppendAllText(path, errorText);


//                    Console.WriteLine("Error saved to log file.");
//                }
//            }
//        }
//    }
//}