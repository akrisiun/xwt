// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Frame : Gtk.Bin {

		public Frame (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_new(IntPtr label);

		public Frame (string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Frame)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_frame_new(native_label);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_get_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_frame_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_frame_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_frame_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("label-xalign")]
		public float LabelXalign {
			get {
				GLib.Value val = GetProperty ("label-xalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("label-xalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("label-yalign")]
		public float LabelYalign {
			get {
				GLib.Value val = GetProperty ("label-yalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("label-yalign", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_frame_get_shadow_type(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_frame_set_shadow_type(IntPtr raw, int type);

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get  {
				int raw_ret = gtk_frame_get_shadow_type(Handle);
				Gtk.ShadowType ret = (Gtk.ShadowType) raw_ret;
				return ret;
			}
			set  {
				gtk_frame_set_shadow_type(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_get_label_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_frame_set_label_widget(IntPtr raw, IntPtr label_widget);

		[GLib.Property ("label-widget")]
		public Gtk.Widget LabelWidget {
			get  {
				IntPtr raw_ret = gtk_frame_get_label_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_frame_set_label_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		static ComputeChildAllocationNativeDelegate ComputeChildAllocation_cb_delegate;
		static ComputeChildAllocationNativeDelegate ComputeChildAllocationVMCallback {
			get {
				if (ComputeChildAllocation_cb_delegate == null)
					ComputeChildAllocation_cb_delegate = new ComputeChildAllocationNativeDelegate (ComputeChildAllocation_cb);
				return ComputeChildAllocation_cb_delegate;
			}
		}

		static void OverrideComputeChildAllocation (GLib.GType gtype)
		{
			OverrideComputeChildAllocation (gtype, ComputeChildAllocationVMCallback);
		}

		static void OverrideComputeChildAllocation (GLib.GType gtype, ComputeChildAllocationNativeDelegate callback)
		{
			GtkFrameClass class_iface = GetClassStruct (gtype, false);
			class_iface.ComputeChildAllocation = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ComputeChildAllocationNativeDelegate (IntPtr inst, IntPtr allocation);

		static void ComputeChildAllocation_cb (IntPtr inst, IntPtr allocation)
		{
			try {
				Frame __obj = GLib.Object.GetObject (inst, false) as Frame;
				__obj.OnComputeChildAllocation ((Gdk.Rectangle) Marshal.PtrToStructure (allocation, typeof (Gdk.Rectangle)));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Frame), ConnectionMethod="OverrideComputeChildAllocation")]
		protected virtual void OnComputeChildAllocation (Gdk.Rectangle allocation)
		{
			InternalComputeChildAllocation (allocation);
		}

		private void InternalComputeChildAllocation (Gdk.Rectangle allocation)
		{
			ComputeChildAllocationNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ComputeChildAllocation;
			if (unmanaged == null) return;

			IntPtr native_allocation = GLib.Marshaller.StructureToPtrAlloc (allocation);
			unmanaged (this.Handle, native_allocation);
			allocation = (Gdk.Rectangle) Marshal.PtrToStructure (native_allocation, typeof (Gdk.Rectangle));
			Marshal.FreeHGlobal (native_allocation);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkFrameClass {
			public ComputeChildAllocationNativeDelegate ComputeChildAllocation;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Bin)).GetClassSize ();
		static Dictionary<GLib.GType, GtkFrameClass> class_structs;

		static GtkFrameClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkFrameClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkFrameClass class_struct = (GtkFrameClass) Marshal.PtrToStructure (class_ptr, typeof (GtkFrameClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkFrameClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_frame_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
