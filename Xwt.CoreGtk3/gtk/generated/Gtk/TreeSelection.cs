// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TreeSelection : GLib.Object {

		public TreeSelection (IntPtr raw) : base(raw) {}

		protected TreeSelection() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			GtkTreeSelectionClass class_iface = GetClassStruct (gtype, false);
			class_iface.Changed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				TreeSelection __obj = GLib.Object.GetObject (inst, false) as TreeSelection;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TreeSelection), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Changed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkTreeSelectionClass {
			public ChangedNativeDelegate Changed;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkTreeSelectionClass> class_structs;

		static GtkTreeSelectionClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkTreeSelectionClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkTreeSelectionClass class_struct = (GtkTreeSelectionClass) Marshal.PtrToStructure (class_ptr, typeof (GtkTreeSelectionClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkTreeSelectionClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_selection_count_selected_rows(IntPtr raw);

		public int CountSelectedRows() {
			int raw_ret = gtk_tree_selection_count_selected_rows(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_selection_get_mode(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_set_mode(IntPtr raw, int type);

		public Gtk.SelectionMode Mode { 
			get {
				int raw_ret = gtk_tree_selection_get_mode(Handle);
				Gtk.SelectionMode ret = (Gtk.SelectionMode) raw_ret;
				return ret;
			}
			set {
				gtk_tree_selection_set_mode(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern GtkSharp.TreeSelectionFuncNative gtk_tree_selection_get_select_function(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_set_select_function(IntPtr raw, GtkSharp.TreeSelectionFuncNative func, IntPtr data, GLib.DestroyNotify destroy);

		public Gtk.TreeSelectionFunc SelectFunction { 
			get {
				GtkSharp.TreeSelectionFuncNative raw_ret = gtk_tree_selection_get_select_function(Handle);
				Gtk.TreeSelectionFunc ret = GtkSharp.TreeSelectionFuncWrapper.GetManagedDelegate (raw_ret);
				return ret;
			}
			set {
				GtkSharp.TreeSelectionFuncWrapper value_wrapper = new GtkSharp.TreeSelectionFuncWrapper (value);
				IntPtr data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					data = IntPtr.Zero;
					destroy = null;
				} else {
					data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_tree_selection_set_select_function(Handle, value_wrapper.NativeDelegate, data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_selection_get_selected(IntPtr raw, out IntPtr model, IntPtr iter);

		public bool GetSelected(out Gtk.ITreeModel model, out Gtk.TreeIter iter) {
			IntPtr native_model;
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			bool raw_ret = gtk_tree_selection_get_selected(Handle, out native_model, native_iter);
			bool ret = raw_ret;
			model = Gtk.TreeModelAdapter.GetObject (native_model, false);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_selection_get_selected_rows(IntPtr raw, out IntPtr model);

		public Gtk.TreePath[] GetSelectedRows(out Gtk.ITreeModel model) {
			IntPtr native_model;
			IntPtr raw_ret = gtk_tree_selection_get_selected_rows(Handle, out native_model);
			Gtk.TreePath[] ret = (Gtk.TreePath[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gtk.TreePath));
			model = Gtk.TreeModelAdapter.GetObject (native_model, false);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_selection_get_tree_view(IntPtr raw);

		public Gtk.TreeView TreeView { 
			get {
				IntPtr raw_ret = gtk_tree_selection_get_tree_view(Handle);
				Gtk.TreeView ret = GLib.Object.GetObject(raw_ret) as Gtk.TreeView;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_selection_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tree_selection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_selection_get_user_data(IntPtr raw);

		public IntPtr UserData { 
			get {
				IntPtr raw_ret = gtk_tree_selection_get_user_data(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_selection_iter_is_selected(IntPtr raw, IntPtr iter);

		public bool IterIsSelected(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_selection_iter_is_selected(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_selection_path_is_selected(IntPtr raw, IntPtr path);

		public bool PathIsSelected(Gtk.TreePath path) {
			bool raw_ret = gtk_tree_selection_path_is_selected(Handle, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_select_all(IntPtr raw);

		public void SelectAll() {
			gtk_tree_selection_select_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_select_iter(IntPtr raw, IntPtr iter);

		public void SelectIter(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_selection_select_iter(Handle, native_iter);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_select_path(IntPtr raw, IntPtr path);

		public void SelectPath(Gtk.TreePath path) {
			gtk_tree_selection_select_path(Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_select_range(IntPtr raw, IntPtr start_path, IntPtr end_path);

		public void SelectRange(Gtk.TreePath start_path, Gtk.TreePath end_path) {
			gtk_tree_selection_select_range(Handle, start_path == null ? IntPtr.Zero : start_path.Handle, end_path == null ? IntPtr.Zero : end_path.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_selected_foreach(IntPtr raw, GtkSharp.TreeSelectionForeachFuncNative func, IntPtr data);

		public void SelectedForeach(Gtk.TreeSelectionForeachFunc func) {
			GtkSharp.TreeSelectionForeachFuncWrapper func_wrapper = new GtkSharp.TreeSelectionForeachFuncWrapper (func);
			gtk_tree_selection_selected_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_unselect_all(IntPtr raw);

		public void UnselectAll() {
			gtk_tree_selection_unselect_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_unselect_iter(IntPtr raw, IntPtr iter);

		public void UnselectIter(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_selection_unselect_iter(Handle, native_iter);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_unselect_path(IntPtr raw, IntPtr path);

		public void UnselectPath(Gtk.TreePath path) {
			gtk_tree_selection_unselect_path(Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_selection_unselect_range(IntPtr raw, IntPtr start_path, IntPtr end_path);

		public void UnselectRange(Gtk.TreePath start_path, Gtk.TreePath end_path) {
			gtk_tree_selection_unselect_range(Handle, start_path == null ? IntPtr.Zero : start_path.Handle, end_path == null ? IntPtr.Zero : end_path.Handle);
		}

#endregion
	}
}
