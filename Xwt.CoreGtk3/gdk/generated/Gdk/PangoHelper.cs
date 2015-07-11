// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PangoHelper {

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pango_context_get();

		public static Pango.Context ContextGet() {
			IntPtr raw_ret = gdk_pango_context_get();
			Pango.Context ret = GLib.Object.GetObject(raw_ret) as Pango.Context;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pango_context_get_for_screen(IntPtr screen);

		public static Pango.Context ContextGetForScreen(Gdk.Screen screen) {
			IntPtr raw_ret = gdk_pango_context_get_for_screen(screen == null ? IntPtr.Zero : screen.Handle);
			Pango.Context ret = GLib.Object.GetObject(raw_ret) as Pango.Context;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pango_layout_get_clip_region(IntPtr layout, int x_origin, int y_origin, out int index_ranges, int n_ranges);

		public static Cairo.Region LayoutGetClipRegion(Pango.Layout layout, int x_origin, int y_origin, out int index_ranges, int n_ranges) {
			IntPtr raw_ret = gdk_pango_layout_get_clip_region(layout == null ? IntPtr.Zero : layout.Handle, x_origin, y_origin, out index_ranges, n_ranges);
			Cairo.Region ret = new Cairo.Region(raw_ret);
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pango_layout_line_get_clip_region(IntPtr line, int x_origin, int y_origin, out int index_ranges, int n_ranges);

		public static Cairo.Region LayoutLineGetClipRegion(Pango.LayoutLine line, int x_origin, int y_origin, out int index_ranges, int n_ranges) {
			IntPtr raw_ret = gdk_pango_layout_line_get_clip_region(line == null ? IntPtr.Zero : line.Handle, x_origin, y_origin, out index_ranges, n_ranges);
			Cairo.Region ret = new Cairo.Region(raw_ret);
			return ret;
		}

#endregion
	}
}
