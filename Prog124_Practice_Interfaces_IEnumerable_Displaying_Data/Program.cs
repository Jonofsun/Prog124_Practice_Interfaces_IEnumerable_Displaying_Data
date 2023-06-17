using Prog124_Practice_Interfaces_IEnumerable_Displaying_Data;

static void Main(string[] args)
{
    SchoolClass myClass = new SchoolClass("Mathematics");

    // Add students to the class roster
    myClass.AddStudent(new Student("Jonathan"));
    myClass.AddStudent(new Student("Emily"));
    myClass.AddStudent(new Student("Michael"));
    myClass.AddStudent(new Student("Sophia"));
    myClass.AddStudent(new Student("William"));
    myClass.AddStudent(new Student("Olivia"));
    myClass.AddStudent(new Student("James"));
    myClass.AddStudent(new Student("Ava"));
    myClass.AddStudent(new Student("Benjamin"));
    myClass.AddStudent(new Student("Isabella"));
    myClass.AddStudent(new Student("Daniel"));
    myClass.AddStudent(new Student("Mia"));
    myClass.AddStudent(new Student("Matthew"));
    myClass.AddStudent(new Student("Charlotte"));
    myClass.AddStudent(new Student("David"));
    myClass.AddStudent(new Student("Abigail"));
    myClass.AddStudent(new Student("Joseph"));
    myClass.AddStudent(new Student("Harper"));
    myClass.AddStudent(new Student("Andrew"));
    myClass.AddStudent(new Student("Ella"));

    
    Console.WriteLine($"Class Name: {myClass.ClassName}");
    Console.WriteLine("Roster:");
    foreach (var student in myClass.Roster)
    {
        Console.WriteLine(student.ToString());
    }
}
