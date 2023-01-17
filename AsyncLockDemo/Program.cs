namespace AsyncLockDemo;

public class Program
{

	private static object lockObject = new();
	private static int counter;

	public static async Task Main(string[] args)
	{
		
		for (int index = 0; index < 1_000_000; ++index)
		{
			Calculate();
		}
		
		Console.WriteLine(counter);
		Console.ReadLine();

	}

	private static async void Calculate()
	{
		Monitor.Enter(lockObject);
		
		await Task.Factory.StartNew(() =>
		{
			++counter;
		});
		
		Monitor.Exit(lockObject);
	}

}