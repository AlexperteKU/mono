using System.IO;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	partial class NativeLibrary
	{
		static IntPtr LoadLibraryByName (string libraryName, Assembly assembly, DllImportSearchPath? searchPath, bool throwOnError) => throw new NotImplementedException ();

		static IntPtr LoadFromPath (string libraryName, bool throwOnError) {
			// TODO: implement
			if (throwOnError) {
				throw new DllNotFoundException();
			}
			return IntPtr.Zero;
		}

		static IntPtr LoadByName (string libraryName, RuntimeAssembly callingAssembly, bool hasDllImportSearchPathFlag, uint dllImportSearchPathFlag, bool throwOnError) => throw new NotImplementedException ();

		static void FreeLib (IntPtr handle) => throw new NotImplementedException ();

		static IntPtr GetSymbol (IntPtr handle, string symbolName, bool throwOnError) => throw new NotImplementedException ();
	}
}