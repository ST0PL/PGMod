using SimpleInjector;

namespace Injector;

class Program
{
    public static void Main(string[] args)
    {
        string processName = "Pixel Gun 3D";
        string dllPath = Path.GetFullPath("PGMod.dll");

        if (!File.Exists(dllPath))
        {
            Console.WriteLine(
                "Cannot find PGMod.dll.\n" +
                "Make sure you have built the DLL via \"BuildAOT.bat\" in PGMod project folder.");
            return;
        }

        Console.WriteLine("Injecting...");

        try { Core.InjectDll(processName, dllPath, "Init", arg: null!); }
        catch (Exception ex) { Console.WriteLine("Exception was thrown: " + ex.Message); return; }

        Console.WriteLine("Success!");
    }
}