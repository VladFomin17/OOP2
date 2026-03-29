namespace OOP6.src;

/// <summary>
/// Класс для асинхронного отображения системного времени.
/// </summary>
public class TimeService
{
    /// <summary>
    /// Асинхронно запускает цикл обновления текущего системного времени.
    /// Время передаётся через делегат для последующего отображения (например, в UI).
    /// Выполнение продолжается до отмены через CancellationToken.
    /// </summary>
    /// <param name="updateAction">
    /// Делегат, принимающий строковое представление времени и выполняющий его отображение.
    /// </param>
    /// <param name="token">
    /// Токен отмены, позволяющий остановить выполнение асинхронного цикла.
    /// </param>
    /// <returns>Асинхронная задача.</returns>
    /// <exception cref="TaskCanceledException">
    /// Может быть выброшено при отмене задачи через CancellationToken.
    /// </exception>
    public static async Task ShowTimeAsync(Action<string> updateAction, CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            updateAction(DateTime.Now.ToString("HH:mm:ss"));
            await Task.Delay(1000, token);
        }
    }
}