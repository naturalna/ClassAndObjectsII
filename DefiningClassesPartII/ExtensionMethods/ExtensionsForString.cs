using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ExtensionsForString
{
    public static int WordsCount(this String text)
    {
        // wry6ta mi dyljina na masiwyt 
        return text.Split(new char[] { ' ', ',', '.', '?', '!', '-', '=' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

