using System.Globalization;

class PatternScanner
{
    private List<byte?> _bytePattern = null!;

    public PatternScanner(string mask)
        => SetMask(mask);

    public void SetMask(string mask)
    {
        var _mask = mask.Split();
        _bytePattern = new List<byte?>();

        for (int i = 0; i < _mask.Length; i++)
        {
            if (byte.TryParse(_mask[i], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result))
                _bytePattern.Add(result);
            else
                _bytePattern.Add(null);
        }
    }

    public unsafe nint Find(nint moduleBase, int moduleSize)
    {
        if (_bytePattern.Count < 1)
            return nint.Zero;

        byte? firstSignificant = _bytePattern.FirstOrDefault(i => i != null);

        if (firstSignificant == null)
            return nint.Zero;

        int backOffset = _bytePattern.IndexOf(firstSignificant);

        var span = new ReadOnlySpan<byte>(moduleBase.ToPointer(), moduleSize);

        int currentPos = backOffset;

        while (currentPos <= span.Length - _bytePattern.Count)
        {
            int foundIndex = span[currentPos..].IndexOf(firstSignificant.Value);

            if (foundIndex == -1)
                break;

            currentPos += foundIndex;

            int patternStart = currentPos - backOffset;

            if (IsMatch(span[patternStart..(patternStart + _bytePattern.Count)]))
                return moduleBase + patternStart;

            currentPos++;
        }

        return nint.Zero;
    }

    private bool IsMatch(ReadOnlySpan<byte> span)
    {
        for (int i = 0; i < _bytePattern.Count; i++)
            if (_bytePattern[i] != null && span[i] != _bytePattern[i])
                return false;

        return true;
    }
}