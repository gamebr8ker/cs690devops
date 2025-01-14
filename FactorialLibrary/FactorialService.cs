namespace FactorialLibrary;

public class FactorialService
{
    public static int Factorial( int n ) {
        // Note: 0! = 1, 1! = 1
        if (n == 1 || n == 0) {
            return 1;
        }

        return n * Factorial(n-1);
    }
}
