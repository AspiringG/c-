using System;

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
//              ReturnType is the value the method returns. For exmaple it might return a shipping price, indiciate double
//                         void would be used to a indicate we don't want the method returning a value.
//              Parameterlist is where we provide inputs to the method. This is a comma separated list of input values.
//                            Not all methods require inputs, all methods require brackets.
//              The Method's code block is placed inside the curly brackets.
//              The return statement is used when a method needs to return a value as the result of the code block's operation.
//                            Not all methods return values.


        }
//                                                    Methods with One parameter 

                    static double CalculateTotal(double orderCost)
                    {
                        double shippingFee = 7.45;
                        double total = orderCost + shippingFee;
                        return total;
                    }                
    }
}