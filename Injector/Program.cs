using SimpleInjector;

namespace Injector;

class Program
{
    public static void Main(string[] args)
    {
        string processName = "Pixel Gun 3D";
        string dllPath = Path.GetFullPath("PGMod.dll");

        Console.WriteLine("Injecting...");

        try { Core.InjectDll(processName, dllPath, "Init", arg: null!); }
        catch (Exception ex) { Console.WriteLine("Exception was thrown: " + ex.Message); return; }

        Console.WriteLine("Success!");
    }
}