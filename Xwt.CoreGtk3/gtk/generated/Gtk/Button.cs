// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Button : Gtk.Bin, Gtk.IActivatable {

		public Button (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_new();

		public Button () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Button)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_button_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_new_with_label(IntPtr label);

		public static Button NewWithLabel(string label)
		{
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Button result = new Button (gtk_button_new_with_label(native_label));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_new_with_mnemonic(IntPtr label);

		public static Button NewWithMnemonic(string label)
		{
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Button result = new Button (gtk_button_new_with_mnemonic(native_label));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_button_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_button_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_button_get_use_underline(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_use_underline(IntPtr raw, bool use_underline);

		[GLib.Property ("use-underline")]
		public bool UseUnderline {
			get  {
				bool raw_ret = gtk_button_get_use_underline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_button_set_use_underline(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_button_get_use_stock(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_use_stock(IntPtr raw, bool use_stock);

		[GLib.Property ("use-stock")]
		public bool UseStock {
			get  {
				bool raw_ret = gtk_button_get_use_stock(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_button_set_use_stock(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_button_get_focus_on_click(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_focus_on_click(IntPtr raw, bool focus_on_click);

		[GLib.Property ("focus-on-click")]
		public bool FocusOnClick {
			get  {
				bool raw_ret = gtk_button_get_focus_on_click(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_button_set_focus_on_click(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_button_get_relief(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_relief(IntPtr raw, int newstyle);

		[GLib.Property ("relief")]
		public Gtk.ReliefStyle Relief {
			get  {
				int raw_ret = gtk_button_get_relief(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
			set  {
				gtk_button_set_relief(Handle, (int) value);
			}
		}

		[GLib.Property ("xalign")]
		public float Xalign {
			get {
				GLib.Value val = GetProperty ("xalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("xalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("yalign")]
		public float Yalign {
			get {
				GLib.Value val = GetProperty ("yalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("yalign", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_image(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_image(IntPtr raw, IntPtr image);

		[GLib.Property ("image")]
		public Gtk.Widget Image {
			get  {
				IntPtr raw_ret = gtk_button_get_image(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_button_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_button_get_image_position(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_image_position(IntPtr raw, int position);

		[GLib.Property ("image-position")]
		public Gtk.PositionType ImagePosition {
			get  {
				int raw_ret = gtk_button_get_image_position(Handle);
				Gtk.PositionType ret = (Gtk.PositionType) raw_ret;
				return ret;
			}
			set  {
				gtk_button_set_image_position(Handle, (int) value);
			}
		}

		[GLib.Signal("released")]
		public event System.EventHandler Released {
			add {
				this.AddSignalHandler ("released", value);
			}
			remove {
				this.RemoveSignalHandler ("released", value);
			}
		}

		[GLib.Signal("clicked")]
		public event System.EventHandler Clicked {
			add {
				this.AddSignalHandler ("clicked", value);
			}
			remove {
				this.RemoveSignalHandler ("clicked", value);
			}
		}

		[GLib.Signal("activate")]
		public event System.EventHandler Activated {
			add {
				this.AddSignalHandler ("activate", value);
			}
			remove {
				this.RemoveSignalHandler ("activate", value);
			}
		}

		[GLib.Signal("leave")]
		public event System.EventHandler Left {
			add {
				this.AddSignalHandler ("leave", value);
			}
			remove {
				this.RemoveSignalHandler ("leave", value);
			}
		}

		[GLib.Signal("enter")]
		public event System.EventHandler Entered {
			add {
				this.AddSignalHandler ("enter", value);
			}
			remove {
				this.RemoveSignalHandler ("enter", value);
			}
		}

		[GLib.Signal("pressed")]
		public event System.EventHandler Pressed {
			add {
				this.AddSignalHandler ("pressed", value);
			}
			remove {
				this.RemoveSignalHandler ("pressed", value);
			}
		}

		static PressedNativeDelegate Pressed_cb_delegate;
		static PressedNativeDelegate PressedVMCallback {
			get {
				if (Pressed_cb_delegate == null)
					Pressed_cb_delegate = new PressedNativeDelegate (Pressed_cb);
				return Pressed_cb_delegate;
			}
		}

		static void OverridePressed (GLib.GType gtype)
		{
			OverridePressed (gtype, PressedVMCallback);
		}

		static void OverridePressed (GLib.GType gtype, PressedNativeDelegate callback)
		{
			GtkButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Pressed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PressedNativeDelegate (IntPtr inst);

		static void Pressed_cb (IntPtr inst)
		{
			try {
				Button __obj = GLib.Object.GetObject (inst, false) as Button;
				__obj.OnPressed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverridePressed")]
		protected virtual void OnPressed ()
		{
			InternalPressed ();
		}

		private void InternalPressed ()
		{
			PressedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Pressed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ReleasedNativeDelegate Released_cb_delegate;
		static ReleasedNativeDelegate ReleasedVMCallback {
			get {
				if (Released_cb_delegate == null)
					Released_cb_delegate = new ReleasedNativeDelegate (Released_cb);
				return Released_cb_delegate;
			}
		}

		static void OverrideReleased (GLib.GType gtype)
		{
			OverrideReleased (gtype, ReleasedVMCallback);
		}

		static void OverrideReleased (GLib.GType gtype, ReleasedNativeDelegate callback)
		{
			GtkButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Released = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReleasedNativeDelegate (IntPtr inst);

		static void Released_cb (IntPtr inst)
		{
			try {
				Button __obj = GLib.Object.GetObject (inst, false) as Button;
				__obj.OnReleased ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideReleased")]
		protected virtual void OnReleased ()
		{
			InternalReleased ();
		}

		private void InternalReleased ()
		{
			ReleasedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Released;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ClickedNativeDelegate Clicked_cb_delegate;
		static ClickedNativeDelegate ClickedVMCallback {
			get {
				if (Clicked_cb_delegate == null)
					Clicked_cb_delegate = new ClickedNativeDelegate (Clicked_cb);
				return Clicked_cb_delegate;
			}
		}

		static void OverrideClicked (GLib.GType gtype)
		{
			OverrideClicked (gtype, ClickedVMCallback);
		}

		static void OverrideClicked (GLib.GType gtype, ClickedNativeDelegate callback)
		{
			GtkButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Clicked = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ClickedNativeDelegate (IntPtr inst);

		static void Clicked_cb (IntPtr inst)
		{
			try {
				Button __obj = GLib.Object.GetObject (inst, false) as Button;
				__obj.OnClicked ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideClicked")]
		protected virtual void OnClicked ()
		{
			InternalClicked ();
		}

		private void InternalClicked ()
		{
			ClickedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Clicked;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static EnteredNativeDelegate Entered_cb_delegate;
		static EnteredNativeDelegate EnteredVMCallback {
			get {
				if (Entered_cb_delegate == null)
					Entered_cb_delegate = new EnteredNativeDelegate (Entered_cb);
				return Entered_cb_delegate;
			}
		}

		static void OverrideEntered (GLib.GType gtype)
		{
			OverrideEntered (gtype, EnteredVMCallback);
		}

		static void OverrideEntered (GLib.GType gtype, EnteredNativeDelegate callback)
		{
			GtkButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Entered = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EnteredNativeDelegate (IntPtr inst);

		static void Entered_cb (IntPtr inst)
		{
			try {
				Button __obj = GLib.Object.GetObject (inst, false) as Button;
				__obj.OnEntered ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideEntered")]
		protected virtual void OnEntered ()
		{
			InternalEntered ();
		}

		private void InternalEntered ()
		{
			EnteredNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Entered;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static LeftNativeDelegate Left_cb_delegate;
		static LeftNativeDelegate LeftVMCallback {
			get {
				if (Left_cb_delegate == null)
					Left_cb_delegate = new LeftNativeDelegate (Left_cb);
				return Left_cb_delegate;
			}
		}

		static void OverrideLeft (GLib.GType gtype)
		{
			OverrideLeft (gtype, LeftVMCallback);
		}

		static void OverrideLeft (GLib.GType gtype, LeftNativeDelegate callback)
		{
			GtkButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Left = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LeftNativeDelegate (IntPtr inst);

		static void Left_cb (IntPtr inst)
		{
			try {
				Button __obj = GLib.Object.GetObject (inst, false) as Button;
				__obj.OnLeft ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideLeft")]
		protected virtual void OnLeft ()
		{
			InternalLeft ();
		}

		private void InternalLeft ()
		{
			LeftNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Left;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ActivatedNativeDelegate Activated_cb_delegate;
		static ActivatedNativeDelegate ActivatedVMCallback {
			get {
				if (Activated_cb_delegate == null)
					Activated_cb_delegate = new ActivatedNativeDelegate (Activated_cb);
				return Activated_cb_delegate;
			}
		}

		static void OverrideActivated (GLib.GType gtype)
		{
			OverrideActivated (gtype, ActivatedVMCallback);
		}

		static void OverrideActivated (GLib.GType gtype, ActivatedNativeDelegate callback)
		{
			GtkButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Activated = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivatedNativeDelegate (IntPtr inst);

		static void Activated_cb (IntPtr inst)
		{
			try {
				Button __obj = GLib.Object.GetObject (inst, false) as Button;
				__obj.OnActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideActivated")]
		protected virtual void OnActivated ()
		{
			InternalActivated ();
		}

		private void InternalActivated ()
		{
			ActivatedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Activated;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkButtonClass {
			public PressedNativeDelegate Pressed;
			public ReleasedNativeDelegate Released;
			public ClickedNativeDelegate Clicked;
			public EnteredNativeDelegate Entered;
			public LeftNativeDelegate Left;
			public ActivatedNativeDelegate Activated;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Bin)).GetClassSize ();
		static Dictionary<GLib.GType, GtkButtonClass> class_structs;

		static GtkButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkButtonClass class_struct = (GtkButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_clicked(IntPtr raw);

		public void Click() {
			gtk_button_clicked(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_enter(IntPtr raw);

		[Obsolete]
		public void Enter() {
			gtk_button_enter(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_get_alignment(IntPtr raw, out float xalign, out float yalign);

		public void GetAlignment(out float xalign, out float yalign) {
			gtk_button_get_alignment(Handle, out xalign, out yalign);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_event_window(IntPtr raw);

		public Gdk.Window EventWindow { 
			get {
				IntPtr raw_ret = gtk_button_get_event_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_leave(IntPtr raw);

		[Obsolete]
		public void Leave() {
			gtk_button_leave(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_pressed(IntPtr raw);

		[Obsolete]
		public void Press() {
			gtk_button_pressed(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_released(IntPtr raw);

		[Obsolete]
		public void Release() {
			gtk_button_released(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_alignment(IntPtr raw, float xalign, float yalign);

		public void SetAlignment(float xalign, float yalign) {
			gtk_button_set_alignment(Handle, xalign, yalign);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_do_set_related_action(IntPtr raw, IntPtr action);

		public void DoSetRelatedAction(Gtk.Action action) {
			gtk_activatable_do_set_related_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_sync_action_properties(IntPtr raw, IntPtr action);

		public void SyncActionProperties(Gtk.Action action) {
			gtk_activatable_sync_action_properties(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_activatable_get_related_action(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_set_related_action(IntPtr raw, IntPtr action);

		[GLib.Property ("related-action")]
		public Gtk.Action RelatedAction {
			get  {
				IntPtr raw_ret = gtk_activatable_get_related_action(Handle);
				Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
				return ret;
			}
			set  {
				gtk_activatable_set_related_action(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_activatable_get_use_action_appearance(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_set_use_action_appearance(IntPtr raw, bool use_appearance);

		[GLib.Property ("use-action-appearance")]
		public bool UseActionAppearance {
			get  {
				bool raw_ret = gtk_activatable_get_use_action_appearance(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_activatable_set_use_action_appearance(Handle, value);
			}
		}

#endregion
	}
}
