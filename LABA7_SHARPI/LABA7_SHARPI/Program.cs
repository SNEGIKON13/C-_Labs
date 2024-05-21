using LABA7_SHARPI;

Complex c1 = new Complex(2, 3);
Complex c2 = new Complex(4, 5);

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

Complex sum = c1 + c2;
Complex difference = c1 - c2;
Complex product = c1 * c2;
Complex quotient = c1 / c2;

Console.WriteLine($"c1 + c2 = {sum}");
Console.WriteLine($"c1 - c2 = {difference}");
Console.WriteLine($"c1 * c2 = {product}");
Console.WriteLine($"c1 / c2 = {quotient}");

Complex c3 = c1 + 2.5;
Complex c4 = c2 - 1.5;
Complex c5 = c1 * 1.5;
Complex c6 = c2 / 2.5;

Console.WriteLine($"c1 + 2.5 = {c3}");
Console.WriteLine($"c2 - 1.5 = {c4}");
Console.WriteLine($"c1 * 1.5 = {c5}");
Console.WriteLine($"c2 / 2.5 = {c6}");

bool greater = c1 > c2;
bool lesser = c1 < c2;
bool equal = c1 == c2;
bool notEqual = c1 != c2;

Console.WriteLine($"c1 > c2: {greater}");
Console.WriteLine($"c1 < c2: {lesser}");
Console.WriteLine($"c1 == c2: {equal}");
Console.WriteLine($"c1 != c2: {notEqual}");

double modulus = (double)c1;
Complex c7 = 3.7;
bool nonZero = c1;

Console.WriteLine($"Modulus of c1: {modulus}");
Console.WriteLine($"Complex c7: {c7}");
Console.WriteLine($"c1 is non-zero: {nonZero}");

Console.WriteLine($"Real part of c1: {c1[0]}");
Console.WriteLine($"Imaginary part of c1: {c1[1]}");

double c2Modulus = c2.Modulus();
Console.WriteLine($"Modulus of c2: {c2Modulus}");