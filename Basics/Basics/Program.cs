using System;

namespace Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            //Console.WriteLine(sample1);
            //Console.WriteLine(sample2);
            //Console.WriteLine(heartRate);
            //Console.WriteLine(deposits);
            //Console.WriteLine(acceleration);
            //Console.WriteLine(mass);
            //Console.WriteLine(distance);
            //Console.WriteLine(lost);
            //Console.WriteLine(expensive);
            //Console.WriteLine(choice);
            //Console.WriteLine(integral);
            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            /* Compare sample1 to sample2 and if they are equal display “The samples are equal.” 
             * otherwise display “The samples are not equal.”
             */
            if(sample1 == sample2){
                Console.WriteLine("The samples are equal.");
            }
            else{
                Console.WriteLine("The samples are not equal.");
            }

            /* If heartRate is greater than equal to 40 and less than equal to 80 display “Heart rate is normal.” 
             * otherwise display “Heart rate is not normal.”
             */
            if(40 <= heartRate && heartRate <= 80){
                Console.WriteLine("Heart rate is normal.");
            }
            else{
                Console.WriteLine("Heart rate is not normal.");
            }

            /* If deposits is greater than or equal to 100000000 display “You are exceedingly wealthy.”
             * otherwise display “Sorry you are so poor.”
             */
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            /* Declare a variable called force that is assigned to the mass times the acceleration. 
             * The force variable must be of the same type as the type that results from the multiplication of mass 
             * and acceleration.
             */
            float force = mass * acceleration;
          
            /* Display the calculated force preceded by the string “force = ”. The output should look like the following 
             * (actual value will be different): force = 2.345
             */
            Console.WriteLine("force = " + force);

            /* Display the value of distance followed by “ is the distance.”
             */
            Console.WriteLine(distance + " is the distance.");

            /* Using lost and expensive display “I am really sorry! I will get the manager.” if lost and expensive are both 
             * true and “Here is coupon for 10% off.” if lost is true and expensive is false.
             */
            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if(lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }

            /* Use switch/case and the variable choice to display “You chose 1.” if choice is 1, “You chose 2.” if choice is 2, 
             * “You chose 3.” if choice is 3, and “You made an unknown choice.” if choice is something other than 1, 2, or 3.
             */
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            /* Using the character constant integral, display the character in integral followed by 
             * the string “ is an integral.”
             */
            Console.WriteLine(integral + " is an integral");

            /* Using a “for” loop count from 5 to 10 (inclusive of start and end) using an integer variable i. Inside the 
             * loop display each value of i with a line that is “i = ” followed by the value of i as in:
                i=5
                i=6
                i=7
                i=8
                i=9
                i=10
            */
            int i = 0;
            for (i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }

            /* Declare an integer variable age with an initial value of 0. Using a “while” loop that continues while age is 
             * less than 6 display the value of age in a line that begins with “age = ” and is followed by the value of age. 
             * (Example: age = 3) After the age line is displayed increment the value of age by 1.
             */
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }

            /* Display a line that contains the greeting string followed by a space followed by the name string.
             */
            Console.WriteLine(greeting + " " + name);

        }
    }
}
