// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Printer : GLib.Object {

		public Printer (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_new(IntPtr name, IntPtr backend, bool virtual_);

		public Printer (string name, Gtk.PrintBackend backend, bool virtual_) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Printer)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gtk_printer_new(native_name, backend == null ? IntPtr.Zero : backend.Handle, virtual_);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_name(IntPtr raw);

		[GLib.Property ("name")]
		public string Name {
			get  {
				IntPtr raw_ret = gtk_printer_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_backend(IntPtr raw);

		[GLib.Property ("backend")]
		public Gtk.PrintBackend Backend {
			get  {
				IntPtr raw_ret = gtk_printer_get_backend(Handle);
				Gtk.PrintBackend ret = raw_ret == IntPtr.Zero ? null : (Gtk.PrintBackend) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.PrintBackend), false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_is_virtual(IntPtr raw);

		[GLib.Property ("is-virtual")]
		public bool IsVirtual {
			get  {
				bool raw_ret = gtk_printer_is_virtual(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_accepts_pdf(IntPtr raw);

		[GLib.Property ("accepts-pdf")]
		public bool AcceptsPdf {
			get  {
				bool raw_ret = gtk_printer_accepts_pdf(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_accepts_ps(IntPtr raw);

		[GLib.Property ("accepts-ps")]
		public bool AcceptsPs {
			get  {
				bool raw_ret = gtk_printer_accepts_ps(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_state_message(IntPtr raw);

		[GLib.Property ("state-message")]
		public string StateMessage {
			get  {
				IntPtr raw_ret = gtk_printer_get_state_message(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_location(IntPtr raw);

		[GLib.Property ("location")]
		public string Location {
			get  {
				IntPtr raw_ret = gtk_printer_get_location(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_icon_name(IntPtr raw);

		[GLib.Property ("icon-name")]
		public string IconName {
			get  {
				IntPtr raw_ret = gtk_printer_get_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_printer_get_job_count(IntPtr raw);

		[GLib.Property ("job-count")]
		public int JobCount {
			get  {
				int raw_ret = gtk_printer_get_job_count(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[GLib.Property ("paused")]
		public bool Paused {
			get {
				GLib.Value val = GetProperty ("paused");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("accepting-jobs")]
		public bool AcceptingJobs {
			get {
				GLib.Value val = GetProperty ("accepting-jobs");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("details-acquired")]
		public event Gtk.DetailsAcquiredHandler DetailsAcquired {
			add {
				this.AddSignalHandler ("details-acquired", value, typeof (Gtk.DetailsAcquiredArgs));
			}
			remove {
				this.RemoveSignalHandler ("details-acquired", value);
			}
		}

		static DetailsAcquiredNativeDelegate DetailsAcquired_cb_delegate;
		static DetailsAcquiredNativeDelegate DetailsAcquiredVMCallback {
			get {
				if (DetailsAcquired_cb_delegate == null)
					DetailsAcquired_cb_delegate = new DetailsAcquiredNativeDelegate (DetailsAcquired_cb);
				return DetailsAcquired_cb_delegate;
			}
		}

		static void OverrideDetailsAcquired (GLib.GType gtype)
		{
			OverrideDetailsAcquired (gtype, DetailsAcquiredVMCallback);
		}

		static void OverrideDetailsAcquired (GLib.GType gtype, DetailsAcquiredNativeDelegate callback)
		{
			GtkPrinterClass class_iface = GetClassStruct (gtype, false);
			class_iface.DetailsAcquired = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DetailsAcquiredNativeDelegate (IntPtr inst, bool success);

		static void DetailsAcquired_cb (IntPtr inst, bool success)
		{
			try {
				Printer __obj = GLib.Object.GetObject (inst, false) as Printer;
				__obj.OnDetailsAcquired (success);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Printer), ConnectionMethod="OverrideDetailsAcquired")]
		protected virtual void OnDetailsAcquired (bool success)
		{
			InternalDetailsAcquired (success);
		}

		private void InternalDetailsAcquired (bool success)
		{
			DetailsAcquiredNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DetailsAcquired;
			if (unmanaged == null) return;

			unmanaged (this.Handle, success);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkPrinterClass {
			public DetailsAcquiredNativeDelegate DetailsAcquired;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
			IntPtr GtkReserved5;
			IntPtr GtkReserved6;
			IntPtr GtkReserved7;
			IntPtr GtkReserved8;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkPrinterClass> class_structs;

		static GtkPrinterClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkPrinterClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkPrinterClass class_struct = (GtkPrinterClass) Marshal.PtrToStructure (class_ptr, typeof (GtkPrinterClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkPrinterClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_printer_compare(IntPtr raw, IntPtr b);

		public int Compare(Gtk.Printer b) {
			int raw_ret = gtk_printer_compare(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_printer_get_capabilities(IntPtr raw);

		public Gtk.PrintCapabilities Capabilities { 
			get {
				int raw_ret = gtk_printer_get_capabilities(Handle);
				Gtk.PrintCapabilities ret = (Gtk.PrintCapabilities) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_default_page_size(IntPtr raw);

		public Gtk.PageSetup DefaultPageSize { 
			get {
				IntPtr raw_ret = gtk_printer_get_default_page_size(Handle);
				Gtk.PageSetup ret = GLib.Object.GetObject(raw_ret) as Gtk.PageSetup;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_description(IntPtr raw);

		public string Description { 
			get {
				IntPtr raw_ret = gtk_printer_get_description(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_get_hard_margins(IntPtr raw, out double top, out double bottom, out double left, out double right);

		public bool GetHardMargins(out double top, out double bottom, out double left, out double right) {
			bool raw_ret = gtk_printer_get_hard_margins(Handle, out top, out bottom, out left, out right);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_printer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_has_details(IntPtr raw);

		public bool HasDetails { 
			get {
				bool raw_ret = gtk_printer_has_details(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_is_accepting_jobs(IntPtr raw);

		public bool IsAcceptingJobs { 
			get {
				bool raw_ret = gtk_printer_is_accepting_jobs(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_is_active(IntPtr raw);

		public bool IsActive { 
			get {
				bool raw_ret = gtk_printer_is_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_is_default(IntPtr raw);

		public bool IsDefault { 
			get {
				bool raw_ret = gtk_printer_is_default(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_printer_is_paused(IntPtr raw);

		public bool IsPaused { 
			get {
				bool raw_ret = gtk_printer_is_paused(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_printer_list_papers(IntPtr raw);

		public Gtk.PageSetup[] ListPapers() {
			IntPtr raw_ret = gtk_printer_list_papers(Handle);
			Gtk.PageSetup[] ret = (Gtk.PageSetup[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gtk.PageSetup));
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_printer_request_details(IntPtr raw);

		public void RequestDetails() {
			gtk_printer_request_details(Handle);
		}

#endregion
	}
}