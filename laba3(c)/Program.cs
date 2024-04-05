using laba3_c_;

Company company = new Company { Title = "Пивоварня MX" };
Department department1 = new Department { Title = "Поставщики", _company_ = company };
Department department2 = new Department { Title = "Варщики", _company_ = company };

company.addDepartment(department1);
company.addDepartment(department2);

Employee employee1 = new Employee { Full_name = "Василий Чехов Владимирович", Position = "Водитель", Salary = 100, Departments = department1 };
Employee employee2 = new Employee { Full_name = "Олег Карасёв Дмитриевич", Position = "Грузчик", Salary = 100, Departments = department1 };
Employee employee3 = new Employee { Full_name = "Бахтеев Максим Александрович", Position = "Директор", Salary = 1_000_000, Departments = department2 };

department1.addEmployee(employee1);
department1.addEmployee(employee2);
department2.addEmployee(employee3);



Employee wanted_emloyee = company.findEmployee("Бахтеев Максим Александрович");

if (wanted_emloyee != null)
{
    Console.WriteLine("Найденный сотрудник:");
    Console.WriteLine("ФИО: " + wanted_emloyee.Full_name);
    Console.WriteLine("Должность: " + wanted_emloyee.Position);
    Console.WriteLine("Оклад: " + wanted_emloyee.Salary);
    Console.WriteLine("Отдел: " + wanted_emloyee.Departments.Title);
}
else
{
    Console.WriteLine("Такого сотрудника нет");
}