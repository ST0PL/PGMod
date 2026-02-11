using System.Runtime.InteropServices;

namespace PGMod
{
    public class PGMod
    {
        [UnmanagedCallersOnly(EntryPoint = "Init")]
        public static void Init()
        {
            ResourceUnpacker.PrepareResources();
            UIController.Initialize();
        }
    }
}
