using System;

public class Employee {
	
	
	// Public ifadesi olanlar, her yerden classimizda olan bu local variable-lara elcatan edir;
	public string name;
	public string surname;
	
	// private ifadesi olanlar ise, yalniz classimizin icinden cagirila bilendir.
	private string position;
	private int daily_salary;
	
	public Employee(string name_, string surname_, string position_, int daily_salary_)
   {
      name = name_;
      surname = surname_;
      position = position_;
      daily_salary = daily_salary_;
   }
	
   public double calcSalary(){
   	 return daily_salary * 30;
   }
	
}
					
public class Program
{
	public static void Main()
	{
		Employee new_employee = new Employee(name_: "Samad", surname_: "Balazade", position_: "Engineer", daily_salary_: 100);
		
		// Adını əldə etmək üçün.
		
		Console.WriteLine("Name: " + new_employee.name);
		
		Console.WriteLine("Surname: " + new_employee.surname);
		
		
		Console.WriteLine("Fullname: " + new_employee.name + " " + new_employee.surname);
		
		// Maasi hesablamaq üçün "calcSalary" methodunu çağırırıq.
		 
		Console.WriteLine("Salary: " + new_employee.calcSalary());
		
		
		// ama biz burda "Console.WriteLine("Position: " + new_employee.position);" bu kodu çalışdırsaq nə olacağ ?
		// işləməyəcək, çünki biz "position" bölməsini classımızda private olaraq qeyd etdik.
		
		
	}
}