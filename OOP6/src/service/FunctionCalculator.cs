namespace OOP6.src;

/// <summary>
/// Класс для асинхронного вычисления математических функций.
/// </summary>
public class FunctionCalculator
{
    /// <summary>
    /// Точность вычисления ряда (эпсилон).
    /// Определяет минимальное значение члена ряда, при котором продолжается вычисление.
    /// </summary>
    private static double _e = 0.0000000000000000000001;

    /// <summary>
    /// Асинхронно вычисляет значение экспоненты e^x с использованием разложения в ряд Тейлора.
    /// Результаты промежуточных вычислений выводятся в указанный TextBox.
    /// </summary>
    /// <param name="x">Аргумент функции.</param>
    /// <param name="tb">Элемент TextBox для отображения процесса вычисления и результата.</param>
    /// <returns>Асинхронная задача.</returns>
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