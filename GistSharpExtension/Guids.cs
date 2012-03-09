// Guids.cs
// MUST match guids.h
using System;

namespace TAKANOSho.GistSharpExtension
{
    static class GuidList
    {
        public const string guidGistSharpExtensionPkgString = "6ebb80fa-dd9d-496b-a645-8b0715d32cc3";
        public const string guidGistSharpExtensionCmdSetString = "71278073-30ed-47ca-8dc2-706a34b2a392";

        public static readonly Guid guidGistSharpExtensionCmdSet = new Guid(guidGistSharpExtensionCmdSetString);
    };
}