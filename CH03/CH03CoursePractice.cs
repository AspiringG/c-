using System;
using System.Security.Cryptography.X509Certificates;

namespace Ch03
{
    class Ch03
    {
        static void Main(String[] args)
        {
            // Addition operation
            double a = 11;
            double b = 3; 
            Console.WriteLine(a + b);
            
            // Subtraction
            Console.WriteLine((double)(b - a));
            
            // Multiplication 
            Console.WriteLine(a * b);
            
            // Division 
            Console.WriteLine(a /b);
            

            //Modulus
            Console.WriteLine("Modulo operation");
            double total = a % b;
            Console.WriteLine(total);


            //Relational Operators
            int age = 18;
            bool above18 = age >= 18;

            // Age verification check.
            

            // Ecommerce app simulation
            int quantity = 19;
            int totalPoints = 200; 
            bool freeShipping = (quantity >= 15) && (totalPoints == 200);
            

            // Logical OR mainly used for combining Boolean expressions and game logic
            int playerPoints = 200;
            int OpponentPoints = 0;
            
            if(playerPoints >= 200 || OpponentPoints == 0)
            {
                Console.WriteLine($"Player wins because {playerPoints} is above 200 or the {OpponentPoints} is equal to 0");
            }

            // Logical NOT
            bool isOpen = true;
            bool goInside = !isOpen;
            bool hasPermission = true;

            bool deniedAccess = !hasPermission;


            // Combining Relational and Logical Operators
            int age = 32;
            bool inAgeRange = (age >= 18) && (age <= 30);

            // this makes our code difficult to read when combining these operators


            // Bitwise Operators allow us to manipulate the individual bits of integral data types.
            // Such as int, long, byte, short etc.

            // Bitwise Operator & - AND 
            // Bitwise Operator | - OR
            // Bitwise Operator ^ - XOR 
            // Bitwise Operator ~ - NOT 
            // Bitwise Operator << - Left Shift  
            // Bitwise Operator >> - Right Shift 


            // Bitwise AND compares each two bits of two integers and returns a new integer
            // The returned value is a bit set to 1 if the corresponding bits in both operands are also 1.
            // Otherwise it returns 0.

            // Why do we care about them anyway.
            // Example we have a:
            int randInt = 5;
            int permissions = 5;
            int executeMask = 4;

            bool canExecute = (permissions & executeMask) != 0;
            //Useful for permissions, settings, flags, networking, hardware, encryption, compression, game dev, graphics/colors
            // instead of storing 
            bool canRead = true;
            bool canWrite = true;
            bool canExecute = false;

            // We can store it all in one number
            int storePerms = 5;
            // And use bits to manipulate the permission based on its bit number


            // A mask is a predefined binary pattern that has its specific bits set to 1.
            // We can use the AND operator between a value and a mask to filter the unwanted bits (those not set to 1)



            //BITWISE OR
            // Returns a bit as 1 if at least one of the corresponding bits in the operands is 1.
            // Example 0101 | 0011 evaluates to 0111 so the result is set to 7.
            int resulting = 5 | 3;
            Console.WriteLine(resulting);


            //BITWISE XOR The bitwise exclusive OR operator represented with ^, returns 1 for a bit position
            // if the corresponding bits in the operands are not the same. SO 
            // it returns 1 if one operand has 1 and the other has 0 at that bit position.
            // In the following case, 0101 ^ 0011 evaluates to 0110 = 6
            resulting = 5 ^ 3;

            // Commonly used for parity checks and toggling operations

            //BITWISE NOT inverts the bits of its operands.
            resulting = ~5;
            
            Console.WriteLine(resulting);
            

            //Bitwise shift left and shift Right
            resulting << 3; //Left shift operation, from the right side of a the binary representation we insert 0's
            // 0001000 is gonna be 10000000 so if resulting is 8 we take 8 * 2^3 = 64. Each time multiplying the number by 2

            // Bitwise shift Right
            // Does the opposite shifting from the left side, and preserves the signed bit which is the leftmost part
            // if the number is signed -> arithmetic shift

            // if the number is unsigned it becomes a logical shift where each shift to the right 
            // divides the number by2


                // Code that implements bitwise operators can be difficult to read and
                // maintain. If you do implement these operators, the best practices listed
                // below should be observed:
                // Thoroughly document the sections of code that use bitwise operators.
                // Using self-describing names for constants.
                // Encapsulate complex bitwise code in methods (more on methods in
                // Chapter 5, Methods and Parameters). 


            //Compound Assignment Operator 
            // We made use of the assignment operator but compound assignment operators combine assignment with 
            // an additional operation

            // Variable = value
            int newQuantity = 319; // Value must be compatible type otherwise compiler will issue an error.
            // Previous value will be overwritten when using "="

            // We may also use chaining to set all variables to the same value.
            int maxSpeed, currentSpeed, defaultSpeed; 
            maxSpeed = currentSpeed = defaultSpeed = 55;

            //Compound Assignment Operation
            // This operation combines both assignment and another operation on the same variable

            int pencilQuantity = 12;
            pencilQuantity += 100; //updated and assigned the var pencilQuantity using += opeartor

            // add+= a = a + b
            // sub-= a = a - b
            // mul*= a = a * b
            // div/= a = a / b
            // mod%= a = a % b

            // Use case
            int balance = 2000;
            balance -= 300;

            double amountDue = 500;
            double taxMultiplier = 1.0975;
            amountDue *= taxMultiplier;     // 548.75

            // Add sales tax to a purchase 500 * 1.0975 and insta updates it
            int m = 10;
            double n = 3.5;

            m += (int)n;
            // make sure that they are type compatible during assignment, hence 
            // we used the explicit cast since we want to add and assign int to double

            // Use compound assignment operators to improve code clarity.
            // Use compound assignment operators to reduce code repetition.
            // Be mindful of working with mixed data types and explicitly cast when
            // necessary.
            // Avoid excessive chaining of compound assignments because this can
            // make your code less readable

            //Conditional Ternary Operator
            // allows us to write conditional logic on a single line of code. It is 
            // a type of a shprtcut for simple if else statements and is ideally suited
            // for selecting between two values based on a Boolean condition.

            // Conditional operator is refferred to as ternary because it operates on three
            // operands and is the only ternary operator in C#.

            // Syntax: condition ? expression_if_true : expression_if_false;
            // Condition is a Boolean expression that evaluates to true or false. If the condition is true,
            // The operator returns the value of the expression_if_true, false means returns the expression of expression_is_false

            int personAge = 24;
            string result = (personAge >= 18) ? "Can Vote" : "Can't Vote, must be at least 18";
            // The expressions returned must be type compatible
            bool isElite = true;
            string label = isElite ? "Elite Member" : "Not Elite, Zigan poor";
            

            // Example 2:
            var result = isElite ? "Yes" : 0;

            // We should take advantage of ternary operator for simple condition 
            // scenarios where a value must be chosen between two.
            
            // Common Use Cases:

            // Default value assignment
            string username = "";
            string displayName = username == "" ? displayName = "Guest" : username;

            Console.WriteLine(displayName);

            // Simplifying short conditions
            // Pass or fail
            int grade = 75;
            string Passed = grade >= 60 ? "Passed" : "Failed";

            Console.WriteLine(Passed);
            // Displaying content based on a flag 
            bool isLoggedIn = false;

            string Message = isLoggedIn == true ? "Welcome Back" : "Please Log in"; 

            Console.WriteLine(Message); 
            // Configuration Logic
            bool isLoggedIn = false;

            string message = isLoggedIn ? "Welcome back!" : "Please log in.";

            Console.WriteLine(message);
            // When Implementing Best Practices:

            // * Only use the ternary operator for simple conditional assignments.
            // * Avoid the nested ternary expressions because they reduce readability
            // * Ensure that both result expressions are compatible types.
            // * Liberally use parantheses for code clarity.

            

            // Best Practices with Expressions
            // You will most certainly use expressions in your C# code. When you do, you
            // should take a purposeful approach and adhere to the following best
            // practices:
            // Avoid overly complex expressions.
            // Ensure that expressions are clearly written so they are readable.
            // Double-check the expressions logic.
            // Ensure the expressions are logical and free from unintended side
            // effects.
            // Use self-describing variable names even to hold intermediate values.
            // Use parentheses to clarify order of operations. Do this even when it is
            // not required.
            // Document expressions.
            // As we have said, expressions are a core part of C# programming. We use
            // them to perform calculations, control the flow of our applications, and
            // more.
            


            
        }
    }
}