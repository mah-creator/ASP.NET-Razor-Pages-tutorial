using System;

public class TestAction
{
    public static void Main(string[] args)
    {
        Action<string> printAction = new Action<string>(Console.WriteLine);

        printAction("Testing the Action delegate");
    }
}