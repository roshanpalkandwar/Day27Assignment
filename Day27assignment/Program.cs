namespace Day27assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            InputOutput readOrWrite = new InputOutput();
            string path = @"C:\Users\User\Desktop\project assignment\Day27Assignment\Day27Assignment\Day27assignment\AdressBook2.txt";
            readOrWrite.Read(path);
            readOrWrite.Write(path);
            Console.ReadLine();
        }
    }
}