using System;

public class TestAction
{
    public static void Main(string[] args)
    {
        Action<string> printAction = new Action<string>((string s) => Console.WriteLine(s + "\nThis method is calles from an anonymous method"));

        printAction("Testing the Action delegate");
    }
}