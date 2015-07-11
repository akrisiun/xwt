// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class InputStream : GLib.Object {

		public InputStream (IntPtr raw) : base(raw) {}

		protected InputStream() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static ReadFnNativeDelegate ReadFn_cb_delegate;
		static ReadFnNativeDelegate ReadFnVMCallback {
			get {
				if (ReadFn_cb_delegate == null)
					ReadFn_cb_delegate = new ReadFnNativeDelegate (ReadFn_cb);
				return ReadFn_cb_delegate;
			}
		}

		static void OverrideReadFn (GLib.GType gtype)
		{
			OverrideReadFn (gtype, ReadFnVMCallback);
		}

		static void OverrideReadFn (GLib.GType gtype, ReadFnNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.ReadFn = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr ReadFnNativeDelegate (IntPtr inst, IntPtr buffer, UIntPtr count, IntPtr cancellable, out IntPtr error);

		static IntPtr ReadFn_cb (IntPtr inst, IntPtr buffer, UIntPtr count, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				long __result;
				__result = __obj.OnReadFn (buffer, (ulong) count, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideReadFn")]
		protected virtual long OnReadFn (IntPtr buffer, ulong count, GLib.Cancellable cancellable)
		{
			return InternalReadFn (buffer, count, cancellable);
		}

		private long InternalReadFn (IntPtr buffer, ulong count, GLib.Cancellable cancellable)
		{
			ReadFnNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ReadFn;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, buffer, new UIntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return (long) __result;
		}

		static SkipNativeDelegate Skip_cb_delegate;
		static SkipNativeDelegate SkipVMCallback {
			get {
				if (Skip_cb_delegate == null)
					Skip_cb_delegate = new SkipNativeDelegate (Skip_cb);
				return Skip_cb_delegate;
			}
		}

		static void OverrideSkip (GLib.GType gtype)
		{
			OverrideSkip (gtype, SkipVMCallback);
		}

		static void OverrideSkip (GLib.GType gtype, SkipNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.Skip = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr SkipNativeDelegate (IntPtr inst, UIntPtr count, IntPtr cancellable, out IntPtr error);

		static IntPtr Skip_cb (IntPtr inst, UIntPtr count, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				long __result;
				__result = __obj.OnSkip ((ulong) count, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideSkip")]
		protected virtual long OnSkip (ulong count, GLib.Cancellable cancellable)
		{
			return InternalSkip (count, cancellable);
		}

		private long InternalSkip (ulong count, GLib.Cancellable cancellable)
		{
			SkipNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Skip;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, new UIntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return (long) __result;
		}

		static CloseFnNativeDelegate CloseFn_cb_delegate;
		static CloseFnNativeDelegate CloseFnVMCallback {
			get {
				if (CloseFn_cb_delegate == null)
					CloseFn_cb_delegate = new CloseFnNativeDelegate (CloseFn_cb);
				return CloseFn_cb_delegate;
			}
		}

		static void OverrideCloseFn (GLib.GType gtype)
		{
			OverrideCloseFn (gtype, CloseFnVMCallback);
		}

		static void OverrideCloseFn (GLib.GType gtype, CloseFnNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.CloseFn = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CloseFnNativeDelegate (IntPtr inst, IntPtr cancellable, out IntPtr error);

		static bool CloseFn_cb (IntPtr inst, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				bool __result;
				__result = __obj.OnCloseFn (GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideCloseFn")]
		protected virtual bool OnCloseFn (GLib.Cancellable cancellable)
		{
			return InternalCloseFn (cancellable);
		}

		private bool InternalCloseFn (GLib.Cancellable cancellable)
		{
			CloseFnNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CloseFn;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return __result;
		}

		static ReadAsyncNativeDelegate ReadAsync_cb_delegate;
		static ReadAsyncNativeDelegate ReadAsyncVMCallback {
			get {
				if (ReadAsync_cb_delegate == null)
					ReadAsync_cb_delegate = new ReadAsyncNativeDelegate (ReadAsync_cb);
				return ReadAsync_cb_delegate;
			}
		}

		static void OverrideReadAsync (GLib.GType gtype)
		{
			OverrideReadAsync (gtype, ReadAsyncVMCallback);
		}

		static void OverrideReadAsync (GLib.GType gtype, ReadAsyncNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.ReadAsync = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReadAsyncNativeDelegate (IntPtr inst, IntPtr buffer, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void ReadAsync_cb (IntPtr inst, IntPtr buffer, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnReadAsync (buffer, (ulong) count, io_priority, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideReadAsync")]
		protected virtual void OnReadAsync (IntPtr buffer, ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalReadAsync (buffer, count, io_priority, cancellable, cb);
		}

		private void InternalReadAsync (IntPtr buffer, ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			ReadAsyncNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ReadAsync;
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, buffer, new UIntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static ReadFinishNativeDelegate ReadFinish_cb_delegate;
		static ReadFinishNativeDelegate ReadFinishVMCallback {
			get {
				if (ReadFinish_cb_delegate == null)
					ReadFinish_cb_delegate = new ReadFinishNativeDelegate (ReadFinish_cb);
				return ReadFinish_cb_delegate;
			}
		}

		static void OverrideReadFinish (GLib.GType gtype)
		{
			OverrideReadFinish (gtype, ReadFinishVMCallback);
		}

		static void OverrideReadFinish (GLib.GType gtype, ReadFinishNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.ReadFinish = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr ReadFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr ReadFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				long __result;
				__result = __obj.OnReadFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideReadFinish")]
		protected virtual long OnReadFinish (GLib.IAsyncResult result)
		{
			return InternalReadFinish (result);
		}

		private long InternalReadFinish (GLib.IAsyncResult result)
		{
			ReadFinishNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ReadFinish;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (long) __result;
		}

		static SkipAsyncNativeDelegate SkipAsync_cb_delegate;
		static SkipAsyncNativeDelegate SkipAsyncVMCallback {
			get {
				if (SkipAsync_cb_delegate == null)
					SkipAsync_cb_delegate = new SkipAsyncNativeDelegate (SkipAsync_cb);
				return SkipAsync_cb_delegate;
			}
		}

		static void OverrideSkipAsync (GLib.GType gtype)
		{
			OverrideSkipAsync (gtype, SkipAsyncVMCallback);
		}

		static void OverrideSkipAsync (GLib.GType gtype, SkipAsyncNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.SkipAsync = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SkipAsyncNativeDelegate (IntPtr inst, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void SkipAsync_cb (IntPtr inst, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnSkipAsync ((ulong) count, io_priority, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideSkipAsync")]
		protected virtual void OnSkipAsync (ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalSkipAsync (count, io_priority, cancellable, cb);
		}

		private void InternalSkipAsync (ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			SkipAsyncNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SkipAsync;
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, new UIntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static SkipFinishNativeDelegate SkipFinish_cb_delegate;
		static SkipFinishNativeDelegate SkipFinishVMCallback {
			get {
				if (SkipFinish_cb_delegate == null)
					SkipFinish_cb_delegate = new SkipFinishNativeDelegate (SkipFinish_cb);
				return SkipFinish_cb_delegate;
			}
		}

		static void OverrideSkipFinish (GLib.GType gtype)
		{
			OverrideSkipFinish (gtype, SkipFinishVMCallback);
		}

		static void OverrideSkipFinish (GLib.GType gtype, SkipFinishNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.SkipFinish = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr SkipFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr SkipFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				long __result;
				__result = __obj.OnSkipFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideSkipFinish")]
		protected virtual long OnSkipFinish (GLib.IAsyncResult result)
		{
			return InternalSkipFinish (result);
		}

		private long InternalSkipFinish (GLib.IAsyncResult result)
		{
			SkipFinishNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SkipFinish;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (long) __result;
		}

		static CloseAsyncNativeDelegate CloseAsync_cb_delegate;
		static CloseAsyncNativeDelegate CloseAsyncVMCallback {
			get {
				if (CloseAsync_cb_delegate == null)
					CloseAsync_cb_delegate = new CloseAsyncNativeDelegate (CloseAsync_cb);
				return CloseAsync_cb_delegate;
			}
		}

		static void OverrideCloseAsync (GLib.GType gtype)
		{
			OverrideCloseAsync (gtype, CloseAsyncVMCallback);
		}

		static void OverrideCloseAsync (GLib.GType gtype, CloseAsyncNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.CloseAsync = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseAsyncNativeDelegate (IntPtr inst, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void CloseAsync_cb (IntPtr inst, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnCloseAsync (io_priority, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideCloseAsync")]
		protected virtual void OnCloseAsync (int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalCloseAsync (io_priority, cancellable, cb);
		}

		private void InternalCloseAsync (int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			CloseAsyncNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CloseAsync;
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static CloseFinishNativeDelegate CloseFinish_cb_delegate;
		static CloseFinishNativeDelegate CloseFinishVMCallback {
			get {
				if (CloseFinish_cb_delegate == null)
					CloseFinish_cb_delegate = new CloseFinishNativeDelegate (CloseFinish_cb);
				return CloseFinish_cb_delegate;
			}
		}

		static void OverrideCloseFinish (GLib.GType gtype)
		{
			OverrideCloseFinish (gtype, CloseFinishVMCallback);
		}

		static void OverrideCloseFinish (GLib.GType gtype, CloseFinishNativeDelegate callback)
		{
			GInputStreamClass class_iface = GetClassStruct (gtype, false);
			class_iface.CloseFinish = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CloseFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static bool CloseFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				InputStream __obj = GLib.Object.GetObject (inst, false) as InputStream;
				bool __result;
				__result = __obj.OnCloseFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InputStream), ConnectionMethod="OverrideCloseFinish")]
		protected virtual bool OnCloseFinish (GLib.IAsyncResult result)
		{
			return InternalCloseFinish (result);
		}

		private bool InternalCloseFinish (GLib.IAsyncResult result)
		{
			CloseFinishNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CloseFinish;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return __result;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GInputStreamClass {
			public ReadFnNativeDelegate ReadFn;
			public SkipNativeDelegate Skip;
			public CloseFnNativeDelegate CloseFn;
			public ReadAsyncNativeDelegate ReadAsync;
			public ReadFinishNativeDelegate ReadFinish;
			public SkipAsyncNativeDelegate SkipAsync;
			public SkipFinishNativeDelegate SkipFinish;
			public CloseAsyncNativeDelegate CloseAsync;
			public CloseFinishNativeDelegate CloseFinish;
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
			IntPtr GReserved4;
			IntPtr GReserved5;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GInputStreamClass> class_structs;

		static GInputStreamClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GInputStreamClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GInputStreamClass class_struct = (GInputStreamClass) Marshal.PtrToStructure (class_ptr, typeof (GInputStreamClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GInputStreamClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_input_stream_clear_pending(IntPtr raw);

		public void ClearPending() {
			g_input_stream_clear_pending(Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_input_stream_close(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe bool Close(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_close(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_input_stream_close_async(IntPtr raw, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void CloseAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_input_stream_close_async(Handle, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_input_stream_close_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe bool CloseFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_close_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_input_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_input_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_input_stream_has_pending(IntPtr raw);

		public bool HasPending { 
			get {
				bool raw_ret = g_input_stream_has_pending(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_input_stream_is_closed(IntPtr raw);

		public bool IsClosed { 
			get {
				bool raw_ret = g_input_stream_is_closed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_input_stream_read(IntPtr raw, byte[] buffer, UIntPtr count, IntPtr cancellable, out IntPtr error);

		public unsafe long Read(byte[] buffer, ulong count, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_read(Handle, buffer, new UIntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_input_stream_read_all(IntPtr raw, byte[] buffer, UIntPtr count, out UIntPtr bytes_read, IntPtr cancellable, out IntPtr error);

		public unsafe bool ReadAll(byte[] buffer, ulong count, out ulong bytes_read, GLib.Cancellable cancellable) {
			UIntPtr native_bytes_read;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_read_all(Handle, buffer, new UIntPtr (count), out native_bytes_read, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			bytes_read = (ulong) native_bytes_read;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_input_stream_read_async(IntPtr raw, byte[] buffer, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ReadAsync(byte[] buffer, ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_input_stream_read_async(Handle, buffer, new UIntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_input_stream_read_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe long ReadFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_read_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_input_stream_set_pending(IntPtr raw, out IntPtr error);

		public unsafe bool SetPending() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_set_pending(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_input_stream_skip(IntPtr raw, UIntPtr count, IntPtr cancellable, out IntPtr error);

		public unsafe long Skip(ulong count, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_skip(Handle, new UIntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_input_stream_skip_async(IntPtr raw, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void SkipAsync(ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_input_stream_skip_async(Handle, new UIntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_input_stream_skip_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe long SkipFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_skip_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
