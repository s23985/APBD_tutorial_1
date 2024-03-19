namespace APBD_tutorial_01;

public class CalculateMax
{
    public static decimal Calculate(int[] array)
    {
        return array.Max(x => x);
    }
}