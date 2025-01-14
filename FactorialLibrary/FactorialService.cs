namespace FactorialLibrary;

public class FactorialService
{
    public static int Factorial( int n ) {

        if ( n < 0 ) {
            throw new InvalidOperationException("Negative numbers don't have proper factorial");
        }

        // Note: 0! = 1, 1! = 1
        if (n == 1 || n == 0) {
            return 1;
        }

        return n * Factorial(n-1);
    }
}
