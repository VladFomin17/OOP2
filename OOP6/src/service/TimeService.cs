namespace OOP6.src;

public class TimeService
{
    public static async Task ShowTimeAsync(Action<string> updateAction, CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            updateAction(DateTime.Now.ToString("HH:mm:ss"));
            await Task.Delay(1000, token);
        }
    }
}