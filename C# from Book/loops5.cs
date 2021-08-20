string[] theArgs = Environment.GetCommandLineArgs();
for (int i = 0; i < args.Length; i++)
{
    System.Console.WriteLine("Args:{0}", args[i]);
}
foreach (string arg in theArgs)
    Console.WriteLine("Arg: {0}", arg);
