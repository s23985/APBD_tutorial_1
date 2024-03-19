namespace APBD_tutorial_01;

public class CalculateAverage
{
    public static decimal Calculate(int[] array)
    {
        decimal sum = 0;
        foreach (var i in array)
        {
            sum += i;
        }

        return sum / array.Length;
    }
}