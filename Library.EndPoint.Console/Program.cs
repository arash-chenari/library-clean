using Library.Application.Categories;

public class Program
{
    public static void Main()
    {
        var menu = "1)Add Category \n 2)Get Categories";

        for (; ; )
        {
            Console.WriteLine(menu);
            var menuItem = Console.ReadLine();
            switch (menuItem)
            {
                case "1":
                    Console.WriteLine("Please enter category title");
                    var title = Console.ReadLine();
                    
                    var dto = new AddCategoryDto
                    {
                        Title = title
                    };


                    break;

                case "2":
                    Console.WriteLine();
                    break;
            }
        }
    }
}
