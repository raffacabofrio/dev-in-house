
// ExemploMultiplosConstrutores();
// ExemploCopy();
// ExemploConstrutorEncadeado();


var user1 = new UserStaticCtor();
var user2 = new UserStaticCtor();
var user3 = new UserStaticCtor();
var user4 = new UserStaticCtor();
var user5 = new UserStaticCtor();

Console.WriteLine("\nPress Enter Key to Exit..");
Console.ReadLine();




void ExemploMultiplosConstrutores()
{
    User user = new User();
    Console.WriteLine(user.name);
    Console.WriteLine(user.location);

    var user2 = new User("Mauro");
}

void ExemploConstrutorEncadeado()
{
    var user1 = new UserEncadeado(" a", "turma dev-in-house");
}

void ExemploCopy()
{
    var user2 = new User("Johann");
    Console.WriteLine(user2.name);
    Console.WriteLine(user2.location);


    var user3 = new User(user2);
    Console.WriteLine("Fiz uma cópia do user2. Vamos ver comon ficou:");
    Console.WriteLine(user3.name);
    Console.WriteLine(user3.location);
}


class User
{
    public string name, location;
    // Default Constructor
    public User()
    {
        name = "Suresh Dasari";
        location = "Hyderabad";
    }

    public User(string name)
    {
        this.name = name;
        location = "São Paulo";

        Console.WriteLine("Construtor com parâmetro");
    }

    public User(User user)
    {
        name = user.name;
        location = user.location;
    }
}

class UserEncadeado
{
    public UserEncadeado()
    {
        Console.Write("Olá, ");
    }
    public UserEncadeado(string a) : this()
    {
        Console.Write(a);
    }
    public UserEncadeado(string a, string b) : this("bem vindo")
    {
        Console.Write(a + " " + b);
    }
}

class UserStaticCtor
{
    // Static Constructor
    static UserStaticCtor()
    {
        Console.WriteLine("I am Static Constructor");
    }
    // Default Constructor
    public UserStaticCtor()
    {
        Console.WriteLine("I am Default Constructor");
    }
}