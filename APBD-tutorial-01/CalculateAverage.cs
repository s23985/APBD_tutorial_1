namespace APBD_tutorial_01;

public class CalculateAverage
{
    public static decimal Calculate(int[] arr)
    {
        var sum = (decimal)arr.Sum(x => x);
        return sum / arr.Length;
    }
}