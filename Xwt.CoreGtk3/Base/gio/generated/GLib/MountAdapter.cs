// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MountAdapter : GLib.GInterfaceAdapter, GLib.IMount {

		GLib.Object implementor;

		public MountAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_type();

		private static GLib.GType _gtype = new GLib.GType (g_mount_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IMount GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IMount GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj as IMount == null)
				return new MountAdapter (obj.Handle);
			else
				return obj as IMount;
		}

		[GLib.Signal("pre-unmount")]
		public event System.EventHandler PreUnmount {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("pre-unmount", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("pre-unmount", value);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("changed", value);
			}
		}

		[GLib.Signal("unmounted")]
		public event System.EventHandler Unmounted {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("unmounted", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("unmounted", value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_can_eject(IntPtr raw);

		public bool CanEject() {
			bool raw_ret = g_mount_can_eject(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_can_unmount(IntPtr raw);

		public bool CanUnmount { 
			get {
				bool raw_ret = g_mount_can_unmount(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_eject(IntPtr raw, int flags, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		[Obsolete]
		public void Eject(GLib.MountUnmountFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_mount_eject(Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_eject_finish(IntPtr raw, IntPtr result, out IntPtr error);

		[Obsolete]
		public bool EjectFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_mount_eject_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_eject_with_operation(IntPtr raw, int flags, IntPtr mount_operation, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void EjectWithOperation(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_mount_eject_with_operation(Handle, (int) flags, mount_operation == null ? IntPtr.Zero : mount_operation.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_eject_with_operation_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public bool EjectWithOperationFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_mount_eject_with_operation_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_default_location(IntPtr raw);

		public GLib.IFile DefaultLocation { 
			get {
				IntPtr raw_ret = g_mount_get_default_location(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_drive(IntPtr raw);

		public GLib.IDrive Drive { 
			get {
				IntPtr raw_ret = g_mount_get_drive(Handle);
				GLib.IDrive ret = GLib.DriveAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_icon(IntPtr raw);

		public GLib.IIcon Icon { 
			get {
				IntPtr raw_ret = g_mount_get_icon(Handle);
				GLib.IIcon ret = GLib.IconAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = g_mount_get_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_root(IntPtr raw);

		public GLib.IFile Root { 
			get {
				IntPtr raw_ret = g_mount_get_root(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_uuid(IntPtr raw);

		public string Uuid { 
			get {
				IntPtr raw_ret = g_mount_get_uuid(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_get_volume(IntPtr raw);

		public GLib.IVolume Volume { 
			get {
				IntPtr raw_ret = g_mount_get_volume(Handle);
				GLib.IVolume ret = GLib.VolumeAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_guess_content_type(IntPtr raw, bool force_rescan, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void GuessContentType(bool force_rescan, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_mount_guess_content_type(Handle, force_rescan, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_guess_content_type_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public string[] GuessContentTypeFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_mount_guess_content_type_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_guess_content_type_sync(IntPtr raw, bool force_rescan, IntPtr cancellable, out IntPtr error);

		public string[] GuessContentTypeSync(bool force_rescan, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_mount_guess_content_type_sync(Handle, force_rescan, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_is_shadowed(IntPtr raw);

		public bool IsShadowed { 
			get {
				bool raw_ret = g_mount_is_shadowed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_remount(IntPtr raw, int flags, IntPtr mount_operation, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void Remount(GLib.MountMountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_mount_remount(Handle, (int) flags, mount_operation == null ? IntPtr.Zero : mount_operation.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_remount_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public bool RemountFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_mount_remount_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_shadow(IntPtr raw);

		public void Shadow() {
			g_mount_shadow(Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_unmount(IntPtr raw, int flags, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		[Obsolete]
		public void Unmount(GLib.MountUnmountFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_mount_unmount(Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_unmount_finish(IntPtr raw, IntPtr result, out IntPtr error);

		[Obsolete]
		public bool UnmountFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_mount_unmount_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_unmount_with_operation(IntPtr raw, int flags, IntPtr mount_operation, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void UnmountWithOperation(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_mount_unmount_with_operation(Handle, (int) flags, mount_operation == null ? IntPtr.Zero : mount_operation.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_unmount_with_operation_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public bool UnmountWithOperationFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_mount_unmount_with_operation_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_unshadow(IntPtr raw);

		public void Unshadow() {
			g_mount_unshadow(Handle);
		}

#endregion
	}
}