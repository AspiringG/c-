using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace CH05Exercises
{
    class CH05Exercises
    {
        static void Main(string[] args)
        {
            // method names
            // Exercise #1
//          Code Explanation:
//              The following logic firstly calculates the RestockCost by multiplying unitAmount by the unitPrice, specified in the program.
//              Then the program calls CalculateRestockCost() method and passes the unitPrice and unitAmount into the method. Afterwards the program calls 
//              ApplyRestockFee() method, passes the RestockCost into it. The method then returns totalRestockCost by applying the flat fee to the given RestockCost. 

//          Expected Output:
//              restockingCost = 100 * 33.90 = 3390
//              totalRestockCost = 3390 + 190.20 = 3580.20

            int unitAmount = 100;
            decimal unitPrice = 33.90m;
            decimal restockingCost = CalculateRestockCost(unitAmount, unitPrice);

            decimal totalRestockCost = ApplyRestockFee(restockingCost);

            Console.WriteLine($"Units: {unitAmount}");
            Console.WriteLine($"Unit Price: {unitPrice:C}");
            Console.WriteLine($"Restocking cost before fee: {restockingCost:C}");
            Console.WriteLine($"Restocking cost after fee: {totalRestockCost:C}");

//      Exercise #2
//      Code explanation:
//          The goal of the program is to check if the customer is eligible for a discount if purchased items are exceeding
//          example amount of 500.
//          Execution starts by the program assigning two variables purchasedItemAmount to 900 and originalItemPrice to 9000
//          Next the program calls the IsEligibleForDiscount Method and passes purchasedItemAmount variable inside of it. IsEligibleForDiscount method checks
//          eligibility for discount and returns returns true if purchasedItemAmount is at least 500, and false otherwise. If the purchasedItemAmount exceeds 500, false otherwise. 
//          Next the program calls ApplyDiscount method that takes in two parameters: isEligibleForDiscount and originalItemPrice, 
//          and based on the isEligibleForDiscount flag being true, it will apply a discount of 10% and return the discountPrice. Otherwise
//          it will return the originalPrice.
//          Then the program prints to console the result original item price and the discounted one.
//      Code explanation:

            int purchasedItemAmount = 900; 
            decimal originalItemPrice = 9000m;
            bool isEligibleForDiscount = IsEligibleForDiscount(purchasedItemAmount);
            decimal discountedItemPrice = ApplyDiscount(isEligibleForDiscount, originalItemPrice);

            Console.WriteLine($"Purchased amount of items: {purchasedItemAmount}");
            Console.WriteLine($"Original price of items: {originalItemPrice:C}");
            Console.WriteLine($"Discounted Price of items: {discountedItemPrice:C}");

//          Exercise #3
            
            Console.WriteLine("Please insert the distanceMiles: ");
            decimal distanceMiles = decimal.Parse(Console.ReadLine());
            decimal ratePerMile = 20.0m;
            
            string orderType = GetOrderType(distanceMiles, ref ratePerMile);    
            switch(orderType)
            {
                case "LongDistance": 
                    decimal shippingCost = CalculateShipping();
                    Console.WriteLine($"Shipping Cost for Long Distance is: {shippingCost:C}");
                    break;
                case "MediumDistance": 
                    shippingCost = CalculateShipping(distanceMiles, ratePerMile);
                    Console.WriteLine($"Shipping Cost for Medium Distance is: {shippingCost:C}");
                    break;
                case "ShortDistance":
                    shippingCost = CalculateShipping(distanceMiles, ratePerMile);
                    Console.WriteLine($"Shipping Cost for Short Distance is: {shippingCost:C}");
                    break;
                default:
                    Console.WriteLine("No proper OrderType was selected");
                    break;
            }


//                          Exercise #4

            decimal distanceInMiles = 300.0m;
            decimal originalItemsPrice = 240.0m;
            decimal itemAmount = 11;
            decimal totalItemsPrice = itemAmount * originalItemsPrice;
            PrintReceipt(itemAmount, totalItemsPrice, distanceInMiles);
        }


        static decimal CalculateRestockCost(int unitAmount, decimal unitPrice)
        {
            decimal restockingCost = unitAmount * unitPrice;
            return restockingCost;
        }

        static decimal ApplyRestockFee(decimal restockingCost)
        {
            decimal restockFee = 190.20m;
            decimal restockFeeCost = restockingCost + restockFee;
            return restockFeeCost;
        }


        
        static bool IsEligibleForDiscount(int purchasedItemAmount)
        {
            bool isEligibleForDiscount = purchasedItemAmount >= 500;
            return isEligibleForDiscount;
        }

        static decimal ApplyDiscount(bool isEligibleForDiscount, decimal originalItemPrice)
        {
            if (!isEligibleForDiscount)
            {
                Console.WriteLine($"Not eligible for Discount");
                return originalItemPrice;
            }

            decimal discountRate = 0.10m;
            decimal discountAmount = originalItemPrice * discountRate;
            decimal discountPrice = originalItemPrice - discountAmount;
            return discountPrice;
        }

//      Exercise #3

        static decimal CalculateShipping(decimal distanceMiles, decimal ratePerMile)
        {
            decimal shippingCost = distanceMiles * ratePerMile;
            return shippingCost; 
        }
        static decimal CalculateShipping()
        {
            decimal shippingCost = 10000.0m;
            return shippingCost;
        }


        static string GetOrderType(decimal distanceMiles, ref decimal ratePerMile)
        {
            if (distanceMiles <= 500.0m && distanceMiles >= 0) 
            {
                ratePerMile = 20.0m;
                return "ShortDistance";
            }
            else if(distanceMiles > 500.0m && distanceMiles <= 1000.0m)
            {
                ratePerMile = 30.0m;
                return "MediumDistance";
            }
            else if(distanceMiles > 1000.0m)
            {
                return "LongDistance";
            }
            else
            {
                return "error";
            }
        }



//                                          #Exercise 4:

        static decimal CalculatePriceAfterTax(decimal totalItemsPrice)
        {
            decimal taxRate = 0.15m;
            decimal afterTaxAmount = totalItemsPrice * taxRate;
            decimal priceAfterTax = totalItemsPrice + afterTaxAmount;
            return priceAfterTax;
        }

        static decimal CalculateShippingCost(decimal distanceInMiles)
        {
            decimal ratePerMile = 3.05m;
            decimal shippingCost = distanceInMiles * ratePerMile;
            return shippingCost;
        }

        static decimal ApplyDiscounts(decimal totalItemsPrice, decimal itemAmount)
        {
            decimal discountRate = 0.15m;
            decimal discountAmount = totalItemsPrice * discountRate;
            decimal discountPrice = totalItemsPrice - discountAmount;
            
            if (itemAmount > 10)
            {
                return discountPrice;
            }
            else
            {
                return totalItemsPrice;
            }
        }

        static decimal CalculateTotalAmount(decimal totalItemsPrice, decimal itemAmount, decimal distanceInMiles)
        {
            decimal shippingCost = CalculateShippingCost(distanceInMiles);
            decimal discountPrice = ApplyDiscounts(totalItemsPrice, itemAmount);
            decimal taxAmount = CalculatePriceAfterTax(discountPrice);
            
            
            decimal finalPrice = shippingCost + taxAmount;
            return finalPrice;

        }

        static void PrintReceipt(decimal itemAmount, decimal totalItemsPrice, decimal distanceInMiles)
        {
            decimal totalAmountDue = CalculateTotalAmount(totalItemsPrice, itemAmount, distanceInMiles);
            decimal discountAmount = ApplyDiscounts(totalItemsPrice, itemAmount);
            decimal taxAmount = CalculatePriceAfterTax(discountAmount);
            decimal shippingCost = CalculateShippingCost(distanceInMiles);
            
            Console.WriteLine($"Thank you for your order, sir!\n Item Sub-total:\n Amount of soap: {itemAmount}x \t\t {totalItemsPrice:C}");
            Console.WriteLine($"Price After Discount: {discountAmount:C}");
            Console.WriteLine($"Shpping Cost: {shippingCost:C}");
            Console.WriteLine($"Price After Tax, VAT included: {taxAmount:C}");
            Console.WriteLine($"Total Amuont due is: {totalAmountDue}");
        }
        
    }
}