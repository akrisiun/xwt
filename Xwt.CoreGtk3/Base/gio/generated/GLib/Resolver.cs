// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Resolver : GLib.Object {

		public Resolver (IntPtr raw) : base(raw) {}

		protected Resolver() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("reload")]
		public event System.EventHandler Reload {
			add {
				this.AddSignalHandler ("reload", value);
			}
			remove {
				this.RemoveSignalHandler ("reload", value);
			}
		}

		static ReloadNativeDelegate Reload_cb_delegate;
		static ReloadNativeDelegate ReloadVMCallback {
			get {
				if (Reload_cb_delegate == null)
					Reload_cb_delegate = new ReloadNativeDelegate (Reload_cb);
				return Reload_cb_delegate;
			}
		}

		static void OverrideReload (GLib.GType gtype)
		{
			OverrideReload (gtype, ReloadVMCallback);
		}

		static void OverrideReload (GLib.GType gtype, ReloadNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.Reload = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReloadNativeDelegate (IntPtr inst);

		static void Reload_cb (IntPtr inst)
		{
			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				__obj.OnReload ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideReload")]
		protected virtual void OnReload ()
		{
			InternalReload ();
		}

		private void InternalReload ()
		{
			ReloadNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Reload;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static LookupByNameNativeDelegate LookupByName_cb_delegate;
		static LookupByNameNativeDelegate LookupByNameVMCallback {
			get {
				if (LookupByName_cb_delegate == null)
					LookupByName_cb_delegate = new LookupByNameNativeDelegate (LookupByName_cb);
				return LookupByName_cb_delegate;
			}
		}

		static void OverrideLookupByName (GLib.GType gtype)
		{
			OverrideLookupByName (gtype, LookupByNameVMCallback);
		}

		static void OverrideLookupByName (GLib.GType gtype, LookupByNameNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupByName = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupByNameNativeDelegate (IntPtr inst, IntPtr hostname, IntPtr cancellable, out IntPtr error);

		static IntPtr LookupByName_cb (IntPtr inst, IntPtr hostname, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLib.InetAddress[] __result;
				__result = __obj.OnLookupByName (GLib.Marshaller.Utf8PtrToString (hostname), GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return new GLib.List(__result, typeof (GLib.InetAddress), true, true) == null ? IntPtr.Zero : new GLib.List(__result, typeof (GLib.InetAddress), true, true).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupByName")]
		protected virtual GLib.InetAddress[] OnLookupByName (string hostname, GLib.Cancellable cancellable)
		{
			return InternalLookupByName (hostname, cancellable);
		}

		private GLib.InetAddress[] InternalLookupByName (string hostname, GLib.Cancellable cancellable)
		{
			LookupByNameNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupByName;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, native_hostname, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.Marshaller.Free (native_hostname);
			return (GLib.InetAddress[]) GLib.Marshaller.ListPtrToArray (__result, typeof(GLib.List), true, true, typeof(GLib.InetAddress));
		}

		static LookupByNameAsyncNativeDelegate LookupByNameAsync_cb_delegate;
		static LookupByNameAsyncNativeDelegate LookupByNameAsyncVMCallback {
			get {
				if (LookupByNameAsync_cb_delegate == null)
					LookupByNameAsync_cb_delegate = new LookupByNameAsyncNativeDelegate (LookupByNameAsync_cb);
				return LookupByNameAsync_cb_delegate;
			}
		}

		static void OverrideLookupByNameAsync (GLib.GType gtype)
		{
			OverrideLookupByNameAsync (gtype, LookupByNameAsyncVMCallback);
		}

		static void OverrideLookupByNameAsync (GLib.GType gtype, LookupByNameAsyncNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupByNameAsync = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LookupByNameAsyncNativeDelegate (IntPtr inst, IntPtr hostname, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void LookupByNameAsync_cb (IntPtr inst, IntPtr hostname, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnLookupByNameAsync (GLib.Marshaller.Utf8PtrToString (hostname), GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupByNameAsync")]
		protected virtual void OnLookupByNameAsync (string hostname, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalLookupByNameAsync (hostname, cancellable, cb);
		}

		private void InternalLookupByNameAsync (string hostname, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			LookupByNameAsyncNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupByNameAsync;
			if (unmanaged == null) return;

			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, native_hostname, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_hostname);
		}

		static LookupByNameFinishNativeDelegate LookupByNameFinish_cb_delegate;
		static LookupByNameFinishNativeDelegate LookupByNameFinishVMCallback {
			get {
				if (LookupByNameFinish_cb_delegate == null)
					LookupByNameFinish_cb_delegate = new LookupByNameFinishNativeDelegate (LookupByNameFinish_cb);
				return LookupByNameFinish_cb_delegate;
			}
		}

		static void OverrideLookupByNameFinish (GLib.GType gtype)
		{
			OverrideLookupByNameFinish (gtype, LookupByNameFinishVMCallback);
		}

		static void OverrideLookupByNameFinish (GLib.GType gtype, LookupByNameFinishNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupByNameFinish = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupByNameFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr LookupByNameFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLib.InetAddress[] __result;
				__result = __obj.OnLookupByNameFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return new GLib.List(__result, typeof (GLib.InetAddress), true, true) == null ? IntPtr.Zero : new GLib.List(__result, typeof (GLib.InetAddress), true, true).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupByNameFinish")]
		protected virtual GLib.InetAddress[] OnLookupByNameFinish (GLib.IAsyncResult result)
		{
			return InternalLookupByNameFinish (result);
		}

		private GLib.InetAddress[] InternalLookupByNameFinish (GLib.IAsyncResult result)
		{
			LookupByNameFinishNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupByNameFinish;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (GLib.InetAddress[]) GLib.Marshaller.ListPtrToArray (__result, typeof(GLib.List), true, true, typeof(GLib.InetAddress));
		}

		static LookupByAddressNativeDelegate LookupByAddress_cb_delegate;
		static LookupByAddressNativeDelegate LookupByAddressVMCallback {
			get {
				if (LookupByAddress_cb_delegate == null)
					LookupByAddress_cb_delegate = new LookupByAddressNativeDelegate (LookupByAddress_cb);
				return LookupByAddress_cb_delegate;
			}
		}

		static void OverrideLookupByAddress (GLib.GType gtype)
		{
			OverrideLookupByAddress (gtype, LookupByAddressVMCallback);
		}

		static void OverrideLookupByAddress (GLib.GType gtype, LookupByAddressNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupByAddress = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupByAddressNativeDelegate (IntPtr inst, IntPtr address, IntPtr cancellable, out IntPtr error);

		static IntPtr LookupByAddress_cb (IntPtr inst, IntPtr address, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				string __result;
				__result = __obj.OnLookupByAddress (GLib.Object.GetObject(address) as GLib.InetAddress, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupByAddress")]
		protected virtual string OnLookupByAddress (GLib.InetAddress address, GLib.Cancellable cancellable)
		{
			return InternalLookupByAddress (address, cancellable);
		}

		private string InternalLookupByAddress (GLib.InetAddress address, GLib.Cancellable cancellable)
		{
			LookupByAddressNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupByAddress;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, address == null ? IntPtr.Zero : address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static LookupByAddressAsyncNativeDelegate LookupByAddressAsync_cb_delegate;
		static LookupByAddressAsyncNativeDelegate LookupByAddressAsyncVMCallback {
			get {
				if (LookupByAddressAsync_cb_delegate == null)
					LookupByAddressAsync_cb_delegate = new LookupByAddressAsyncNativeDelegate (LookupByAddressAsync_cb);
				return LookupByAddressAsync_cb_delegate;
			}
		}

		static void OverrideLookupByAddressAsync (GLib.GType gtype)
		{
			OverrideLookupByAddressAsync (gtype, LookupByAddressAsyncVMCallback);
		}

		static void OverrideLookupByAddressAsync (GLib.GType gtype, LookupByAddressAsyncNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupByAddressAsync = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LookupByAddressAsyncNativeDelegate (IntPtr inst, IntPtr address, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void LookupByAddressAsync_cb (IntPtr inst, IntPtr address, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnLookupByAddressAsync (GLib.Object.GetObject(address) as GLib.InetAddress, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupByAddressAsync")]
		protected virtual void OnLookupByAddressAsync (GLib.InetAddress address, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalLookupByAddressAsync (address, cancellable, cb);
		}

		private void InternalLookupByAddressAsync (GLib.InetAddress address, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			LookupByAddressAsyncNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupByAddressAsync;
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, address == null ? IntPtr.Zero : address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static LookupByAddressFinishNativeDelegate LookupByAddressFinish_cb_delegate;
		static LookupByAddressFinishNativeDelegate LookupByAddressFinishVMCallback {
			get {
				if (LookupByAddressFinish_cb_delegate == null)
					LookupByAddressFinish_cb_delegate = new LookupByAddressFinishNativeDelegate (LookupByAddressFinish_cb);
				return LookupByAddressFinish_cb_delegate;
			}
		}

		static void OverrideLookupByAddressFinish (GLib.GType gtype)
		{
			OverrideLookupByAddressFinish (gtype, LookupByAddressFinishVMCallback);
		}

		static void OverrideLookupByAddressFinish (GLib.GType gtype, LookupByAddressFinishNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupByAddressFinish = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupByAddressFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr LookupByAddressFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				string __result;
				__result = __obj.OnLookupByAddressFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupByAddressFinish")]
		protected virtual string OnLookupByAddressFinish (GLib.IAsyncResult result)
		{
			return InternalLookupByAddressFinish (result);
		}

		private string InternalLookupByAddressFinish (GLib.IAsyncResult result)
		{
			LookupByAddressFinishNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupByAddressFinish;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static LookupServiceNativeDelegate LookupService_cb_delegate;
		static LookupServiceNativeDelegate LookupServiceVMCallback {
			get {
				if (LookupService_cb_delegate == null)
					LookupService_cb_delegate = new LookupServiceNativeDelegate (LookupService_cb);
				return LookupService_cb_delegate;
			}
		}

		static void OverrideLookupService (GLib.GType gtype)
		{
			OverrideLookupService (gtype, LookupServiceVMCallback);
		}

		static void OverrideLookupService (GLib.GType gtype, LookupServiceNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupService = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupServiceNativeDelegate (IntPtr inst, IntPtr rrname, IntPtr cancellable, out IntPtr error);

		static IntPtr LookupService_cb (IntPtr inst, IntPtr rrname, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLib.SrvTarget[] __result;
				__result = __obj.OnLookupService (GLib.Marshaller.Utf8PtrToString (rrname), GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return new GLib.List(__result, typeof (GLib.SrvTarget), true, true) == null ? IntPtr.Zero : new GLib.List(__result, typeof (GLib.SrvTarget), true, true).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupService")]
		protected virtual GLib.SrvTarget[] OnLookupService (string rrname, GLib.Cancellable cancellable)
		{
			return InternalLookupService (rrname, cancellable);
		}

		private GLib.SrvTarget[] InternalLookupService (string rrname, GLib.Cancellable cancellable)
		{
			LookupServiceNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupService;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr native_rrname = GLib.Marshaller.StringToPtrGStrdup (rrname);
			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, native_rrname, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.Marshaller.Free (native_rrname);
			return (GLib.SrvTarget[]) GLib.Marshaller.ListPtrToArray (__result, typeof(GLib.List), true, true, typeof(GLib.SrvTarget));
		}

		static LookupServiceAsyncNativeDelegate LookupServiceAsync_cb_delegate;
		static LookupServiceAsyncNativeDelegate LookupServiceAsyncVMCallback {
			get {
				if (LookupServiceAsync_cb_delegate == null)
					LookupServiceAsync_cb_delegate = new LookupServiceAsyncNativeDelegate (LookupServiceAsync_cb);
				return LookupServiceAsync_cb_delegate;
			}
		}

		static void OverrideLookupServiceAsync (GLib.GType gtype)
		{
			OverrideLookupServiceAsync (gtype, LookupServiceAsyncVMCallback);
		}

		static void OverrideLookupServiceAsync (GLib.GType gtype, LookupServiceAsyncNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupServiceAsync = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LookupServiceAsyncNativeDelegate (IntPtr inst, IntPtr rrname, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void LookupServiceAsync_cb (IntPtr inst, IntPtr rrname, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnLookupServiceAsync (GLib.Marshaller.Utf8PtrToString (rrname), GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupServiceAsync")]
		protected virtual void OnLookupServiceAsync (string rrname, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalLookupServiceAsync (rrname, cancellable, cb);
		}

		private void InternalLookupServiceAsync (string rrname, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			LookupServiceAsyncNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupServiceAsync;
			if (unmanaged == null) return;

			IntPtr native_rrname = GLib.Marshaller.StringToPtrGStrdup (rrname);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, native_rrname, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_rrname);
		}

		static LookupServiceFinishNativeDelegate LookupServiceFinish_cb_delegate;
		static LookupServiceFinishNativeDelegate LookupServiceFinishVMCallback {
			get {
				if (LookupServiceFinish_cb_delegate == null)
					LookupServiceFinish_cb_delegate = new LookupServiceFinishNativeDelegate (LookupServiceFinish_cb);
				return LookupServiceFinish_cb_delegate;
			}
		}

		static void OverrideLookupServiceFinish (GLib.GType gtype)
		{
			OverrideLookupServiceFinish (gtype, LookupServiceFinishVMCallback);
		}

		static void OverrideLookupServiceFinish (GLib.GType gtype, LookupServiceFinishNativeDelegate callback)
		{
			GResolverClass class_iface = GetClassStruct (gtype, false);
			class_iface.LookupServiceFinish = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupServiceFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr LookupServiceFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				Resolver __obj = GLib.Object.GetObject (inst, false) as Resolver;
				GLib.SrvTarget[] __result;
				__result = __obj.OnLookupServiceFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return new GLib.List(__result, typeof (GLib.SrvTarget), true, true) == null ? IntPtr.Zero : new GLib.List(__result, typeof (GLib.SrvTarget), true, true).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Resolver), ConnectionMethod="OverrideLookupServiceFinish")]
		protected virtual GLib.SrvTarget[] OnLookupServiceFinish (GLib.IAsyncResult result)
		{
			return InternalLookupServiceFinish (result);
		}

		private GLib.SrvTarget[] InternalLookupServiceFinish (GLib.IAsyncResult result)
		{
			LookupServiceFinishNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LookupServiceFinish;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (GLib.SrvTarget[]) GLib.Marshaller.ListPtrToArray (__result, typeof(GLib.List), true, true, typeof(GLib.SrvTarget));
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GResolverClass {
			public ReloadNativeDelegate Reload;
			public LookupByNameNativeDelegate LookupByName;
			public LookupByNameAsyncNativeDelegate LookupByNameAsync;
			public LookupByNameFinishNativeDelegate LookupByNameFinish;
			public LookupByAddressNativeDelegate LookupByAddress;
			public LookupByAddressAsyncNativeDelegate LookupByAddressAsync;
			public LookupByAddressFinishNativeDelegate LookupByAddressFinish;
			public LookupServiceNativeDelegate LookupService;
			public LookupServiceAsyncNativeDelegate LookupServiceAsync;
			public LookupServiceFinishNativeDelegate LookupServiceFinish;
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
			IntPtr GReserved4;
			IntPtr GReserved5;
			IntPtr GReserved6;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GResolverClass> class_structs;

		static GResolverClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GResolverClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GResolverClass class_struct = (GResolverClass) Marshal.PtrToStructure (class_ptr, typeof (GResolverClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GResolverClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_resolver_error_quark();

		public static int ErrorQuark() {
			int raw_ret = g_resolver_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resolver_free_addresses(IntPtr addresses);

		public static void FreeAddresses(GLib.List addresses) {
			g_resolver_free_addresses(addresses == null ? IntPtr.Zero : addresses.Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resolver_free_targets(IntPtr targets);

		public static void FreeTargets(GLib.List targets) {
			g_resolver_free_targets(targets == null ? IntPtr.Zero : targets.Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_resolver_get_default();

		public static GLib.Resolver Default { 
			get {
				IntPtr raw_ret = g_resolver_get_default();
				GLib.Resolver ret = GLib.Object.GetObject(raw_ret) as GLib.Resolver;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_resolver_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_resolver_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resolver_lookup_by_address(IntPtr raw, IntPtr address, IntPtr cancellable, out IntPtr error);

		public unsafe string LookupByAddress(GLib.InetAddress address, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resolver_lookup_by_address(Handle, address == null ? IntPtr.Zero : address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resolver_lookup_by_address_async(IntPtr raw, IntPtr address, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void LookupByAddressAsync(GLib.InetAddress address, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_resolver_lookup_by_address_async(Handle, address == null ? IntPtr.Zero : address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resolver_lookup_by_address_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe string LookupByAddressFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resolver_lookup_by_address_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resolver_lookup_by_name(IntPtr raw, IntPtr hostname, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.InetAddress[] LookupByName(string hostname, GLib.Cancellable cancellable) {
			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resolver_lookup_by_name(Handle, native_hostname, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.InetAddress[] ret = (GLib.InetAddress[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GLib.InetAddress));
			GLib.Marshaller.Free (native_hostname);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resolver_lookup_by_name_async(IntPtr raw, IntPtr hostname, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void LookupByNameAsync(string hostname, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_resolver_lookup_by_name_async(Handle, native_hostname, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_hostname);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resolver_lookup_by_name_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.InetAddress[] LookupByNameFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resolver_lookup_by_name_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.InetAddress[] ret = (GLib.InetAddress[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GLib.InetAddress));
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resolver_lookup_service(IntPtr raw, IntPtr service, IntPtr protocol, IntPtr domain, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.SrvTarget[] LookupService(string service, string protocol, string domain, GLib.Cancellable cancellable) {
			IntPtr native_service = GLib.Marshaller.StringToPtrGStrdup (service);
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			IntPtr native_domain = GLib.Marshaller.StringToPtrGStrdup (domain);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resolver_lookup_service(Handle, native_service, native_protocol, native_domain, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.SrvTarget[] ret = (GLib.SrvTarget[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GLib.SrvTarget));
			GLib.Marshaller.Free (native_service);
			GLib.Marshaller.Free (native_protocol);
			GLib.Marshaller.Free (native_domain);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resolver_lookup_service_async(IntPtr raw, IntPtr service, IntPtr protocol, IntPtr domain, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void LookupServiceAsync(string service, string protocol, string domain, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_service = GLib.Marshaller.StringToPtrGStrdup (service);
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			IntPtr native_domain = GLib.Marshaller.StringToPtrGStrdup (domain);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_resolver_lookup_service_async(Handle, native_service, native_protocol, native_domain, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_service);
			GLib.Marshaller.Free (native_protocol);
			GLib.Marshaller.Free (native_domain);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_resolver_lookup_service_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.SrvTarget[] LookupServiceFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_resolver_lookup_service_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.SrvTarget[] ret = (GLib.SrvTarget[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GLib.SrvTarget));
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_resolver_set_default(IntPtr raw);

		public void SetDefault() {
			g_resolver_set_default(Handle);
		}

#endregion
	}
}
