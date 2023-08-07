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
        if(IsDivisibleBy(i,7))
        {
            result += "Bang";
        }
        if(IsDivisibleBy(i,11))
        {
            result = "Bong";
        }
        if(IsDivisibleBy(i,13))
        {
            int BIndex = result.IndexOf("B");
            if (result.IndexOf("B") == -1)
            {
                result += "Fezz";
            } 
            else 
            {
                if (BIndex == 0)
                {
                    result = "Fezz" + result.Substring(BIndex);
                } else
                {
                    result = result.Substring(0,BIndex) + "Fezz" + result.Substring(BIndex);
                }
            }
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