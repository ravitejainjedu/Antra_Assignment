// See https://aka.ms/new-console-template for more information

using Assignment_3;

// 1. Reversing an Array
int[] numbers = Reverse.GenerateNumbers(10);  // generate 1–10
Reverse.ReverseArray(numbers);                // become 10–1
//Console.WriteLine(string.Join(", ", numbers)); 
Reverse.PrintNumbers(numbers);                  // print out

Console.WriteLine();

// 2. FibonacciSeries
// print first 10 Fibonacci numbers
for (int i = 1; i <= 10; i++)
    Console.WriteLine(Fibonacci.FibonacciSeries(i));

Console.WriteLine();

//Designing and Building Classes using object-oriented principles
var svc = new UniversityService();

var dept = new Department("Computer Science");
var inst = new Instructor("Dr. Ada", new DateTime(1980, 5, 1), 80000m, new DateTime(2010, 8, 15));
svc.SetHead(dept, inst);
svc.SetBudget(dept, 500000m, new DateTime(2025, 1, 1), new DateTime(2025, 12, 31));

var cs101 = new Course("CS101");
dept.AddCourse(cs101);

var stud = new Student("Alice", new DateTime(2002, 3, 10));
svc.EnrollStudent(cs101, stud, 'A');

Console.WriteLine($"{inst.Name} age {svc.GetAge(inst)}, salary {svc.GetSalary(inst):C}");
Console.WriteLine($"{stud.Name} age {svc.GetAge(stud)}, GPA {svc.CalculateGPA(stud):F2}");
Console.WriteLine($"Dept {dept.Name} Head {dept.Head.Name}, Budget {dept.Budget:C}");


Console.WriteLine();

//Popped balls 
// create two balls with different sizes and colors
Ball ball1 = new Ball(5, new Color(255, 0, 0));       // red ball
Ball ball2 = new Ball(3, new Color(0, 0, 255, 128));  // semi-transparent blue

// throw ball1 three times
ball1.ThrowBall();
ball1.ThrowBall();
ball1.ThrowBall();

// pop ball1 then attempt another throw
ball1.Pop();
ball1.ThrowBall();  // won't count

// throw ball2 twice
ball2.ThrowBall();
ball2.ThrowBall();

// output throw counts
Console.WriteLine($"ball1 thrown: {ball1.GetThrowCount()}"); // prints 3
Console.WriteLine($"ball2 thrown: {ball2.GetThrowCount()}"); // prints 2