using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp12;

public class BaseClass
{
    protected Type TargetType {  get; private set; }
    
    protected List<string> StringList { get; private set; }
    protected List<int> IntList { get; private set; }


    
    public void GetData(Type targetType)
    {
        TargetType = targetType;
        if (TargetType == typeof(string))
        {
            StringList = new List<string>();
        }
        else if (TargetType == typeof(int))
        {
            IntList = new List<int>();
        }
        try
        {
            Console.Write("insert a data in your choosen datatype :");
            var inputData = Console.ReadLine();
            validation(inputData, TargetType);
            // insert first data
            if (typeof(int) == TargetType)
            {
                IntList.Add(Convert.ToInt32(inputData));
            }
            else
            {
                StringList.Add(inputData);
            }




        }
        catch (Exception exception)
        {

            Console.WriteLine(exception.Message);
            GetData(targetType);

        }
        
    }

    public void CreatList()
    {
        Console.WriteLine("Creating the list");
        var random = new Random();
        if (typeof(int) == TargetType)
        {
            
            var list = new List<int>();
            //skip first item
            for (int i = 1; i < 100; i++)
            {
                list.Add(random.Next(0,1000));
            }
            IntList.AddRange(list);
            
        }
        else
        {
            var list = new List<string>();
            //skip first item
            for (int i = 1; i < 100; i++)
            {
                String str = "";
                var length = random.Next(3, 9);
                for (int j = 0; j < length; j++)
                {

                    var capilatOrNot = random.Next(2) == 0 ? 65 : 97;
                    var character = Convert.ToChar(random.Next(0, 26) + capilatOrNot);
                    str += character.ToString();
                }
                list.Add(str);
            }  

            StringList.AddRange(list);
            
            

        }
    }

    private void validation(string data, Type targetType)
    {       

        bool isNummeric = int.TryParse(data, out _);

        if ((targetType == typeof(string) && isNummeric) ||
            (targetType == typeof(int) && !isNummeric))
        {
            throw new Exception("Data type is invalid!");
        }
    }


}