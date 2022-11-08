/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car


Console.WriteLine("Hello Customer");
carshop shop = new carshop();

Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();
while (true)
{
      switch (input)
    {
        case "buy":
            List<car> cars = shop.showcars();
            Console.WriteLine("which one you want, write integer.");
        string answer = Console.ReadLine();
        int converted = Int32.Parse(answer);
        car newcar = shop.Buy(cars[converted]);
        Console.WriteLine(newcar.brand + "  and  ",newcar.color);
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
    }  
}


Console.ReadKey();

//Class definition
   
