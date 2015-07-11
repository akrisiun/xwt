// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AccelMap : GLib.Object {

		public AccelMap (IntPtr raw) : base(raw) {}

		protected AccelMap() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("changed")]
		public event Gtk.MapChangedHandler MapChanged {
			add {
				this.AddSignalHandler ("changed", value, typeof (Gtk.MapChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static MapChangedNativeDelegate MapChanged_cb_delegate;
		static MapChangedNativeDelegate MapChangedVMCallback {
			get {
				if (MapChanged_cb_delegate == null)
					MapChanged_cb_delegate = new MapChangedNativeDelegate (MapChanged_cb);
				return MapChanged_cb_delegate;
			}
		}

		static void OverrideMapChanged (GLib.GType gtype)
		{
			OverrideMapChanged (gtype, MapChangedVMCallback);
		}

		static void OverrideMapChanged (GLib.GType gtype, MapChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MapChangedNativeDelegate (IntPtr inst, IntPtr accel_path, uint accel_key, int accel_mods);

		static void MapChanged_cb (IntPtr inst, IntPtr accel_path, uint accel_key, int accel_mods)
		{
			try {
				AccelMap __obj = GLib.Object.GetObject (inst, false) as AccelMap;
				__obj.OnMapChanged (GLib.Marshaller.PtrToStringGFree(accel_path), accel_key, (Gdk.ModifierType) accel_mods);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.AccelMap), ConnectionMethod="OverrideMapChanged")]
		protected virtual void OnMapChanged (string accel_path, uint accel_key, Gdk.ModifierType accel_mods)
		{
			InternalMapChanged (accel_path, accel_key, accel_mods);
		}

		private void InternalMapChanged (string accel_path, uint accel_key, Gdk.ModifierType accel_mods)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (4);
			GLib.Value[] vals = new GLib.Value [4];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (accel_path);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (accel_key);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (accel_mods);
			inst_and_params.Append (vals [3]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkAccelMapClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkAccelMapClass> class_structs;

		static GtkAccelMapClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkAccelMapClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkAccelMapClass class_struct = (GtkAccelMapClass) Marshal.PtrToStructure (class_ptr, typeof (GtkAccelMapClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkAccelMapClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_add_entry(IntPtr accel_path, uint accel_key, int accel_mods);

		public static void AddEntry(string accel_path, uint accel_key, Gdk.ModifierType accel_mods) {
			IntPtr native_accel_path = GLib.Marshaller.StringToPtrGStrdup (accel_path);
			gtk_accel_map_add_entry(native_accel_path, accel_key, (int) accel_mods);
			GLib.Marshaller.Free (native_accel_path);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_add_filter(IntPtr filter_pattern);

		public static void AddFilter(string filter_pattern) {
			IntPtr native_filter_pattern = GLib.Marshaller.StringToPtrGStrdup (filter_pattern);
			gtk_accel_map_add_filter(native_filter_pattern);
			GLib.Marshaller.Free (native_filter_pattern);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_accel_map_change_entry(IntPtr accel_path, uint accel_key, int accel_mods, bool replace);

		public static bool ChangeEntry(string accel_path, uint accel_key, Gdk.ModifierType accel_mods, bool replace) {
			IntPtr native_accel_path = GLib.Marshaller.StringToPtrGStrdup (accel_path);
			bool raw_ret = gtk_accel_map_change_entry(native_accel_path, accel_key, (int) accel_mods, replace);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_accel_path);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_foreach(IntPtr data, GtkSharp.AccelMapForeachNative foreach_func);

		public static void Foreach(IntPtr data, Gtk.AccelMapForeach foreach_func) {
			GtkSharp.AccelMapForeachWrapper foreach_func_wrapper = new GtkSharp.AccelMapForeachWrapper (foreach_func);
			gtk_accel_map_foreach(data, foreach_func_wrapper.NativeDelegate);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_foreach_unfiltered(IntPtr data, GtkSharp.AccelMapForeachNative foreach_func);

		public static void ForeachUnfiltered(IntPtr data, Gtk.AccelMapForeach foreach_func) {
			GtkSharp.AccelMapForeachWrapper foreach_func_wrapper = new GtkSharp.AccelMapForeachWrapper (foreach_func);
			gtk_accel_map_foreach_unfiltered(data, foreach_func_wrapper.NativeDelegate);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_accel_map_get();

		public static Gtk.AccelMap Get() {
			IntPtr raw_ret = gtk_accel_map_get();
			Gtk.AccelMap ret = GLib.Object.GetObject(raw_ret) as Gtk.AccelMap;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_accel_map_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_accel_map_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_load(IntPtr file_name);

		[DllImport("libgtk-3-0.dll")]
		static extern void gtk_accel_map_load_utf8(IntPtr file_name);

		public static void Load(string file_name) {
			IntPtr native_file_name = GLib.Marshaller.StringToPtrGStrdup (file_name);
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				gtk_accel_map_load_utf8(native_file_name);
			else
				gtk_accel_map_load(native_file_name);
			GLib.Marshaller.Free (native_file_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_load_fd(int fd);

		public static void LoadFd(int fd) {
			gtk_accel_map_load_fd(fd);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_lock_path(IntPtr accel_path);

		public static void LockPath(string accel_path) {
			IntPtr native_accel_path = GLib.Marshaller.StringToPtrGStrdup (accel_path);
			gtk_accel_map_lock_path(native_accel_path);
			GLib.Marshaller.Free (native_accel_path);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_accel_map_lookup_entry(IntPtr accel_path, IntPtr key);

		public static bool LookupEntry(string accel_path, out Gtk.AccelKey key) {
			IntPtr native_accel_path = GLib.Marshaller.StringToPtrGStrdup (accel_path);
			IntPtr native_key = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.AccelKey)));
			bool raw_ret = gtk_accel_map_lookup_entry(native_accel_path, native_key);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_accel_path);
			key = Gtk.AccelKey.New (native_key);
			Marshal.FreeHGlobal (native_key);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_save(IntPtr file_name);

		[DllImport("libgtk-3-0.dll")]
		static extern void gtk_accel_map_save_utf8(IntPtr file_name);

		public static void Save(string file_name) {
			IntPtr native_file_name = GLib.Marshaller.StringToPtrGStrdup (file_name);
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				gtk_accel_map_save_utf8(native_file_name);
			else
				gtk_accel_map_save(native_file_name);
			GLib.Marshaller.Free (native_file_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_save_fd(int fd);

		public static void SaveFd(int fd) {
			gtk_accel_map_save_fd(fd);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accel_map_unlock_path(IntPtr accel_path);

		public static void UnlockPath(string accel_path) {
			IntPtr native_accel_path = GLib.Marshaller.StringToPtrGStrdup (accel_path);
			gtk_accel_map_unlock_path(native_accel_path);
			GLib.Marshaller.Free (native_accel_path);
		}

#endregion
	}
}