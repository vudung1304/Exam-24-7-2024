namespace Practice_Examm.exam1;

public class People
{
    public string Name { get; set; }
    public bool Gender { get; set; }
    public int Age { get; set; }
    
    public People(string name, bool gender, int  age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }

    public void DisplayAndIncrementAge()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");

        Age++;
        
        Console.WriteLine($"After age increases: {Age}");
    }
}