// See https://aka.ms/new-console-template for more information
//OOP

//Task 1
using System.Security.Cryptography;

public class Student
{
    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;
    }

    //Task 2
    public void PrintStudentFormatted()
    {
        Console.WriteLine("Student Information:");
        Console.WriteLine($"Student name: \t{Name}\nStudent Major: \t{Major}\nStudent GPA: \t{GPA} ");
        
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Mubarak", "CE", 3.82);
        student.PrintStudentFormatted();
        Console.WriteLine("--------------------------------------");
        GraduateStudent graduation = new GraduateStudent("Ahmad", "IST",3.30,"Physics");
        graduation.PrintSummary();
    }
}