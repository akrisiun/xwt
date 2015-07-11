// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CheckButton : Gtk.ToggleButton {

		public CheckButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_check_button_new();

		public CheckButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CheckButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_check_button_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_check_button_new_with_label(IntPtr label);

		public static new CheckButton NewWithLabel(string label)
		{
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			CheckButton result = new CheckButton (gtk_check_button_new_with_label(native_label));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_check_button_new_with_mnemonic(IntPtr label);

		public CheckButton (string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CheckButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_check_button_new_with_mnemonic(native_label);
			GLib.Marshaller.Free (native_label);
		}

		static DrawIndicatorNativeDelegate DrawIndicator_cb_delegate;
		static DrawIndicatorNativeDelegate DrawIndicatorVMCallback {
			get {
				if (DrawIndicator_cb_delegate == null)
					DrawIndicator_cb_delegate = new DrawIndicatorNativeDelegate (DrawIndicator_cb);
				return DrawIndicator_cb_delegate;
			}
		}

		static void OverrideDrawIndicator (GLib.GType gtype)
		{
			OverrideDrawIndicator (gtype, DrawIndicatorVMCallback);
		}

		static void OverrideDrawIndicator (GLib.GType gtype, DrawIndicatorNativeDelegate callback)
		{
			GtkCheckButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.DrawIndicator = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawIndicatorNativeDelegate (IntPtr inst, IntPtr cr);

		static void DrawIndicator_cb (IntPtr inst, IntPtr cr)
		{
			Cairo.Context mycr = null;

			try {
				CheckButton __obj = GLib.Object.GetObject (inst, false) as CheckButton;
				mycr = new Cairo.Context (cr, false);
				__obj.OnDrawIndicator (mycr);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			} finally {
				var disposable_cr = mycr as IDisposable;
				if (disposable_cr != null)
					disposable_cr.Dispose ();
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CheckButton), ConnectionMethod="OverrideDrawIndicator")]
		protected virtual void OnDrawIndicator (Cairo.Context cr)
		{
			InternalDrawIndicator (cr);
		}

		private void InternalDrawIndicator (Cairo.Context cr)
		{
			DrawIndicatorNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DrawIndicator;
			if (unmanaged == null) return;

			unmanaged (this.Handle, cr == null ? IntPtr.Zero : cr.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkCheckButtonClass {
			public DrawIndicatorNativeDelegate DrawIndicator;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.ToggleButton)).GetClassSize ();
		static Dictionary<GLib.GType, GtkCheckButtonClass> class_structs;

		static GtkCheckButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkCheckButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkCheckButtonClass class_struct = (GtkCheckButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkCheckButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkCheckButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_check_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_check_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
