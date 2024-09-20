internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        string price;
        string cart;
        string lastname;
        string firstname;
        int avrage;
        string login;
        int grade;
        int studentID;
        string Name;
        int grampsage;
        
       


        Console.WriteLine("what is your name:");
        name = Console.ReadLine();
        Console.WriteLine("hi  " + name + " how old are u");
        int.TryParse(Console.ReadLine(), out age);
        Console.WriteLine("your only realy " + age);
        Console.WriteLine("how much do u make parker?");
        price = Console.ReadLine();
        Console.WriteLine("wow you are super rich makeing " + price);
        Console.ReadLine();
        Console.WriteLine("plese enter you info below thank you");
        Console.WriteLine("frist name");
        firstname = Console.ReadLine();
        Console.WriteLine("last name");
        lastname = Console.ReadLine();
        Console.WriteLine("what is your  avrage");
        int.TryParse(Console.ReadLine(), out avrage);
        Console.WriteLine("login");
        login = Console.ReadLine();
        Console.WriteLine("grade");
        Int32.TryParse(Console.ReadLine(), out grade);
        Console.WriteLine("student id");
        int.TryParse(Console.ReadLine(),out studentID);

        Console.WriteLine("firstname "+ firstname);
        Console.WriteLine("lastname " + lastname);
        Console.WriteLine("login " + login);
        Console.WriteLine("grade " + grade);
        Console.WriteLine("student ID " + studentID);    
        Console.WriteLine("avrage " + avrage);

        Console.WriteLine("hello whats your name");
        Name = Console.ReadLine();
        Console.WriteLine("why nice to meet u " + Name + " how old are you");
        int.TryParse (Console.ReadLine(), out grampsage);
        Console.WriteLine("did you know in 5 years you will be " + grampsage + 5);





        
        
        
      
    }
}