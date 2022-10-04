// See https://aka.ms/new-console-template for more information
using HelloWorldTutorial;
using System.Text;

var testVar = "noob";

Console.WriteLine(testVar);

double a = 3141.6;


Console.WriteLine("YOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");


//int b = a; não funciona, missing a cast

//EXPLÍCITO
int b = (int)a; // já funciona porque faz a conversão primeiro

int c = 123;

//IMPLÍCITO
double d = c; // não precisa do cast, faz automaticamente

Console.WriteLine("Implícito: " + d);
Console.WriteLine("Explícito: " + b);

string value = "324221214";
int result = 0;

if(int.TryParse(value, out result))
{
    Console.WriteLine("Success " + result);
}
else
{
    Console.WriteLine("Failure...");
}

StackHeapExample stackHeap = new StackHeapExample();



// Fixed vs Dynamic arrays

//Fixed

int[] fixedArray = new int[4];

fixedArray[0] = 4;
fixedArray[2] = 1;

//Dynamic

int[] dynamicArray = new int[4] { 1, 2, 3, 8 };

Console.WriteLine("Finish");



string firstName = "Mariana";
string lastName = "Delgado";
// String Interpolation
Console.WriteLine($"My name is {firstName} {lastName}");
// Composite Formatting
Console.WriteLine("My name is {0} {1}", firstName, lastName);

// this one is normal
Console.WriteLine("My name is " + firstName + " " + lastName);

//String Builder

var sb = new StringBuilder();
sb.Append("Helloooo");
var sb2 = sb;
sb.Append(" World");
Console.WriteLine(sb);
Console.WriteLine(sb2);


//Lists

List<Part> lst = new List<Part>();
lst.Add(new Part { PartName = "HeadLight", PartId = 1 });
lst.Add(new Part { PartName = "Bumper", PartId = 2 });
foreach(Part p in lst)
{
    Console.WriteLine("Name: {0}, ID: {1}",p.PartName, p.PartId.ToString());
}

// IFS

int x = 0;
int y = x;
int z;
if(x == y)
{
    Console.WriteLine("O x é {0} mas eu vou mudar", x);
    x = 9;
    z = 3;
    Console.WriteLine("O Z que acabei de inventar é {0} será que existe fora?", z);
}
Console.WriteLine("Agora o x é {0}", x);


// INLINE Condition

string testing = 3 >= 2 ? "true" : "false";
Console.WriteLine(testing);

//Switch Statements

State state = State.Active;
   // DisplayMeasurement(12);

void DisplayMeasurement(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measurement value is {measurement}; too low bro");
            break;
        case > 15.0:
            Console.WriteLine($"Measurement value is {measurement}; too high");
            break;
        case double.NaN:
            Console.WriteLine("Failed...");
            break;
        default:
            Console.WriteLine($"Measure value is {measurement}");
            break;
    }
}

switch (state)
{
    case State.Active:
        Console.WriteLine("State Active");
        break;
    case State.Inactive:
        Console.WriteLine("State Inactive");
        break;
    default:
        throw new Exception(String.Format("Unknown state: {0}", state));
}

//Scope (for loop)

int aux=0;
for (int i = 0; i < 10; i++)
{
    aux++;
    Console.WriteLine($"Value of i: {i}");
    Console.WriteLine($"Value of aux: {aux}");
}
Console.WriteLine($"Final value of aux: {aux}");

int[] listaInt = new int[5] { 1, 2, 3, 4, 5 };
foreach (int i in listaInt)
{
    Console.WriteLine(i);
}

//CLASSES

Dog dog = new Dog("Nero", 7, "Chihuahua");
Console.WriteLine(dog.Age);
Console.WriteLine(dog.Breed);
Console.WriteLine(dog.Name);
dog.Bark();
dog.WalkToThePark();

// POLIMORFISMO
IDogWalker walker = new Dog("Nero", 12, "Pitbull");


// Pass by value VS Pass by reference

int abc = 5;
Square(abc);
Console.WriteLine("abc: " + abc);
SquareObject();
Console.WriteLine("abc fora da função: " + abc);
void Square(int abc)
{
    abc = abc * abc;
    Console.WriteLine("abc passed by value: " + abc);
}

void SquareObject()
{
    abc = abc * abc;
    Console.WriteLine("abc passed by reference: " + abc);
}



// Null Coalescing Operators

string str = null;
Console.WriteLine(str ?? "Error it is null");

void Print(int? num)
{
    Console.WriteLine(num);
}

Print(null);