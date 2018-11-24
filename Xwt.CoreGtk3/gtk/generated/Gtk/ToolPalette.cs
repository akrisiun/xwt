// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ToolPalette : Gtk.Container, Gtk.IOrientable, Gtk.IScrollable {

		public ToolPalette (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_new();

		public ToolPalette () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToolPalette)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_tool_palette_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_palette_get_icon_size(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_set_icon_size(IntPtr raw, int icon_size);

		[GLib.Property ("icon-size")]
		public Gtk.IconSize IconSize {
			get  {
				int raw_ret = gtk_tool_palette_get_icon_size(Handle);
				Gtk.IconSize ret = (Gtk.IconSize) raw_ret;
				return ret;
			}
			set  {
				gtk_tool_palette_set_icon_size(Handle, (int) value);
			}
		}

		[GLib.Property ("icon-size-set")]
		public bool IconSizeSet {
			get {
				GLib.Value val = GetProperty ("icon-size-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("icon-size-set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("toolbar-style")]
		public Gtk.ToolbarStyle ToolbarStyle {
			get {
				GLib.Value val = GetProperty ("toolbar-style");
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("toolbar-style", val);
				val.Dispose ();
			}
		}

		public class ToolPaletteChild : Gtk.Container.ContainerChild {
			protected internal ToolPaletteChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("exclusive")]
			public bool Exclusive {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "exclusive");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "exclusive", val);
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

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new ToolPaletteChild (this, child);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkToolPaletteClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Container)).GetClassSize ();
		static Dictionary<GLib.GType, GtkToolPaletteClass> class_structs;

		static GtkToolPaletteClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkToolPaletteClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkToolPaletteClass class_struct = (GtkToolPaletteClass) Marshal.PtrToStructure (class_ptr, typeof (GtkToolPaletteClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkToolPaletteClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_add_drag_dest(IntPtr raw, IntPtr widget, int flags, int targets, int actions);

		public void AddDragDest(Gtk.Widget widget, Gtk.DestDefaults flags, Gtk.ToolPaletteDragTargets targets, Gdk.DragAction actions) {
			gtk_tool_palette_add_drag_dest(Handle, widget == null ? IntPtr.Zero : widget.Handle, (int) flags, (int) targets, (int) actions);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_get_drag_item(IntPtr raw, IntPtr selection);

		public Gtk.Widget GetDragItem(Gtk.SelectionData selection) {
			IntPtr raw_ret = gtk_tool_palette_get_drag_item(Handle, selection == null ? IntPtr.Zero : selection.Handle);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_get_drag_target_group();

		public static Gtk.TargetEntry DragTargetGroup { 
			get {
				IntPtr raw_ret = gtk_tool_palette_get_drag_target_group();
				Gtk.TargetEntry ret = Gtk.TargetEntry.New (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_get_drag_target_item();

		public static Gtk.TargetEntry DragTargetItem { 
			get {
				IntPtr raw_ret = gtk_tool_palette_get_drag_target_item();
				Gtk.TargetEntry ret = Gtk.TargetEntry.New (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_get_drop_group(IntPtr raw, int x, int y);

		public Gtk.ToolItemGroup GetDropGroup(int x, int y) {
			IntPtr raw_ret = gtk_tool_palette_get_drop_group(Handle, x, y);
			Gtk.ToolItemGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.ToolItemGroup;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_get_drop_item(IntPtr raw, int x, int y);

		public Gtk.ToolItem GetDropItem(int x, int y) {
			IntPtr raw_ret = gtk_tool_palette_get_drop_item(Handle, x, y);
			Gtk.ToolItem ret = GLib.Object.GetObject(raw_ret) as Gtk.ToolItem;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_palette_get_exclusive(IntPtr raw, IntPtr group);

		public bool GetExclusive(Gtk.ToolItemGroup group) {
			bool raw_ret = gtk_tool_palette_get_exclusive(Handle, group == null ? IntPtr.Zero : group.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_palette_get_expand(IntPtr raw, IntPtr group);

		public bool GetExpand(Gtk.ToolItemGroup group) {
			bool raw_ret = gtk_tool_palette_get_expand(Handle, group == null ? IntPtr.Zero : group.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_palette_get_group_position(IntPtr raw, IntPtr group);

		public int GetGroupPosition(Gtk.ToolItemGroup group) {
			int raw_ret = gtk_tool_palette_get_group_position(Handle, group == null ? IntPtr.Zero : group.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_palette_get_style(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_set_style(IntPtr raw, int style);

		public Gtk.ToolbarStyle Style { 
			get {
				int raw_ret = gtk_tool_palette_get_style(Handle);
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) raw_ret;
				return ret;
			}
			set {
				gtk_tool_palette_set_style(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_palette_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tool_palette_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_set_drag_source(IntPtr raw, int targets);

		public Gtk.ToolPaletteDragTargets DragSource { 
			set {
				gtk_tool_palette_set_drag_source(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_set_exclusive(IntPtr raw, IntPtr group, bool exclusive);

		public void SetExclusive(Gtk.ToolItemGroup group, bool exclusive) {
			gtk_tool_palette_set_exclusive(Handle, group == null ? IntPtr.Zero : group.Handle, exclusive);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_set_expand(IntPtr raw, IntPtr group, bool expand);

		public void SetExpand(Gtk.ToolItemGroup group, bool expand) {
			gtk_tool_palette_set_expand(Handle, group == null ? IntPtr.Zero : group.Handle, expand);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_set_group_position(IntPtr raw, IntPtr group, int position);

		public void SetGroupPosition(Gtk.ToolItemGroup group, int position) {
			gtk_tool_palette_set_group_position(Handle, group == null ? IntPtr.Zero : group.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_unset_icon_size(IntPtr raw);

		public void UnsetIconSize() {
			gtk_tool_palette_unset_icon_size(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_palette_unset_style(IntPtr raw);

		public void UnsetStyle() {
			gtk_tool_palette_unset_style(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_orientable_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_orientable_set_orientation(IntPtr raw, int orientation);

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_hadjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hadjustment(IntPtr raw, IntPtr hadjustment);

		[GLib.Property ("hadjustment")]
		public Gtk.Adjustment Hadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_hadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_hadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scrollable_get_vadjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vadjustment(IntPtr raw, IntPtr vadjustment);

		[GLib.Property ("vadjustment")]
		public Gtk.Adjustment Vadjustment {
			get  {
				IntPtr raw_ret = gtk_scrollable_get_vadjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scrollable_set_vadjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_hscroll_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_hscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("hscroll-policy")]
		public Gtk.ScrollablePolicy HscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_hscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_hscroll_policy(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_scrollable_get_vscroll_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scrollable_set_vscroll_policy(IntPtr raw, int policy);

		[GLib.Property ("vscroll-policy")]
		public Gtk.ScrollablePolicy VscrollPolicy {
			get  {
				int raw_ret = gtk_scrollable_get_vscroll_policy(Handle);
				Gtk.ScrollablePolicy ret = (Gtk.ScrollablePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_scrollable_set_vscroll_policy(Handle, (int) value);
			}
		}

#endregion
	}
}