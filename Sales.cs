/*  Exercise 5.19 Solution: Sales.cs
    Deitel, H. and Deitel, P. (2014).  Visual C# 2012, How to Program, 
	Fifth Edition.  Upper Saddle River, New Jersey: Pearson Education.
	Modifications by W. Bowers, 2014
	Additional modifications by N. Mausbach, 2021
*/

using System;

public class Sales
{
   // calculate sales for individual products
   public void CalculateSales()
   {
      decimal grossSales = 0; // total gross sales
      int product = 0; // the product number

      int numberSold;
      int numberSold1 = 0;
      int numberSold2 = 0;
      int numberSold3 = 0;
      int numberSold4 = 0;
      int numberSold5 = 0;
      int numberSold6 = 0;

      decimal commission1 = 0.00M;
      decimal commission2 = 0.00M;
      decimal commission3 = 0.00M;
      decimal commission4 = 0.00M;
      decimal commission5 = 0.00M;
      decimal commission6 = 0.00M;

      decimal extension1 = 0.00M;
      decimal extension2 = 0.00M;
      decimal extension3 = 0.00M;
      decimal extension4 = 0.00M;
      decimal extension5 = 0.00M;
      decimal extension6 = 0.00M;  

      decimal rate1 = 0.09M;
      decimal rate2 = 0.0925M;
      decimal rate3 = 0.0701M;
      decimal rate4 = 0.095M;
      decimal rate5 = 0.1M;
      decimal rate6 = 0.083M;

      decimal price1 = 239.99M;
      decimal price2 = 129.75M;
      decimal price3 =  99.95M;
      decimal price4 = 350.89M;
      decimal price5 = 100.00M;
      decimal price6 = 1000.00M;

      decimal earnings = 0.00M;
      decimal earnings1 = 0.00M;
      decimal earnings2 = 0.00M;
      decimal earnings3 = 0.00M;
      decimal earnings4 = 0.00M;
      decimal earnings5 = 0.00M;
      decimal earnings6 = 0.00M;

        while ( product < 6 )
      {
         ++product;

         // prompt for and read number of the product sold from user
         Console.Write( "  Enter number sold of product # {0} ->  ", product );
         numberSold = Convert.ToInt32( Console.ReadLine() );

            // determine gross of each individual product and add to total
            if (product == 1)
            {
                numberSold1 = numberSold;
                grossSales += numberSold1 * price1;
                commission1 = (price1 * numberSold1) * rate1;
                extension1 = numberSold1 * price1;
                earnings1 = (rate1 * grossSales) + 200;
                commission1 = Convert.ToDecimal(string.Format("{0:F2}", commission1));
            }  
            else if (product == 2)
            {
                numberSold2 = numberSold;
                grossSales += numberSold2 * price2;
                commission2 = (price2 * numberSold2) * rate2;
                extension2 = numberSold2 * price2;
                earnings2 = (rate2 * grossSales) + 200;
                commission2 = Convert.ToDecimal(string.Format("{0:F2}", commission2)); ;
            }
            else if (product == 3)
            {
                numberSold3 = numberSold;
                grossSales += numberSold3 * price3;
                commission3 = (price3 * numberSold3) * rate3;
                extension3 = numberSold3 * price3;
                earnings3 = (rate3 * grossSales) + 200;
                commission3 = Convert.ToDecimal(string.Format("{0:F2}", commission3));
            }
            else if (product == 4)
            {
                numberSold4 = numberSold;
                grossSales += numberSold4 * price4;
                commission4 = (price4 * numberSold4) * rate4;
                extension4 = numberSold4 * price4;
                earnings4 = (rate4 * grossSales) + 200;
                commission4 = Convert.ToDecimal(string.Format("{0:F2}", commission4));
            }
            else if (product == 5)
            {
                numberSold5 = numberSold;
                grossSales += numberSold5 * price5;
                commission5 = (price5 * numberSold5) * rate5;
                extension5 = numberSold5 * price5;
                earnings5 = (rate5 * grossSales) + 200;
                commission5 = Convert.ToDecimal(string.Format("{0:F2}", commission5));
            }
            else if (product == 6)
            {
                numberSold6 = numberSold;
                grossSales += numberSold6 * price6;
                commission6 = (price6 * numberSold6) * rate6;
                extension6 = numberSold6 * price6;
                earnings6 = (rate6 * grossSales) + 200;
                commission6 = Convert.ToDecimal(string.Format("{0:F2}", commission6));
            }
      } // end while loop

        Console.WriteLine("\n\n\t\t  Commission\t\t Price\t\t\t  Comm");
        Console.WriteLine("  Sales Summary\t    Earnings\tSold\t  Each\t  Extension\t  Rate");
        Console.WriteLine("  -------------\t  ----------\t----\t -----\t  ---------\t  ----");
        Console.WriteLine("  Base Pay\t     $250.00");
        Console.WriteLine("  Product 1\t{0,12:n}\t{1,3}    {2,5:c}\t{3,11:c}\t 9.00%", commission1, numberSold1, price1, extension1);
        Console.WriteLine("  Product 2\t{0,12:n}\t{1,3}\t{2,5:n}\t{3,11:n}\t 9.25%", commission2, numberSold2, price2, extension2);
        Console.WriteLine("  Product 3\t{0,12:n}\t{1,3}\t{2,6:n}\t{3,11:n}\t 7.01%", commission3, numberSold3, price3, extension3);
        Console.WriteLine("  Product 4\t{0,12:n}\t{1,3}\t{2,6:n}\t{3,11:n}\t 9.50%", commission4, numberSold4, price4, extension4);
        Console.WriteLine("  Product 5\t{0,12:n}\t{1,3}\t{2,6:n}\t{3,11:n}\t10.00%", commission5, numberSold5, price5, extension5);
        Console.WriteLine("  Product 6\t{0,12:n}\t{1,3}   {2,6:n}\t{3,11:n}\t 8.30%", commission6, numberSold6, price6, extension6);
        earnings = commission1 + commission2 + commission3 + commission4 + commission5 + commission6 + 250;
        Console.WriteLine("\n  Total Earnings{0,12:c}", earnings);
        Console.WriteLine("\t\t  ==========");
    } // end Main
} // end class Sales


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *************************************************************************/
