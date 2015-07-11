// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Bus {

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_bus_get(int bus_type, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public static void Get(GLib.BusType bus_type, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_bus_get((int) bus_type, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_bus_get_finish(IntPtr res, out IntPtr error);

		public static unsafe GLib.DBusConnection GetFinish(GLib.IAsyncResult res) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_bus_get_finish(res == null ? IntPtr.Zero : ((res is GLib.Object) ? (res as GLib.Object).Handle : (res as GLib.AsyncResultAdapter).Handle), out error);
			GLib.DBusConnection ret = GLib.Object.GetObject(raw_ret) as GLib.DBusConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_bus_get_sync(int bus_type, IntPtr cancellable, out IntPtr error);

		public static unsafe GLib.DBusConnection GetSync(GLib.BusType bus_type, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_bus_get_sync((int) bus_type, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.DBusConnection ret = GLib.Object.GetObject(raw_ret) as GLib.DBusConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_own_name(int bus_type, IntPtr name, int flags, GLibSharp.BusAcquiredCallbackNative bus_acquired_handler, GLibSharp.BusNameAcquiredCallbackNative name_acquired_handler, GLibSharp.BusNameLostCallbackNative name_lost_handler, IntPtr user_data, GLib.DestroyNotify user_data_free_func);

		public static uint OwnName(GLib.BusType bus_type, string name, GLib.BusNameOwnerFlags flags, GLib.BusAcquiredCallback bus_acquired_handler, GLib.BusNameAcquiredCallback name_acquired_handler, GLib.BusNameLostCallback name_lost_handler) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			GLibSharp.BusAcquiredCallbackWrapper bus_acquired_handler_wrapper = new GLibSharp.BusAcquiredCallbackWrapper (bus_acquired_handler);
			GLibSharp.BusNameAcquiredCallbackWrapper name_acquired_handler_wrapper = new GLibSharp.BusNameAcquiredCallbackWrapper (name_acquired_handler);
			GLibSharp.BusNameLostCallbackWrapper name_lost_handler_wrapper = new GLibSharp.BusNameLostCallbackWrapper (name_lost_handler);
			IntPtr user_data;
			GLib.DestroyNotify user_data_free_func;
			if (name_lost_handler == null) {
				user_data = IntPtr.Zero;
				user_data_free_func = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (name_lost_handler_wrapper);
				user_data_free_func = GLib.DestroyHelper.NotifyHandler;
			}
			uint raw_ret = g_bus_own_name((int) bus_type, native_name, (int) flags, bus_acquired_handler_wrapper.NativeDelegate, name_acquired_handler_wrapper.NativeDelegate, name_lost_handler_wrapper.NativeDelegate, user_data, user_data_free_func);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_own_name_on_connection(IntPtr connection, IntPtr name, int flags, GLibSharp.BusNameAcquiredCallbackNative name_acquired_handler, GLibSharp.BusNameLostCallbackNative name_lost_handler, IntPtr user_data, GLib.DestroyNotify user_data_free_func);

		public static uint OwnNameOnConnection(GLib.DBusConnection connection, string name, GLib.BusNameOwnerFlags flags, GLib.BusNameAcquiredCallback name_acquired_handler, GLib.BusNameLostCallback name_lost_handler) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			GLibSharp.BusNameAcquiredCallbackWrapper name_acquired_handler_wrapper = new GLibSharp.BusNameAcquiredCallbackWrapper (name_acquired_handler);
			GLibSharp.BusNameLostCallbackWrapper name_lost_handler_wrapper = new GLibSharp.BusNameLostCallbackWrapper (name_lost_handler);
			IntPtr user_data;
			GLib.DestroyNotify user_data_free_func;
			if (name_lost_handler == null) {
				user_data = IntPtr.Zero;
				user_data_free_func = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (name_lost_handler_wrapper);
				user_data_free_func = GLib.DestroyHelper.NotifyHandler;
			}
			uint raw_ret = g_bus_own_name_on_connection(connection == null ? IntPtr.Zero : connection.Handle, native_name, (int) flags, name_acquired_handler_wrapper.NativeDelegate, name_lost_handler_wrapper.NativeDelegate, user_data, user_data_free_func);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_own_name_on_connection_with_closures(IntPtr connection, IntPtr name, int flags, IntPtr name_acquired_closure, IntPtr name_lost_closure);

		public static uint OwnNameOnConnectionWithClosures(GLib.DBusConnection connection, string name, GLib.BusNameOwnerFlags flags, IntPtr name_acquired_closure, IntPtr name_lost_closure) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			uint raw_ret = g_bus_own_name_on_connection_with_closures(connection == null ? IntPtr.Zero : connection.Handle, native_name, (int) flags, name_acquired_closure, name_lost_closure);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_own_name_with_closures(int bus_type, IntPtr name, int flags, IntPtr bus_acquired_closure, IntPtr name_acquired_closure, IntPtr name_lost_closure);

		public static uint OwnNameWithClosures(GLib.BusType bus_type, string name, GLib.BusNameOwnerFlags flags, IntPtr bus_acquired_closure, IntPtr name_acquired_closure, IntPtr name_lost_closure) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			uint raw_ret = g_bus_own_name_with_closures((int) bus_type, native_name, (int) flags, bus_acquired_closure, name_acquired_closure, name_lost_closure);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_bus_unown_name(uint owner_id);

		public static void UnownName(uint owner_id) {
			g_bus_unown_name(owner_id);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_bus_unwatch_name(uint watcher_id);

		public static void UnwatchName(uint watcher_id) {
			g_bus_unwatch_name(watcher_id);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_watch_name(int bus_type, IntPtr name, int flags, GLibSharp.BusNameAppearedCallbackNative name_appeared_handler, GLibSharp.BusNameVanishedCallbackNative name_vanished_handler, IntPtr user_data, GLib.DestroyNotify user_data_free_func);

		public static uint WatchName(GLib.BusType bus_type, string name, GLib.BusNameWatcherFlags flags, GLib.BusNameAppearedCallback name_appeared_handler, GLib.BusNameVanishedCallback name_vanished_handler) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			GLibSharp.BusNameAppearedCallbackWrapper name_appeared_handler_wrapper = new GLibSharp.BusNameAppearedCallbackWrapper (name_appeared_handler);
			GLibSharp.BusNameVanishedCallbackWrapper name_vanished_handler_wrapper = new GLibSharp.BusNameVanishedCallbackWrapper (name_vanished_handler);
			IntPtr user_data;
			GLib.DestroyNotify user_data_free_func;
			if (name_vanished_handler == null) {
				user_data = IntPtr.Zero;
				user_data_free_func = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (name_vanished_handler_wrapper);
				user_data_free_func = GLib.DestroyHelper.NotifyHandler;
			}
			uint raw_ret = g_bus_watch_name((int) bus_type, native_name, (int) flags, name_appeared_handler_wrapper.NativeDelegate, name_vanished_handler_wrapper.NativeDelegate, user_data, user_data_free_func);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_watch_name_on_connection(IntPtr connection, IntPtr name, int flags, GLibSharp.BusNameAppearedCallbackNative name_appeared_handler, GLibSharp.BusNameVanishedCallbackNative name_vanished_handler, IntPtr user_data, GLib.DestroyNotify user_data_free_func);

		public static uint WatchNameOnConnection(GLib.DBusConnection connection, string name, GLib.BusNameWatcherFlags flags, GLib.BusNameAppearedCallback name_appeared_handler, GLib.BusNameVanishedCallback name_vanished_handler) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			GLibSharp.BusNameAppearedCallbackWrapper name_appeared_handler_wrapper = new GLibSharp.BusNameAppearedCallbackWrapper (name_appeared_handler);
			GLibSharp.BusNameVanishedCallbackWrapper name_vanished_handler_wrapper = new GLibSharp.BusNameVanishedCallbackWrapper (name_vanished_handler);
			IntPtr user_data;
			GLib.DestroyNotify user_data_free_func;
			if (name_vanished_handler == null) {
				user_data = IntPtr.Zero;
				user_data_free_func = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (name_vanished_handler_wrapper);
				user_data_free_func = GLib.DestroyHelper.NotifyHandler;
			}
			uint raw_ret = g_bus_watch_name_on_connection(connection == null ? IntPtr.Zero : connection.Handle, native_name, (int) flags, name_appeared_handler_wrapper.NativeDelegate, name_vanished_handler_wrapper.NativeDelegate, user_data, user_data_free_func);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_watch_name_on_connection_with_closures(IntPtr connection, IntPtr name, int flags, IntPtr name_appeared_closure, IntPtr name_vanished_closure);

		public static uint WatchNameOnConnectionWithClosures(GLib.DBusConnection connection, string name, GLib.BusNameWatcherFlags flags, IntPtr name_appeared_closure, IntPtr name_vanished_closure) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			uint raw_ret = g_bus_watch_name_on_connection_with_closures(connection == null ? IntPtr.Zero : connection.Handle, native_name, (int) flags, name_appeared_closure, name_vanished_closure);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_bus_watch_name_with_closures(int bus_type, IntPtr name, int flags, IntPtr name_appeared_closure, IntPtr name_vanished_closure);

		public static uint WatchNameWithClosures(GLib.BusType bus_type, string name, GLib.BusNameWatcherFlags flags, IntPtr name_appeared_closure, IntPtr name_vanished_closure) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			uint raw_ret = g_bus_watch_name_with_closures((int) bus_type, native_name, (int) flags, name_appeared_closure, name_vanished_closure);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

#endregion
	}
}