namespace Assignment8ex2
{
    public delegate double Product(double a, double b);
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            //Create a Func delegate for one of the methods
            Func<double, double, double> sum = answer.GetSum;
            Console.WriteLine($"Func delegate for sum of {num1} and {num2}: {sum(num1, num2)}");
            //Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            //Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            
            // Create an Action delegate for one of the methods
            Action<double, double> getSmallerDel = answer.GetSmaller;
            Console.WriteLine("Printing the Action delegate for smaller number...");
            getSmallerDel(num1, num2);
           
            //Create a custom delegate for one of the methods
            Product p = new Product(answer.GetProduct);
            Console.WriteLine($"Custom delegate for product of {num1} and {num2}: {p(num1, num2)}");
        }
    }
}