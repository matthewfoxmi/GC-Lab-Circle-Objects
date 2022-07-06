using GC_Lab_Circle_Objects;

double radius = 0;
string area = "";
string circumference = "";

bool goAgain = true;
int circleCount = 0;

Console.WriteLine("welcome to the circle tester");

//Test for valid input from user
while (goAgain)
{
    while (true)
    {       
    try
        {
            Console.WriteLine("enter a radius");
            radius = double.Parse(Console.ReadLine());
            if (radius < 0)
            {
                throw new Exception("The radius has to be positive.");
            }
            else
            {
                break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            continue;
        }
    }

    //increment circle count if a valid number was entered
    circleCount++;

    //calculations

    Circle myCircle = new Circle(radius);

    area = myCircle.CalculateFormattedArea();
    circumference = myCircle.CalculateFormattedCircumference();

    Console.WriteLine($"Area: {area}\nCircumference: {circumference}");
    
    //continue loop    

    while (true)
    {
        Console.WriteLine("Would you like to continue? Enter y/n");
        string input = Console.ReadLine().ToLower().Trim();

        if (input == "n")
        {   //end program
            Console.WriteLine("Goodbye!");
            Console.WriteLine($"Number of circles calculated: {circleCount}");
            goAgain = false;
            break;
        }
        else if (input == "y")
        {
            //loop to beginning
            break;
        }
        else
        {   //ask user to enter y/n
            Console.WriteLine("Enter y/n");
            
        }
    }
}





