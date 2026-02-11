using System.Reflection;

namespace PGMod
{
    internal static class ResourceUnpacker
    {

        static readonly string[] dlls = ["cimgui.dll", "ImGuiImpl.dll"];
        static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        static readonly string pePath = Directory.GetCurrentDirectory();

        public static void PrepareResources()
        {
            foreach (var item in dlls)
                if (!File.Exists(Path.Combine(pePath, item)))
                    Unpack(item);
        }

        private static void Unpack(string resourceName)
        {
            using var resourceStream = assembly.GetManifestResourceStream("PGMod.Requirements." + resourceName);
            using var fileStream = new FileStream(Path.Combine(pePath, resourceName), FileMode.Create);
            resourceStream!.CopyTo(fileStream);
        }
    }
}
