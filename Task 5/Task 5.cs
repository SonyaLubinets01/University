using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Example usage of ParallelUtils class with integer operands
        ParallelUtils<int, int> parallelUtilsInt = new ParallelUtils<int, int>((a, b) => a + b, 10, 20);

        // Start evaluation in a parallel thread
        parallelUtilsInt.StartEvaluation();

        // Wait for the evaluation to finish and print the result
        Console.WriteLine("Waiting for evaluation to complete...");
        parallelUtilsInt.WaitForCompletion();
        Console.WriteLine($"Result of the operation: {parallelUtilsInt.Result}");

        // Example usage of ParallelUtils class with double operands
        ParallelUtils<double, double> parallelUtilsDouble = new ParallelUtils<double, double>((a, b) => a * b, 2.5, 3.5);

        // Evaluate the operation in a parallel thread and wait for it to finish
        parallelUtilsDouble.Evaluate();
        parallelUtilsDouble.WaitForCompletion();

        // Print the result
        Console.WriteLine($"Result of the operation: {parallelUtilsDouble.Result}");

        Console.ReadKey();
    }
}

public class ParallelUtils<T, TR>
{
    private readonly Func<T, T, TR> operation;
    private readonly T operand1;
    private readonly T operand2;
    private TR result;

    private Task evaluationTask;

    public ParallelUtils(Func<T, T, TR> operation, T operand1, T operand2)
    {
        this.operation = operation;
        this.operand1 = operand1;
        this.operand2 = operand2;
    }

    public TR Result
    {
        get { return result; }
        private set { result = value; }
    }

    public void StartEvaluation()
    {
        evaluationTask = Task.Run(() =>
        {
            Result = operation(operand1, operand2);
        });
    }

    public void Evaluate()
    {
        evaluationTask = Task.Run(() =>
        {
            Result = operation(operand1, operand2);
        });
    }

    public void WaitForCompletion()
    {
        evaluationTask.Wait();
    }
}
