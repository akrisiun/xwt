// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Target {

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_target_table_free(IntPtr targets, int n_targets);

		public static void TableFree(Gtk.TargetEntry targets, int n_targets) {
			IntPtr native_targets = GLib.Marshaller.StructureToPtrAlloc (targets);
			gtk_target_table_free(native_targets, n_targets);
			targets = Gtk.TargetEntry.New (native_targets);
			Marshal.FreeHGlobal (native_targets);
		}

#endregion
	}
}