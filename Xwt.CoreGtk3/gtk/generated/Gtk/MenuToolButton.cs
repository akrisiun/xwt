// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuToolButton : Gtk.ToolButton {

		public MenuToolButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_tool_button_new(IntPtr icon_widget, IntPtr label);

		public MenuToolButton (Gtk.Widget icon_widget, string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (icon_widget != null) {
					names.Add ("icon_widget");
					vals.Add (new GLib.Value (icon_widget));
				}
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_menu_tool_button_new(icon_widget == null ? IntPtr.Zero : icon_widget.Handle, native_label);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_tool_button_new_from_stock(IntPtr stock_id);

		public MenuToolButton (string stock_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("stock_id");
				vals.Add (new GLib.Value (stock_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_menu_tool_button_new_from_stock(native_stock_id);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_tool_button_get_menu(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_tool_button_set_menu(IntPtr raw, IntPtr menu);

		[GLib.Property ("menu")]
		public Gtk.Widget Menu {
			get  {
				IntPtr raw_ret = gtk_menu_tool_button_get_menu(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_menu_tool_button_set_menu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("show-menu")]
		public event System.EventHandler ShowMenu {
			add {
				this.AddSignalHandler ("show-menu", value);
			}
			remove {
				this.RemoveSignalHandler ("show-menu", value);
			}
		}

		static ShowMenuNativeDelegate ShowMenu_cb_delegate;
		static ShowMenuNativeDelegate ShowMenuVMCallback {
			get {
				if (ShowMenu_cb_delegate == null)
					ShowMenu_cb_delegate = new ShowMenuNativeDelegate (ShowMenu_cb);
				return ShowMenu_cb_delegate;
			}
		}

		static void OverrideShowMenu (GLib.GType gtype)
		{
			OverrideShowMenu (gtype, ShowMenuVMCallback);
		}

		static void OverrideShowMenu (GLib.GType gtype, ShowMenuNativeDelegate callback)
		{
			GtkMenuToolButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowMenu = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowMenuNativeDelegate (IntPtr inst);

		static void ShowMenu_cb (IntPtr inst)
		{
			try {
				MenuToolButton __obj = GLib.Object.GetObject (inst, false) as MenuToolButton;
				__obj.OnShowMenu ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuToolButton), ConnectionMethod="OverrideShowMenu")]
		protected virtual void OnShowMenu ()
		{
			InternalShowMenu ();
		}

		private void InternalShowMenu ()
		{
			ShowMenuNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowMenu;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkMenuToolButtonClass {
			public ShowMenuNativeDelegate ShowMenu;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.ToolButton)).GetClassSize ();
		static Dictionary<GLib.GType, GtkMenuToolButtonClass> class_structs;

		static GtkMenuToolButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkMenuToolButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkMenuToolButtonClass class_struct = (GtkMenuToolButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkMenuToolButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkMenuToolButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_tool_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_tool_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_tool_button_set_arrow_tooltip_markup(IntPtr raw, IntPtr markup);

		public string ArrowTooltipMarkup { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_tool_button_set_arrow_tooltip_markup(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_tool_button_set_arrow_tooltip_text(IntPtr raw, IntPtr text);

		public string ArrowTooltipText { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_tool_button_set_arrow_tooltip_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

#endregion
	}
}