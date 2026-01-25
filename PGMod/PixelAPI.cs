using PGMod.Types;

namespace PGMod
{
    internal static unsafe class PixelAPI
    {
        private static readonly nint gameAssemblyHandle;

        private static readonly delegate* unmanaged<nint,nint,int,int,byte,byte,ItemObtainParams*,void> addCurrency;
        private static readonly delegate* unmanaged<nint> getProgressUpdater;
        static PixelAPI()
        {
            gameAssemblyHandle = WinApi.GetModuleHandleW(IL2cpp.GameAssembly);
            getProgressUpdater = (delegate* unmanaged<nint>)(gameAssemblyHandle + Offsets.GetProgressUpdater);
            addCurrency = (delegate* unmanaged<nint,nint,int,int,byte,byte,ItemObtainParams*,void>)(gameAssemblyHandle + Offsets.AddCurrency);
        }

        public static unsafe ItemObtainParams AddCurrency(string type, int amount, CurrencySource source)
        {
            ItemObtainParams transactionData = new();
            addCurrency(getProgressUpdater(), IL2cpp.StringNew(type), amount, (int)source, 0, 0, &transactionData);
            return transactionData;
        }
    }
}
