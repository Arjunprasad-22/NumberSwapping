Console.WriteLine("enter the first number");
int firstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("enter the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the firstnumber :" + firstNumber);
Console.WriteLine("the secondnumber :" + secondNumber);

 int temporry = firstNumber;
firstNumber= secondNumber;
secondNumber= temporry;

Console.WriteLine("the swaped number is :");

Console.WriteLine( "the firstnumber =" + firstNumber);
Console.WriteLine("the secondnumber =" + secondNumber);