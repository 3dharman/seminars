// Printing a number from -N to N using the terminal //

Console.WriteLine("Enter the number");
int number = Convert.ToInt32( Console.ReadLine());

if (number > 0)
    number *= -1; // number = number * (-1)

int endNumber = number * -1;

while (number <= endNumber) {
    Console.Write(number);

    if (number < endNumber)
        Console.Write(", ");
    
    number++;
}