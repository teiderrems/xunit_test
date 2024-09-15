namespace Fibonacci;

public class Fibonacci
{
    public static int fibonacci(int k){
        if (k<0)
        {
            return 0;
        }
        if(k == 0){
            return 1;
        }
        if(k == 1){
            return 1;
        }
        return fibonacci(k-1) + fibonacci(k-2);
        // throw new NotImplementedException("Implement this function");
    }
}
