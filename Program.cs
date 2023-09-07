using System;

// IMPORTANT: uncomment which method you'd like to run before running the program
//AlphabetPyramid();
//IntegerMath();


void AlphabetPyramid()
{
    // Alphabet Pyramid variables
    string pyramidRow1 = "    A";
    string pyramidRow2 = "   BCD";
    string pyramidRow3 = "  EFGHI";
    string pyramidRow4 = " JKLMNOP";
    string pyramidRow5 = "QRSTUVWXYZ";

    // Alphabet Pyramid with 5 output statements
    Console.WriteLine(pyramidRow1);
    Console.WriteLine(pyramidRow2);
    Console.WriteLine(pyramidRow3);
    Console.WriteLine(pyramidRow4);
    Console.WriteLine(pyramidRow5);

    // Alphabet Pyramid with 1 output statement
    Console.WriteLine(pyramidRow1 +"\n" + pyramidRow2 +"\n" + pyramidRow3 +"\n" + pyramidRow4 +"\n" + pyramidRow5);
}

void IntegerMath()
{
    // user inputs integers
    Console.Write("Enter first integer: ");
    string firstIntegerString = Console.ReadLine();
    Console.Write("Enter second integer: ");
    string secondIntegerString = Console.ReadLine();

    // sum, difference, product, and quotient of integers are found and set to vars
    int firstInteger = int.Parse(firstIntegerString);
    int secondInteger = int.Parse(secondIntegerString);

    int integerSum = firstInteger + secondInteger;
    int integerDifference = firstInteger - secondInteger;
    int integerProduct = firstInteger * secondInteger;
    int integerQuotient = firstInteger / secondInteger;

    // output
    string sumString = $"Sum is ...........{integerSum}";
    string differenceString = $"Difference is ....{integerDifference}";
    string productString = $"Product is .......{integerProduct}";
    string quotientString = $"Quotient is ......{integerQuotient}";

    Console.WriteLine("\n" + sumString + "\n" + differenceString + "\n" + productString + "\n" + quotientString);
}