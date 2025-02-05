using System.IO.Pipelines;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Position { get; set; }

    public Employee(string name, string id, string department, string position)
    {
        Id = id;
        Name = name;
        Department = department;
        Position = position;
    }
}


public class Employees
{
    private List<Employee> _listEmployees;
    
    public Employees(List<Employee> listEmployees)
    {
        _listEmployees = listEmployees;
    }
    
    //public Employee FindEmployeeById(string id)
    public void FindEmployeeById(string input_id)
    {
        var k = false;
        foreach(Employee person in _listEmployees){
            if(person.Id == input_id){
                Console.WriteLine($"Найдено \n {person.Name}, {person.Department}, {person.Position}");
                k = true;
            }
        }
        if(k == false){
            Console.WriteLine("Такого пользователя нет");
        }
    }
    
    public void AddEmployee(string input_name, string strID,string input_dep,stringa input_pos)
    {
       
    }
    
    public void UpdateEmployee(Employee employee)
    {
       
    }
    
    public void RemoveEmployee(string id)
    {
      
    }
}

public class Program
{   
    public static void Main()
    {
        Random rnd = new Random();    
        Employee employee1 = new Employee("Сьюзан Майерс","47899","Бухгалтерия","Вице-президент");
        Employee employee2 = new Employee("Боб","12345","Офис","Работник");
        Employee employee3 = new Employee("Джон","54321","Охрана","Охранник");

        var employees = new List<Employee> {employee1, employee2};
        employees.Add(employee3);

        Console.WriteLine("1. Найти сотрудника по идентификационному номеру");
        Console.WriteLine("2. Добавить нового сотрудника");
        Console.WriteLine("3. Изменить имя, отдел и должность существующего сотрудника");
        Console.WriteLine("4. Удалить сотрудника");
        Console.WriteLine("0. Выйти из программы");

        var emploeesList = new Employees(employees);
        var flag = true;
        while (flag)
        {
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var input_id = Console.ReadLine();
                    emploeesList.FindEmployeeById(input_id);
                    break;
                case "2":
		    Console.Write("Имя нового сотрудника: ");
		    var input_name = Console.ReadLine();
		    var input_ID = rnd.Next();
		    string strID = input_ID.ToString();
		    foreach(int i in employees.id){
		        while(strID == i){
			    input_ID = rnd.Next();
			    strID = input_ID.ToString();
			} 

		    }
		    Console.WriteLine("Новому сотруднику присвоен ID: " + strID);
                    Console.Write("Место работы нового сотрудника: ");
                    var input_dep = Console.ReadLine();
		    Console.Write("Должность нового сотрудника: ")
                    var input_pos = Console.ReadLine();
		    emploeesList.AddEmployee(input_name, strID, input_dep, input_pos);

                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "0":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            
            }
        }
    }
}