using System;

namespace ConsoleApp2
{
    class Employee
    {
        string Surname;
        string Name;
        string Patronymic;
        string Specialty;
        string Departament;
        int Salary;
        public Employee(string surname, string name, string patronymic, string specialty, string departament, int salary)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Specialty = specialty;
            Departament = departament;
            Salary = salary;
        }
        public void GetInfoEmployee()
        {
            Console.WriteLine($"Фамилия: {Surname} " +
                              $"Имя: {Name} " +
                              $"Отчество: {Patronymic} " +
                              $"Должность: {Specialty} " +
                              $"Отдел: {Departament} " +
                              $"Оклад: {Salary}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee staff = new Employee("Иваноы", "Иван", "Иванович", "Администротор", "Продаж", 50000);
            staff.GetInfoEmployee();
            Employee staff1 = new Employee("Петров", "Петр", "Петрович", "младший сотрудник", "Логистика", 25000);
            staff1.GetInfoEmployee();
            Console.ReadKey(true);
        }
    }
}
