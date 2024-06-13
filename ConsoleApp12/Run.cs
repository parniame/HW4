namespace ConsoleApp12;

class Run: Lists
{
    //public Run(Type targetType) : base(targetType)
    //{
    //}
    public void   RunProgram()
    {


        Console.WriteLine("Choose your target  datatype: ");
        Console.Write(" [1]string".PadRight(50));
        Console.WriteLine(" [2]integer".PadRight(50));
        var input = Console.ReadLine();
        if (input != "1" && input != "2")
        {
            Console.WriteLine("Pleas Enter 1 or 2");
            RunProgram();
        }
        var typeOfList = Convert.ToInt32(input);
        Type type;

        if (typeOfList == 1)
        {

            type = typeof(string);



        }
        else
        {

            type = typeof(int);

        }


        GetData(type);
        CreatList();
        FilterList();
      



    }


    
}
