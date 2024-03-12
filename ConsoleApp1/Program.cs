// See https://aka.ms/new-console-template for more information
public class HelloWorld
{
    public static void Main(string[] args)
    {
       //Increment and Decrement
        Console.WriteLine("\nIncrement and Decrement");
        int value = 1;
        value = value +1;
        Console.WriteLine("First Increment:" +value);
        value +=1;
        Console.WriteLine("Second Increment:" + value);
        value++;
        Console.WriteLine("Third Increment :" + value);
        value =value -1;
        Console.WriteLine("First Decrement:" + value);
        value-=1;
        Console.WriteLine("Second Decrement:" +value);
        value--;
        Console.WriteLine("Third Decrement:" +value);
        
        //increment and Decrement order
        Console.WriteLine("\nIncrement and Decrement order");
        value =1;
        value ++;
        Console.WriteLine("First:" + value);
        Console.WriteLine("Second:" + value++);
        Console.WriteLine("Third:" + value);
        Console.WriteLine(" First:" + (++value));
        
        value =1;
        ++value;
        value ++ ;
        Console.WriteLine("First:" + value);
        
        //Converting to Celcius
        Console.WriteLine("\nConverting to celcius");
        int fahrenheit =94;
        decimal temperature = ((fahrenheit - 32) * 5m/9);
        Console.WriteLine( "The temperature is " + temperature + " degree celcius");
        
        fahrenheit =94;
        temperature = ((fahrenheit - 32m) * 5m/9m);
        Console.WriteLine( "The temperature is " + Math.Round(temperature
         ) + " degree celcius");
        
        
        
        
        
        //Overiding
        Console.WriteLine("\nOveriding");
        Random dice = new Random();
        int roll1 =dice.Next();
        int roll2 =dice.Next(101);
        int roll3 = dice.Next(50,101);
        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        
        
        //dice if else
        Console.WriteLine("\nDice if else");
        roll1 = dice.Next(1,7);
        roll2 = dice.Next(1,7);
        roll3 = dice.Next(1,7);
        int total =roll1+roll2+roll3;
        
        Console.WriteLine($"Dice roll: {roll1} +{roll2} + {roll3}");
        
        if ((roll1==roll2) && (roll2==roll3))
        
        {
            Console.WriteLine("You rolled tripples! +6 bonus to total!");
            total += 6;
        }
        else if (((roll1==roll2) || (roll2==roll3)  || (roll1==roll3)))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }
        
        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }
        
        else 
        {
            Console.WriteLine("Sorry, you lose.");
        }
        
        //Exercise: If else
        Console.WriteLine("\nIf else");
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        
        if (daysUntilExpiration== 1) 
        {
        discountPercentage=20;
        }
        if (daysUntilExpiration<= 5) 
        {
        discountPercentage=10;
        }
        if (daysUntilExpiration<1) 
        {
        Console.WriteLine("Your subscription has expired!");
        }
        
        else if (daysUntilExpiration == 1) 
        {
        Console.WriteLine("Your subscription expires within a day!");
        Console.WriteLine("Renew now and save" + discountPercentage + " %!");
        }
        else if (daysUntilExpiration<= 5) 
        {
        Console.WriteLine("Your subscription expires in:" + daysUntilExpiration + " days.");
        Console.WriteLine("Renew now and save" + discountPercentage + " %!");
        
        }
        else if (daysUntilExpiration<= 10) {
        Console.WriteLine("Your subscription expires in:" + daysUntilExpiration + " days.");
        
        Console.WriteLine ("Your subscription will expire soon. Renew now!");}
        
        //Additional if statement
        Console.WriteLine("\nAdditional if else statement");
        int age;
        Console.WriteLine("Enter your age");
        string input= Console.ReadLine();
        int.TryParse(input, out age);
        if(age<18){
            Console.WriteLine("You are a child");
        }
        else{
            Console.WriteLine("You are an adult");
        }
        
        

    }
}
