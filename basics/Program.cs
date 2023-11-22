internal class Program
{

    private static void Main(string[] args)
    {
        // HelloWorld();
        // IntroString();
        // IntroNumeric();
        // IntroBoolean();
        // IntroEnums();
        // Array
        // Dictionary
        // Generic
        // IntroNullable();
        // IntroRecord();
        // IntroClass();
        // IntroInterfaces();
    }

    private static void IntroInterfaces()
    {
        // define behavior for multiple types
        ISampleInterface imple = new ImpleImplementationClass();
        imple.Hello();
    }

    public interface ISampleInterface
    {
        public void Hello();
    }

    public class ImpleImplementationClass : ISampleInterface
    {
        public ImpleImplementationClass()
        {
        }

        public void Hello()
        {
            Console.WriteLine("Hello Sample Method");
        }
    }

    private static void IntroClass()
    {
        // reference type default mutable
        var person = new ClassPerson("Kaweel", "Chaoguay");
        Console.WriteLine(person.AKA);
        person.AKA = "Bobby";
        Console.WriteLine(person.AKA);
    }

    private class ClassPerson
    {
        public string Name { get; set; }
        public string AKA { get; set; }

        public ClassPerson(string name, string aka)
        {
            Name = name;
            AKA = aka;
        }
    }

    private static void IntroRecord()
    {
        // reference type default immutable
        var person = new RecordPerson("Kaweel", "Chaoguay");
        Console.WriteLine(person);
        // person.AKA = "Bobby";
    }
    public record RecordPerson(string Name, string AKA);

    private static void IntroNullable()
    {
        int? a = 42;
        if (a is int valueOfA)
        {
            Console.WriteLine($"a is {valueOfA}");
        }
        else
        {
            Console.WriteLine("a does not have a value");
        }

        int? b = null;
        if (b.HasValue)
        {
            Console.WriteLine($"b is {b.Value}");
        }
        else
        {
            Console.WriteLine("b does not have a value");
        }

        int? c = 7;
        if (c != null)
        {
            Console.WriteLine($"c is {c.Value}");
        }
        else
        {
            Console.WriteLine("c does not have a value");
        }
    }

    [Flags]
    private enum Days
    {
        None = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Weekend = Saturday | Sunday
    }
    private static void IntroEnums()
    {
        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine(meetingDays);

        Days workingFromHomeDays = Days.Thursday | Days.Friday;
        Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

        var a = (Days)24;
        Console.WriteLine(a);
    }

    private static void IntroBoolean()
    {
        Console.WriteLine("===== Boolean =====");
        bool check = true;
        Console.WriteLine(check ? "Checked" : "Not checked");
        Console.WriteLine(!check ? "Checked" : "Not checked");
        Console.WriteLine("===== Boolean =====");
    }

    private static void IntroNumeric()
    {
        Console.WriteLine("===== Numeric =====");
        Console.WriteLine($"size of nint = {nint.Size}");
        Console.WriteLine($"size of nuint = {nuint.Size}");

        Console.WriteLine($"nint.MinValue = {nint.MinValue}");
        Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
        Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
        Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");

        Console.WriteLine($"Int32.MinValue = {int.MaxValue}");
        Console.WriteLine($"Int32.MinValue = {int.MinValue}");
        Console.WriteLine($"UInt32.MinValue = {uint.MaxValue}");
        Console.WriteLine($"UInt32.MinValue = {uint.MinValue}");

        float f1 = 123456.5F;
        float f2 = 1.123456f;
        Console.WriteLine($"Float {f1}");
        Console.WriteLine($"Float {f2}");
        Console.WriteLine($"Float.MinValue = {float.MaxValue}");
        Console.WriteLine($"Float.MinValue = {float.MinValue}");

        double d1 = 12345678912345.5D;
        double d2 = 1.123456789123456d;
        Console.WriteLine($"Double {d1}");
        Console.WriteLine($"Double {d2}");
        Console.WriteLine($"Double.MinValue = {double.MaxValue}");
        Console.WriteLine($"Double.MinValue = {double.MinValue}");
        Console.WriteLine("===== Numeric =====");
    }

    private static void IntroString()
    {
        Console.WriteLine("===== String =====");
        // Declare without initializing.
        // string message1;
        // Console.WriteLine($"message1 {message1}");

        // Initialize to null.
        string? message2 = null;
        Console.WriteLine($"message2 {message2}");

        // Initialize as an empty string.
        // Use the Empty constant instead of the literal "".
        string message3 = string.Empty;
        Console.WriteLine($"message3 {message3}");

        // In local variables (i.e. within a method body)
        // you can use implicit typing.
        var temp = "I'm still a strongly-typed System.String!";
        Console.WriteLine($"temp {temp}");

        // Use a const string to prevent 'message4' from
        // being used to store another string value.
        const string message4 = "You can't get rid of me!";
        Console.WriteLine($"message4 {message4}");
        // message4 = "Change";

        // Use the String constructor only when creating
        // a string from a char*, char[], or sbyte*. See
        // System.String documentation for details.
        char[] letters = { 'A', 'B', 'C' };
        string alphabet = new string(letters);
        Console.WriteLine($"alphabet {alphabet}");

        // Verbatim
        string str = @"str\str";
        Console.WriteLine($"str {str}");

        // Concatenation
        string name = "Kawee";
        string aka = "Chaoguay";
        string concatenation = "Mr." + name + " AKA." + aka;
        Console.WriteLine($"Concatenation {concatenation}");

        // Interpolation
        string interpolation = $"Mr.{name} AKA.{aka}";
        Console.WriteLine($"Interpolation {interpolation}");
        Console.WriteLine("===== String =====");
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }
}