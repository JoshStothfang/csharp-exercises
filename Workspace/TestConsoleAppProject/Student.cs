using System;
namespace Workspace;
	
internal class Student
{
	public static int CohortNumber { get; set; } = 41; //static (property)

	public static int NextId { get; set; } = 1;

	public int Id { get; set; }

	public string Name { get; set; }

	public string State { get; set; }

	public static void Print(string message) //static (method)
	{
		Console.WriteLine(message);
	}

	public void ChangeName(string newName = "New Student")
	{
		Name = newName;
	}

	public void changeName(string firstName, string lastName)
	{
		Name = $"{firstName} {lastName}";
	}


	public Student(string Name) : this(Name, "OH") //constructor that uses other constructor 
	{

	}

	public Student(string Name = "New Student", string State = "OH")
	{
		this.Id = NextId++;//since NextId is static, it increments for each instance created
		this.Name = Name;
		this.State = State;
	}

	
}


