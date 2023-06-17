using Prog124_Practice_Interfaces_IEnumerable_Displaying_Data;

    SchoolClass Prog124 = new SchoolClass("Programming");

    // Add students to the class roster
    Prog124.AddStudent(new Student("Jonathan"));
    Prog124.AddStudent(new Student("Emily"));
    Prog124.AddStudent(new Student("Michael"));
    Prog124.AddStudent(new Student("Sophia"));
    Prog124.AddStudent(new Student("William"));
    Prog124.AddStudent(new Student("Olivia"));
    Prog124.AddStudent(new Student("James"));
    Prog124.AddStudent(new Student("Ava"));
    Prog124.AddStudent(new Student("Benjamin"));
    Prog124.AddStudent(new Student("Isabella"));
    Prog124.AddStudent(new Student("Daniel"));
    Prog124.AddStudent(new Student("Mia"));
    Prog124.AddStudent(new Student("Matthew"));
    Prog124.AddStudent(new Student("Charlotte"));
    Prog124.AddStudent(new Student("David"));
    Prog124.AddStudent(new Student("Abigail"));
    Prog124.AddStudent(new Student("Joseph"));
    Prog124.AddStudent(new Student("Harper"));
    Prog124.AddStudent(new Student("Andrew"));
    Prog124.AddStudent(new Student("Ella"));

    Console.WriteLine($"Class Name: {Prog124.ClassName}");
    Console.WriteLine("Roster:");
    foreach (var student in Prog124)
    {
        Console.WriteLine(student.ToString());
    }
