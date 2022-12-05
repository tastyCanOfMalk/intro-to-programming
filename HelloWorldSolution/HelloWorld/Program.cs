using HelloWorld;

Console.WriteLine("Take a break!");

Console.Write("How many minutes? : ");
string? minutes = Console.ReadLine();

if (minutes != null)
{
    DateUtils utils = new DateUtils();

    int mins = int.Parse(minutes);
    DateTime timeAtEndOfBreak = utils.TakeABreak(mins);
    Console.WriteLine($"Be back at {timeAtEndOfBreak:T}");
}
else
{
    Console.WriteLine("Errorrrr");
}
