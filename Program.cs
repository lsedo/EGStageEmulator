// See https://aka.ms/new-console-template for more information
using EG_Simulator;

List<Stage>? stages = StageReader.LoadStages();

if (stages == null)
{
    Console.WriteLine("List is null, exiting...");
}
else
{
    Console.WriteLine("List read, printing stages...");

    for (int i = 0; i < stages.Count; i++)
    {
        Console.WriteLine(stages[i].Identifier);
    }
}
