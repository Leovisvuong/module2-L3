// variable declaration
const double Pi = 3.14159;
int num = 5;
int num1 = 10;
int num2 = 5;
int num3 = 30;
double celsius = 20;
double length = 10;
double width = 5;
double radius = 5;
double principal = 1000;
double rate = 0.05; 
int time = 5;
double a = 1, b = 5, c = 6;
double x1 = 0, x2 = 0;
int n = 8;
int firstTerm = 3; 
int commonDifference = 2;
int termNumber = 5;

// initializing function
double power(double inputValue, int times){
    double returnValue = inputValue;
    for( int i = 1; i < times; i++){
        returnValue *= inputValue;
    }
    return returnValue;
}

void solveQuaraticEquation(double a, double b, double c){
    double delta = power(b, 2) - 4 * a * c;
    switch(delta){
        case < 0:
            x1 = 0;
            x2 = 0;
            break;
        case 0:
            x1 = x2 = (-b) / (2 * a);
            break;
        case > 0:
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            break;
    }
}

int isGreater(int inputNumber1, int inputNumber2){
    if(inputNumber1 > inputNumber2) return inputNumber1;
    return inputNumber2;
}

// part 1
int add = num1 + num2;
Console.WriteLine(add + "\n");

// part 2
int subtract = num1 - num2;
Console.WriteLine(subtract + "\n");

// part 3
int multiply = num1 * num2;
Console.WriteLine(multiply + "\n");

// part 4
double divide = num1 / num2;
Console.WriteLine(divide + "\n");

// part 5
int remainder = num1 % num2;
Console.WriteLine(remainder + "\n");

// part 6
int multiplyItself = num * num;
Console.WriteLine(multiply + "\n");

// part 7
double average2Numbers = (num1 + num2) / 2;
Console.WriteLine(average2Numbers + "\n");

// part 8
double average3Numbers = (num1 + num2 + num3) / 3;
Console.WriteLine(average3Numbers + "\n");

// part 9
double fahrenheit = (celsius * 9/5) + 32;
Console.WriteLine(fahrenheit + "\n");

// part 10
double areaOfRectangle = length * width;
Console.WriteLine(areaOfRectangle + "\n");

// part 11
double volumeOfSphere = (4/3) * Pi * power(radius, 3);
Console.WriteLine(volumeOfSphere + "\n");

// part 12
int factorial = 1;
for( int i = 2; i <= num; i++){
    factorial *= i;
}
Console.WriteLine(factorial + "\n");

// part 13
double compoundInterest = principal * power(1 + rate, time);
Console.WriteLine(compoundInterest + "\n");

// part 14
solveQuaraticEquation(a , b, c);
Console.WriteLine("x1=" + x1 + "\nx2=" + x2 + "\n");

// part 15
long[] fibonacci = {1,1};
for( int i = 3; i <= n; i++){
    long note = fibonacci[1];
    fibonacci[1] += fibonacci[0];
    fibonacci[0] = note;
}
Console.WriteLine(fibonacci[1] + "\n");

// part 16
int nthTerm = firstTerm + (termNumber - 1) * commonDifference;
Console.WriteLine(nthTerm + "\n");

// part 17
Console.WriteLine(isGreater(num1, num2));

// part 18
Console.Write("\nEnter a number: ");
int InputNum = int.Parse(Console.ReadLine());
if(InputNum <= 100) Console.WriteLine("YES");
else Console.WriteLine("NO");

// part 19
Console.Write("\nEnter a number: ");
InputNum = int.Parse(Console.ReadLine());
if(InputNum%2 == 0 && InputNum > 10) Console.WriteLine("YES");
else Console.WriteLine("NO");

// part 20
Console.Write("\nEnter a number: ");
InputNum = int.Parse(Console.ReadLine());
if(InputNum%3 == 0 || InputNum%5 == 0) Console.WriteLine("YES");
else Console.WriteLine("NO");

// part 21
Console.Write("\nEnter a number: ");
InputNum = int.Parse(Console.ReadLine());
Console.WriteLine(InputNum += 5);

// part 22
Console.Write("\nEnter a number: ");
InputNum = int.Parse(Console.ReadLine());
Console.WriteLine(InputNum %= 7);