using System;

class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string course, double salary)
    {
        profName = name;
        classTeach = course;
        this.salary = salary;
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }

    public string GetName()
    {
        return profName;
    }

    public string GetClassTeach()
    {
        return classTeach;
    }
}

class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }

    public string GetName()
    {
        return studentName;
    }

    public string GetClassEnroll()
    {
        return classEnroll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        // Print details for professors
        Console.WriteLine("Details for Professors:");
        Console.WriteLine($"Professor 1: {prof1.GetName()}, Teaches: {prof1.GetClassTeach()}, Salary: {prof1.GetSalary()}");
        Console.WriteLine($"Professor 2: {prof2.GetName()}, Teaches: {prof2.GetClassTeach()}, Salary: {prof2.GetSalary()}");

        // Print details for students
        Console.WriteLine("\nDetails for Students:");
        Console.WriteLine($"Student 1: {student1.GetName()}, Enrolled in: {student1.GetClassEnroll()}, Grade: {student1.GetGrade()}");
        Console.WriteLine($"Student 2: {student2.GetName()}, Enrolled in: {student2.GetClassEnroll()}, Grade: {student2.GetGrade()}");

        // Calculate and print difference in salary between professors
        double salaryDifference = Math.Abs(prof1.GetSalary() - prof2.GetSalary());
        Console.WriteLine($"\nDifference in salary between professors: {salaryDifference}");

        // Calculate and print total grade
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"Total grade of Lisa's Java course and Tom's Math course: {totalGrade}");
    }
}
