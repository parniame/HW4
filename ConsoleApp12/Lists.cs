namespace ConsoleApp12;

public class Lists : BaseClass {
    

    public void FilterList()
    {
        Console.WriteLine("Filtering the list");
        if (typeof(int) == TargetType)
        {
            var filteredList = IntList.Where(
                x => Math.Pow(x, 2) > 28 ||
                Math.Sqrt(x) < 4).Order().Skip(10).Take(10);
            Console.WriteLine("Filtered list second ten items: ");
            foreach (var item in filteredList)
            {
                Console.WriteLine(item);
            }
        }
        else 
        {
            var list = StringList.Where(x => x.Contains('a')   ||
                                             x.Contains('H') ||
                                             x.Contains('Q') ||
                                             x.Contains('x')).Reverse().ToList();
            
            if (list.Count > 7)
            {
                Console.WriteLine("Filtered list only last 3 items: ");
                foreach (var item in list.Skip(Math.Max(0, list.Count() - 3)))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}