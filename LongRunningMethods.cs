namespace AsyncLab
{
    internal static class LongRunningMethods
    {

        internal static async Task<bool> LongRunTaskOfDuration3s()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("LongRunTask3s ended");
            return true;
        }
        internal static async Task<bool> LongRunTaskOfDuration4s()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            Console.WriteLine("LongRunTask4s ended");
            return true;
        }

        internal static async Task<bool> LongRunTaskOfDuration6s()
        {
            await Task.Delay(TimeSpan.FromSeconds(6));
            Console.WriteLine("LongRunTask6s ended");
            return true;
        }
    }
}
