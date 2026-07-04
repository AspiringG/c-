using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Chapter_5
{
    class CH05
    {
        static void Main(string[] args)
        {
//                                 Defining and Calling Methods
//             
//              In our application we will be using our aborist store as example
//              Goal: Calculate shipping costs for each order to determine if a discount
//                    can be applied.
//
//              Method: A method is a named block of code that performs a finite task
//              and can be used whenever needed.

//              Method Structure:
//              static ReturnType MethodName(ParameterList)
//              {
//                  // Code Block
//                  return value;
//              }


//              The keyword static means that the method is a class method 
//             1. ReturnType is the value the method returns. For exmaple it might return a shipping price, indicate double;
//                         indicate void would be used to a indicate we don't want the method returning a value.
//             2. Parameterlist is where we provide inputs to the method. This is a comma separated list of input values.
//                            Not all methods require inputs, all methods require brackets.
//             3. The Method's code block is placed inside the curly brackets.
//             4. The return statement is used when a method needs to return a value as the result of the code block's operation.
//                            Not all methods return values.


        


//                                                      Main Code
//      static void Main(string[] args) 
//      {    
                    string customerName = Console.ReadLine();
                    DisplayThankYou(customerName);

                    double orderCost = 100.00;
                    double totalPrice = CalculateTotal(orderCost); 
                    Console.WriteLine($"Total cost is: {totalPrice}");

                    double discountRate = 0.10;
                    double finalPrice = ApplyDiscount(orderCost, discountRate);
                    Console.WriteLine($"Final Price after Discount is: {finalPrice}");

//                  Calculate shipping calculates cost of shipping by multiplying its distance by 1.25 and returning final ShipmentCost:
                    double distance = 12.0;
                    double shippingCost = CalculateShipmentFee(distance);
                    Console.WriteLine($"Shipping cost is: {shippingCost}");

//                  Calculate taxAmount:
                    double taxRate = 14.98;
                    double taxAmount = CalculateTaxAmount(orderCost, taxRate);
                    Console.WriteLine($"Price After Tax is: {taxAmount}");
                    
                    // Calculate the total amount of orderCost, ShippingFee, and taxRate.
                    double totalProductCost = CalculateTotalAmount(orderCost, taxAmount, shippingCost);
                    Console.WriteLine($"Final price after shipping and tax is {totalProductCost}");


                    // Check whether the user is eligible for a discount or not?
                    double orderTotal = 85.00;
                    bool eligible = IsEligibleForDiscount(orderTotal);
                    Console.WriteLine($"Eligible for Discount?: {eligible}");

                    // Print a message by calling a method
                    PrintConfirmation();


                    // AddFive - Pass by Value method 
                    int number = 10;
                    AddFive(number);
                    
                    Console.WriteLine("After method: " + number);
//                  
//                  We pass in the copy of the variable not the variable itself, hence we don't change its value from 10 to 15 even after we run the method AddFive.

//                  If we wanna change the actual variable when passing it to the method we should pass it as a reference, so that the memory location of the original value is accessed instead of a copy.
//                  static void AddFive(ref double number); - When we call that function we also need to pass the variable using the ref keyword.
//                  static void AddFive(ref double number)  - When defining the methdod, also use ref keyword.
//                  {
//                      number += 3.50; 
//                  }

                    newFunction(100, 90.12);
                    newFunction(110.0, 13);
                    
        }
   
//                                          -----------Main Code ends here----------


//                                                    Methods with One parameter 
//
//                  We call this method from Main class. We path in orderCost, so the method can perform its calculation
//                  Code Explanation: 
//                         CalculateTotal method takes in one parameter: orderCost, and returns
//                         total amount by adding shipping fee to the orderCost.
//                  Expected Result:
//                         double total = 7.45 + 10.00 
//                         return 17.45
                    
                    static double CalculateTotal(double orderCost)
                    {
                        double shippingFee = 7.45;
                        double total = orderCost + shippingFee;
                        return total;
                    }      
        


//                                              Methods that take no Params                    
                    
                    static void DisplayThankYou(string customerName)
                    {
                        Console.WriteLine($"Thank you for buying our Product, {customerName}");
                    }


//                                              Methods with Multiple Parameters
//  
//                  Code example:
//                      static method ApplyDiscount takes in two parameters originalPrice and discountRate, 
//                      to calculate and return the finalPrice, we first find discount price by multiplying originalPrice by discountRate.
//                      store that in discountAmount, and then subtract the final price from the discountPrice
//                  
//                  Expected Result
//                      When the function is called with originalPrice = 100, discountRate = 0.10
//                      discountAmount = 100 * 0.10 = 10
//                      finalPrice = 100 - 10 = 90
//                      return 90
//                  
//                  Code example:
                    static double ApplyDiscount(double originalPrice, double discountRate)
                    {
                        double discountAmount = originalPrice * discountRate;
                        double finalPrice = originalPrice - discountAmount;
                        return finalPrice;
                    }



//                                                  Parameters and return types
                    
//                  Parameters are values that a method requires to execute its code block.
//                  
//                  When we call methods, we supply the actual values to use. These values are referred to as arguments
//                  Let us look at an example where we want to calculate the shipping fee
//                  based on delivery distance.

                    static double CalculateShipmentFee(double miles)
                    {
                        double ratePerMile = 1.25;
                        double shipping = miles * ratePerMile;
                        return shipping;
                    }
                      
//                                                   Multiple Parameters    

                    static double CalculateTotalAmount(double orderCost, double taxRate, double shippingFee)
                    {
                        double taxAmount = orderCost * (taxRate / 100);
                        double FinalAmount = taxAmount + shippingFee + orderCost;
                        return FinalAmount;
                    }

                    static double CalculateTaxAmount(double orderCost, double taxRate)
                    {
                        double finalTaxAmount = orderCost * (taxRate / 100);
                        return finalTaxAmount;
                    }



//                                                  Return Types

                    // static bool IsEligibleForDiscount(double totalProductCost)
                    // {
                    //     if(totalProductCost >= 120) return true;
                    //     else return false;
                    // }      

                    // Better way to write the above method is:
                    static bool IsEligibleForDiscount(double orderTotal)
                    {
                        return orderTotal >= 100;
                    }        

//                                                 Method that returns Nothing

        
        static void PrintConfirmation()
        {
        Console.WriteLine("Order confirmed. Thank you for shopping with Tree Limb!");
        }


//                                                 Pass by value
//
//          In the example below, the AddFive method is passed the value of number.
            static void AddFive(int number)
            {
                number += 5;
                Console.WriteLine("Inside method " + number);

            }







//                                                  Method Overloading

//              Method Overloading happens when the same name for the method is used, with different amount of parameters or different types
//              Example:
                static void newFunction(double orderCost, int age)
                {
                    Console.WriteLine("newFunction#1");
                }
                static void newFunction(int age, double orderCost)
                {
                    Console.WriteLine("newFunction#2");
                }
                static void newFunction()
                {
                    Console.WriteLine("newFunction#2");
                }



//                                                 Modular design is an efficient way to structure modern software systems.
//                              Each method should have a singular and clear task. When properly
//                              implemented, the main method becomes a pseudo process flow method
    }
}