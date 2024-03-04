﻿namespace DotNetInterns;

class Program
{
    static void Main(string[] args)
    {
         int a;
            System.Console.WriteLine("List of tasks");
            System.Console.WriteLine("1.Equal or not");
            System.Console.WriteLine("2.Sign check");
            System.Console.WriteLine("3.Weekday");
            System.Console.WriteLine("4.sum of digits");
            System.Console.WriteLine("5.Fibonacci");
            System.Console.WriteLine("6.Prime number");
            System.Console.WriteLine("7.Factorial");
            System.Console.WriteLine("8.Armstrong Number");
            System.Console.WriteLine("9.Reverse character");
            System.Console.WriteLine("10.Pattern");
            System.Console.WriteLine("11.Login 3 trys");
            System.Console.WriteLine("12.Marks");
            System.Console.WriteLine("13.Structure Example");
            System.Console.WriteLine("14.Enum Example");
            System.Console.WriteLine("15.ArrayList example");
            System.Console.WriteLine("16.Excetion Handeling");
            System.Console.WriteLine("17.Hashtable");
            System.Console.WriteLine("18.lambda expression example");
            System.Console.WriteLine("19.User defined exception example");
            System.Console.WriteLine("20.Event example");
            System.Console.WriteLine("21.Exit");
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Enter a task number to perform");
            a = Convert.ToInt32(Console.ReadLine());
            try
            {
                
                switch (a)
                {
                    case 1:
                    EqualOrNot eq1 = new EqualOrNot();
                    eq1.Equal();
                    break;
                    case 2:
                    SignCheck s1 = new SignCheck();
                    s1.sign();
                    break;
                    case 3:
                    WeekDay wd1 = new WeekDay();
                    wd1.weekday();
                    break;
                    case 4:
                    SumOfDigits sd = new SumOfDigits();
                    sd.sumofdigits();
                    break;
                    case 5:
                    Fibonacci f1 = new Fibonacci();
                    f1.fibonacci();
                    break;
                    case 6:
                    Prime p1 = new Prime();
                    p1.prime();
                    break;
                    case 7:
                    Factorial fact1 = new Factorial();
                    fact1.factorial();
                    break;
                    case 8:
                    Armstrong arm1 = new Armstrong();
                    arm1.armstrong();
                    break;
                    case 9:
                    RevOrder rev1 = new RevOrder();
                    rev1.revchar();
                    break;
                    case 10:
                    Pattern pat1 = new Pattern();
                    pat1.printPattern();
                    break;
                    case 11:
                    UserLogin ulog1 = new UserLogin();
                    ulog1.userAuth();
                    break;
                    case 12:
                    Marks m1 = new Marks();
                    m1.markCal();
                    break;
                    case 13:
                    test1 t1 = new test1();
                    t1.test();
                    break;
                    case 14:
                    EnumEx en1 = new EnumEx();
                    en1.EnumExampele();
                    break;
                    case 15:
                    Arraylist al2 = new Arraylist();
                    al2.arraylistex();
                    break;
                    case 16:
                    ExceptionHandeling e1 = new ExceptionHandeling();
                    e1.DivisionNumbers();
                    e1.div(20,0);
                    break;
                    case 17:
                    Hashtableex htex1 = new Hashtableex();
                    htex1.htex();
                    break;
                    case 18:
                    Lambda lamb = new Lambda();
                    lamb.lambda();
                    break;
                    case 19:
                    Tempr temp1 = new Tempr();
                    try
                    {
                        temp1.showTemp();
                    }
                    catch (TempIsZeroException e)
                    {
                        System.Console.WriteLine("TempIsZeroException: {0}",e.Message);
                    }
                    break;
                    case 20:
                    Worker work=new Worker();
                    work.WorkPerformed+=(sender,e)=>{
                        System.Console.WriteLine($"{e.Hour}'s {e.WorkType} complete");
                    };
                    work.WorkComplete+=(sender,e)=>{
                        System.Console.WriteLine($"work fully completed");
                    };
                    work.DoWork(5,"intern ka kam");
                    break;
                    case 21:
                    break;
                    default:
                    System.Console.WriteLine("Looks like you have entered a wrong number!!");
                    break;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("An exception is occured : {0}",e.Message);
            }
            finally
            {
                System.Console.WriteLine("End of the program.");
            }
    }
}
