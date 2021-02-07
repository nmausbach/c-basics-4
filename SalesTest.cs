/*  Exercise 5.19 Solution: SalesTest.cs
    Deitel, H. and Deitel, P. (2014).  Visual C# 2012, How to Program, 
	Fifth Edition.  Upper Saddle River, New Jersey: Pearson Education.
	Modifications by W. Bowers, 2014
	Additional modifications by N. Mausbach, 2021
*/

public class SalesTest
{
   public static void Main( string[] args )
   {
      MausbachHeading.getHeading("Assignment 4");
      Sales application = new Sales();
      application.CalculateSales();
      MausbachHeading.getClosing();
   } // end Main
} // end class SalesTest


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *************************************************************************/
