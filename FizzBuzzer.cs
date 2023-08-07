namespace FizzBuzz;

public class FizzBuzzer {
    public string FizzBuzz(int i) {
        var result = "";

        if(IsDivisibleBy(i, 3))
        {
            result += "Fizz";
        }
        if(IsDivisibleBy(i,5))
        {
            result += "Buzz";
        }
        if (result == "")
        {
            result = i.ToString();
        }
         return result;
    }

    private bool IsDivisibleBy(int num, int denom) {
        return num % denom == 0;
    }
}