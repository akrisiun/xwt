// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Gradient : GLib.Opaque {

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gradient_add_color_stop(IntPtr raw, double offset, IntPtr color);

		public void AddColorStop(double offset, Gtk.SymbolicColor color) {
			gtk_gradient_add_color_stop(Handle, offset, color == null ? IntPtr.Zero : color.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gradient_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gradient_resolve(IntPtr raw, IntPtr props, IntPtr resolved_gradient);

		public bool Resolve(Gtk.StyleProperties props, Cairo.Pattern resolved_gradient) {
			bool raw_ret = gtk_gradient_resolve(Handle, props == null ? IntPtr.Zero : props.Handle, resolved_gradient.Handle);
			bool ret = raw_ret;
			return ret;
		}

		public Gradient(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_new_linear(double x0, double y0, double x1, double y1);

		public Gradient (double x0, double y0, double x1, double y1) 
		{
			Raw = gtk_gradient_new_linear(x0, y0, x1, y1);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);

		public Gradient (double x0, double y0, double radius0, double x1, double y1, double radius1) 
		{
			Raw = gtk_gradient_new_radial(x0, y0, radius0, x1, y1, radius1);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gradient_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtk_gradient_ref (raw);
				Owned = true;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gradient_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtk_gradient_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_gradient_unref (handle);
				return false;
			}
		}

		~Gradient ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}