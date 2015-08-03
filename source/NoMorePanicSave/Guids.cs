// Guids.cs
// MUST match guids.h
using System;

namespace PhilippDolder.NoMorePanicSave
{
    static class GuidList
    {
        public const string guidNoMorePanicSavePkgString = "63446b6e-02ef-4084-b1c3-1de592e0e202";
        public const string guidNoMorePanicSaveCmdSetString = "b16ccf13-4516-44b8-a183-581506c11065";

        public static readonly Guid guidNoMorePanicSaveCmdSet = new Guid(guidNoMorePanicSaveCmdSetString);
    };
}