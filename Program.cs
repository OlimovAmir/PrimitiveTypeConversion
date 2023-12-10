

class Program
{
    static void Main(string[] args)
    {
        int a = 21;

        double b = 5.2;
        float c = (float)b;
        float i = 25.3F;

        float result = (float)b + i;
        int result_v2 = a + (int)i;

        string st = "2355";
        int intValue = Convert.ToInt32(st);
        Console.WriteLine(intValue);
        

        bool d = Convert.ToBoolean(b);

        PrimitiveTypeConversion.ClassConversion classConversion = new PrimitiveTypeConversion.ClassConversion();
        PrimitiveTypeConversion.ClassConversion.Foo(a);
        PrimitiveTypeConversion.ClassConversion.Foo(c);
        Console.WriteLine(d);


    }
}