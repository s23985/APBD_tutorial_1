namespace APBD_tutorial_01;

public class CalculateAverage
{
    public static decimal Calculate(int[] array)
    {
        var sum = (decimal)array.Sum(x => x);
        return sum / array.Length;
    }
}