var rac = new Ractangle();

    System.Console.Write($"Enter width: ");
    rac.Width = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Enter height: ");
    rac.Height = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Enter conlor: ");
    rac.Color = Console.ReadLine();
 
System.Console.WriteLine();

System.Console.WriteLine($"Area is : {rac.GetArea()}");
System.Console.WriteLine($"Perimeter is : {rac.GetPerimeter()}");
      