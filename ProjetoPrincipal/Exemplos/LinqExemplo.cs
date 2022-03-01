public class LinqExemplo
{
    public void Exemplos()
    {
        // primeiroExempoLinq();
        segundoExemploLinq();
    }

    public void primeiroExempoLinq()
    {

        // Data source
        string[] names = { "Claydson", "Deywid", "Renato", "Johann" };

        // LINQ Query 
        var myLinqQuery = from name in names
                            where name.Contains('a')
                            select name;

        // Query execution
        foreach (var name in myLinqQuery)
            Console.WriteLine(name + " ");

    }

    public void segundoExemploLinq()
    {
        Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "Deywid", age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Raphael",  age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Claydson",  age = 25 } ,
                new Student() { StudentID = 4, StudentName = "André" , age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Johann" , age = 31 } ,
                new Student() { StudentID = 6, StudentName = "Claudio",  age = 17 } ,
                new Student() { StudentID = 7, StudentName = "Maori",age = 19  } ,
                new Student() { StudentID = 7, StudentName = "Alex",age = 19  } ,
            };

        // Use LINQ to find teenager students
        Student[] adolescentes = studentArray.Where(s => s.age > 12 && s.age < 20).ToArray();

        foreach (var adolescente in adolescentes)
            Console.WriteLine(adolescente.StudentName);

        Console.WriteLine("------------------------------");

        // Use LINQ to find first student whose name is Bill 
        Student alex = studentArray.Where(s => s.StudentName == "Alex").FirstOrDefault();
        Console.WriteLine(alex.StudentName);

        Console.WriteLine("------------------------------");

        // Use LINQ to find student whose StudentID is 5
        Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
        Console.WriteLine(student5.StudentName);
    }
}

public class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; } = "";
    public int age { get; set; }
}

