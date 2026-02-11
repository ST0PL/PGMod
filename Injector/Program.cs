using SimpleInjector;

namespace Injector;

class Program
{
    public static void Main(string[] args)
    {
        string processName = "Pixel Gun 3D";
        string dllPath = Path.GetFullPath("PGMod.dll");

        if (File.Exists(dllPath))
        {
            Console.WriteLine("Injecting...");
            try { Core.InjectDll(processName, dllPath, "Init", arg: null!); Console.WriteLine("Success!"); }
            catch (Exception ex) { Console.WriteLine("Exception was thrown: " + ex.Message); }
        }
        else
            Console.WriteLine(
                "Cannot find PGMod.dll.\n" +
                "Make sure you have built the DLL via \"BuildAOT.bat\" in PGMod project folder.");

        Console.Write("\nPress any key to exit..."); Console.ReadKey();
    }
}