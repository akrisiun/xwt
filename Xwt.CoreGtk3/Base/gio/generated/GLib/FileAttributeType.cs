// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.FileAttributeTypeGType))]
	public enum FileAttributeType {

		Invalid,
		String,
		ByteString,
		Boolean,
		Uint32,
		Int32,
		Uint64,
		Int64,
		Object,
		Stringv,
	}

	internal class FileAttributeTypeGType {
		[DllImport ("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_file_attribute_type_get_type ());
			}
		}
	}
#endregion
}