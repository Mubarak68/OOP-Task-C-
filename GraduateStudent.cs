// See https://aka.ms/new-console-template for more information
//OOP

//Task 1
public class GraduateStudent : Student
{
    string TheisTopic { get; set; }
    public GraduateStudent(string name, string major, double gpa,string theisTopic) 
        : base(name, major, gpa)
    {
        TheisTopic = theisTopic;
    }

   public new void PrintSummary()
    {
        Console.WriteLine("Graduated Student:");
        base.PrintStudentFormatted();
        Console.WriteLine($"Reserch Topic: {TheisTopic}");
    }

}
