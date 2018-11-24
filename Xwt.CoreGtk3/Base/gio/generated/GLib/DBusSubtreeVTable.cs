// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct DBusSubtreeVTable : IEquatable<DBusSubtreeVTable> {

		private GLibSharp.DBusSubtreeEnumerateFuncNative enumerate;
		public GLib.DBusSubtreeEnumerateFunc Enumerate {
			get {
				return GLibSharp.DBusSubtreeEnumerateFuncWrapper.GetManagedDelegate (enumerate);
			}
		}
		private GLibSharp.DBusSubtreeIntrospectFuncNative introspect;
		public GLib.DBusSubtreeIntrospectFunc Introspect {
			get {
				return GLibSharp.DBusSubtreeIntrospectFuncWrapper.GetManagedDelegate (introspect);
			}
		}
		private GLibSharp.DBusSubtreeDispatchFuncNative dispatch;
		public GLib.DBusSubtreeDispatchFunc Dispatch {
			get {
				return GLibSharp.DBusSubtreeDispatchFuncWrapper.GetManagedDelegate (dispatch);
			}
		}
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=8)]
		private IntPtr[] Padding;

		public static GLib.DBusSubtreeVTable Zero = new GLib.DBusSubtreeVTable ();

		public static GLib.DBusSubtreeVTable New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GLib.DBusSubtreeVTable.Zero;
			return (GLib.DBusSubtreeVTable) Marshal.PtrToStructure (raw, typeof (GLib.DBusSubtreeVTable));
		}

		public bool Equals (DBusSubtreeVTable other)
		{
			return true && Enumerate.Equals (other.Enumerate) && Introspect.Equals (other.Introspect) && Dispatch.Equals (other.Dispatch);
		}

		public override bool Equals (object other)
		{
			return other is DBusSubtreeVTable && Equals ((DBusSubtreeVTable) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Enumerate.GetHashCode () ^ Introspect.GetHashCode () ^ Dispatch.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}