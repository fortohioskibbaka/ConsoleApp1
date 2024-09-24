using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {




        //part1();
        //part2();

        //part3();
        //part4();
        part5();



    }
    public static void part1()
    {
        string name;
        int age;
        string price;




        Console.WriteLine("what is your name:");
        name = Console.ReadLine();
        Console.WriteLine("hi  " + name + " how old are u");
        int.TryParse(Console.ReadLine(), out age);
        Console.WriteLine("your only realy " + age);
        Console.WriteLine("how much do u make parker?");
        price = Console.ReadLine();
        Console.WriteLine("wow you are super rich makeing " + price);
        Console.ReadLine();





    }
    public static void part2() {
        {
            string firstname;
            string lastname;
            string login;
            int avrage;
            int studentID;
            int grade;





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
            int.TryParse(Console.ReadLine(), out studentID);








        }
    }
    public static void part3()
    {
        string Name;
        int age;


        Console.WriteLine("hello whats your name");
        Name = Console.ReadLine();
        Console.WriteLine("why nice to meet u " + Name + " how old are you");
        int.TryParse(Console.ReadLine(), out age);
        Console.WriteLine("did you know in 5 years you will be " + (age + 5)); Console.WriteLine("and 5 years ago you were " + (age - 5));



















    }
    public static void part4()
    {
        double number1;
        double number2;
        double number3;

        Console.WriteLine("please enter your three numbers");
        double.TryParse(Console.ReadLine(), out number1);
        double.TryParse(Console.ReadLine(), out number2);
        double.TryParse(Console.ReadLine(), out number3);
        Console.WriteLine("=" + (number1 + number2 + number3) / 2);

















    }
    public static void part5()
    {
        double price1;
        double price2;
        string item1;
        string item2;
        double priceD, discountedPrice;
        double subtotal;
        double taxprice;
        double total;


        Console.WriteLine("what 2 items would u like  ");
        Console.WriteLine("item 1");
        item1 =Console.ReadLine();
        Console.WriteLine("item 2");
        item2 =Console.ReadLine();


        Console.WriteLine("whats the price of item 1 ");
        double.TryParse(Console.ReadLine(), out price1);
        Console.WriteLine("whats the price of item 2 ");
        double.TryParse(Console.ReadLine(), out price2);
        subtotal = price1 + price2;

        Console.WriteLine("the total of the 2 is " + subtotal.ToString("C"));
        priceD = subtotal * 0.2;
        discountedPrice = subtotal - priceD;
        Console.WriteLine("the total with the discount is " + discountedPrice.ToString("C"));
        taxprice= (discountedPrice) * 0.13;
        total = discountedPrice + taxprice;
        Console.WriteLine("with tax the total is " + (total.ToString("C")));
        
        Console.WriteLine();



        Console.WriteLine("item 1 " + item1);
        Console.WriteLine("price $ " + price1.ToString("C"));
        Console.WriteLine("item 2 " + item2);
        Console.WriteLine("price $ " + price2.ToString("C"));
        Console.WriteLine("total $ " + subtotal.ToString("C"));
        Console.WriteLine("discount 20% $ " + priceD.ToString("C"));
        Console.WriteLine("subtotal $ " + discountedPrice.ToString("C"));
        Console.WriteLine("tax $ " + (discountedPrice) * 0.13);
        Console.WriteLine("total owed " + total.ToString("C"));  




        






















    }














}     

       