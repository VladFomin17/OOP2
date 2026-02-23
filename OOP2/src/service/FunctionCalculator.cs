namespace OOP2.src;

public class FunctionCalculator
{
    private static double _e = 0.0000000000000000000001;

    public static async Task Exponent(double x, TextBox tb)
    {
        await Task.Run(() =>
        {
            double u = 1;
            double sum = u;
            int i = 1;
            tb.Invoke((MethodInvoker)(() => {
                tb.Text += $"Член ряда: {u.ToString("F2")}" + Environment.NewLine +
                           $"Сумма ряда: {sum.ToString("F2")}" +
                           Environment.NewLine;
            }));
            while (Math.Abs(u) >= _e)
            {
                Task.Delay(50).Wait();
                u = (x / i) * u;
                sum += u;
                i++;
                tb.Invoke((MethodInvoker)(() => { 
                    tb.Text += $"Член ряда: {u.ToString("F2")}" + Environment.NewLine +
                               $"Сумма ряда: {sum.ToString("F2")}" +
                               Environment.NewLine; }));
            }
            tb.Invoke((MethodInvoker)(() => {
                tb.Text = $"Значение функции: {sum.ToString("F2")}" + Environment.NewLine + tb.Text;
            }));
        });
    }
}