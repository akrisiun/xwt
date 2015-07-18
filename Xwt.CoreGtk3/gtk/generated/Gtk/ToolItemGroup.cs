// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ToolItemGroup : Gtk.Container, Gtk.IToolShell {

		public ToolItemGroup (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_group_new(IntPtr label);

		public ToolItemGroup (string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToolItemGroup)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_tool_item_group_new(native_label);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_group_get_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_tool_item_group_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_tool_item_group_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_group_get_label_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_set_label_widget(IntPtr raw, IntPtr label_widget);

		[GLib.Property ("label-widget")]
		public Gtk.Widget LabelWidget {
			get  {
				IntPtr raw_ret = gtk_tool_item_group_get_label_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_tool_item_group_set_label_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_group_get_collapsed(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_set_collapsed(IntPtr raw, bool collapsed);

		[GLib.Property ("collapsed")]
		public bool Collapsed {
			get  {
				bool raw_ret = gtk_tool_item_group_get_collapsed(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tool_item_group_set_collapsed(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_group_get_ellipsize(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_set_ellipsize(IntPtr raw, int ellipsize);

		[GLib.Property ("ellipsize")]
		public Pango.EllipsizeMode Ellipsize {
			get  {
				int raw_ret = gtk_tool_item_group_get_ellipsize(Handle);
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) raw_ret;
				return ret;
			}
			set  {
				gtk_tool_item_group_set_ellipsize(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_group_get_header_relief(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_set_header_relief(IntPtr raw, int style);

		[GLib.Property ("header-relief")]
		public Gtk.ReliefStyle HeaderRelief {
			get  {
				int raw_ret = gtk_tool_item_group_get_header_relief(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
			set  {
				gtk_tool_item_group_set_header_relief(Handle, (int) value);
			}
		}

		public class ToolItemGroupChild : Gtk.Container.ContainerChild {
			protected internal ToolItemGroupChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("homogeneous")]
			public bool Homogeneous {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "homogeneous");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "homogeneous", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("expand")]
			public bool Expand {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "expand");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "expand", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("fill")]
			public bool Fill {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "fill");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "fill", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("new-row")]
			public bool NewRow {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "new-row");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "new-row", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("position")]
			public int Position {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "position");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "position", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new ToolItemGroupChild (this, child);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkToolItemGroupClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Container)).GetClassSize ();
		static Dictionary<GLib.GType, GtkToolItemGroupClass> class_structs;

		static GtkToolItemGroupClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkToolItemGroupClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkToolItemGroupClass class_struct = (GtkToolItemGroupClass) Marshal.PtrToStructure (class_ptr, typeof (GtkToolItemGroupClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkToolItemGroupClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_group_get_drop_item(IntPtr raw, int x, int y);

		public Gtk.ToolItem GetDropItem(int x, int y) {
			IntPtr raw_ret = gtk_tool_item_group_get_drop_item(Handle, x, y);
			Gtk.ToolItem ret = GLib.Object.GetObject(raw_ret) as Gtk.ToolItem;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_group_get_item_position(IntPtr raw, IntPtr item);

		public int GetItemPosition(Gtk.ToolItem item) {
			int raw_ret = gtk_tool_item_group_get_item_position(Handle, item == null ? IntPtr.Zero : item.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_tool_item_group_get_n_items(IntPtr raw);

		public uint NItems { 
			get {
				uint raw_ret = gtk_tool_item_group_get_n_items(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_group_get_nth_item(IntPtr raw, uint index);

		public Gtk.ToolItem GetNthItem(uint index) {
			IntPtr raw_ret = gtk_tool_item_group_get_nth_item(Handle, index);
			Gtk.ToolItem ret = GLib.Object.GetObject(raw_ret) as Gtk.ToolItem;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_group_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tool_item_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_insert(IntPtr raw, IntPtr item, int position);

		public void Insert(Gtk.ToolItem item, int position) {
			gtk_tool_item_group_insert(Handle, item == null ? IntPtr.Zero : item.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_group_set_item_position(IntPtr raw, IntPtr item, int position);

		public void SetItemPosition(Gtk.ToolItem item, int position) {
			gtk_tool_item_group_set_item_position(Handle, item == null ? IntPtr.Zero : item.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_shell_get_ellipsize_mode(IntPtr raw);

		public Pango.EllipsizeMode EllipsizeMode { 
			get {
				int raw_ret = gtk_tool_shell_get_ellipsize_mode(Handle);
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_shell_get_icon_size(IntPtr raw);

		public Gtk.IconSize IconSize { 
			get {
				int raw_ret = gtk_tool_shell_get_icon_size(Handle);
				Gtk.IconSize ret = (Gtk.IconSize) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_shell_get_orientation(IntPtr raw);

		public Gtk.Orientation Orientation { 
			get {
				int raw_ret = gtk_tool_shell_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_shell_get_relief_style(IntPtr raw);

		public Gtk.ReliefStyle ReliefStyle { 
			get {
				int raw_ret = gtk_tool_shell_get_relief_style(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_shell_get_style(IntPtr raw);

		public Gtk.ToolbarStyle Style { 
			get {
				int raw_ret = gtk_tool_shell_get_style(Handle);
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern float gtk_tool_shell_get_text_alignment(IntPtr raw);

		public float TextAlignment { 
			get {
				float raw_ret = gtk_tool_shell_get_text_alignment(Handle);
				float ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_shell_get_text_orientation(IntPtr raw);

		public Gtk.Orientation TextOrientation { 
			get {
				int raw_ret = gtk_tool_shell_get_text_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_shell_get_text_size_group(IntPtr raw);

		public Gtk.SizeGroup TextSizeGroup { 
			get {
				IntPtr raw_ret = gtk_tool_shell_get_text_size_group(Handle);
				Gtk.SizeGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.SizeGroup;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_shell_rebuild_menu(IntPtr raw);

		public void RebuildMenu() {
			gtk_tool_shell_rebuild_menu(Handle);
		}

#endregion
	}
}
