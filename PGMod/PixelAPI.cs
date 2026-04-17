using PGMod.Types;
using System.Diagnostics;

namespace PGMod
{
    internal static unsafe class PixelAPI
    {
        private static readonly delegate* unmanaged<nint,nint,int,int,byte,byte,ItemObtainParams*,void> addCurrency;
        private static readonly delegate* unmanaged<nint> getProgressUpdater;
        static PixelAPI()
        {
            var module = 
                Process.GetCurrentProcess().Modules.Cast<ProcessModule>().First(m=>m.ModuleName.Equals("gameassembly.dll", StringComparison.OrdinalIgnoreCase));

            var patternScanner = new PatternScanner(Patterns.GetProgressUpdater);

            getProgressUpdater = (delegate* unmanaged<nint>)(patternScanner.Find(module.BaseAddress, module.ModuleMemorySize));

            patternScanner.SetMask(Patterns.AddCurrency);
            addCurrency = (delegate* unmanaged<nint,nint,int,int,byte,byte,ItemObtainParams*,void>)(patternScanner.Find(module.BaseAddress, module.ModuleMemorySize));
        }

        public static ItemObtainParams AddCurrency(string type, int amount, CurrencySource source)
        {
            ItemObtainParams transactionData = new();
            addCurrency(getProgressUpdater(), IL2cpp.StringNew(type), amount, (int)source, 0, 0, &transactionData);
            return transactionData;
        }
    }
}
