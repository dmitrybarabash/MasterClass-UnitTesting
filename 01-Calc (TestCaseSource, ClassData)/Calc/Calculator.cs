namespace Calc;

public class Calculator
{
    public int Add(int a, int b)
    {
        // Типа регрессия — ошибка, внесенная при рефакторинге
        //if (a == 2 && b == 3) return 6;

        return a + b;
    }
}