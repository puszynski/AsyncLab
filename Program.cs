using AsyncLab;


Console.WriteLine("Press 1 and enter => Run all long running tasks with await operators.");
Console.WriteLine("Press 2 and enter => Run all long running tasks with no await operators.");
Console.WriteLine("Press 3 and enter => Run all long running tasks with no await operators, but await for all tasks in next steps.");

int menuOption = Convert.ToInt32(Console.ReadLine());

switch (menuOption)
{
	case 1:
		Console.WriteLine("Start option 1 (note: Tasks will run synchronously one after another).");
        await LongRunningMethods.LongRunTaskOfDuration3s();
        await LongRunningMethods.LongRunTaskOfDuration4s();
        await LongRunningMethods.LongRunTaskOfDuration6s();
		Console.WriteLine("End option 1. Press key to exit program.");
        Console.ReadKey();
        break;

	case 2:
		Console.WriteLine("Start option 2 (beware! If console app will be closed (press any key), background threads will break before done its jobs).");
        LongRunningMethods.LongRunTaskOfDuration3s();
        LongRunningMethods.LongRunTaskOfDuration4s();
        LongRunningMethods.LongRunTaskOfDuration6s();
        Console.WriteLine("End option 2. Press key to exit program.");
        Console.ReadKey();
        break;

	case 3:
        Console.WriteLine("Start option 3 (note: Task will run asynchroniusly, and await operators will wait untill all tasks will be done).");
        var task3s = LongRunningMethods.LongRunTaskOfDuration3s();
        var task4s = LongRunningMethods.LongRunTaskOfDuration4s();
        var task6s = LongRunningMethods.LongRunTaskOfDuration6s();

        await task3s;
        await task4s;
        await task6s;
        Console.WriteLine("End option 2. Press key to exit program.");
        Console.ReadKey();
        break;

	default:
        Console.WriteLine("Wrong user input. Try again.");
		break;
}

Console.WriteLine("Program closed.");