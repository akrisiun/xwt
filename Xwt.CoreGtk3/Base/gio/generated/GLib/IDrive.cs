// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IDrive : GLib.IWrapper {

		event System.EventHandler StopButton;
		event System.EventHandler Disconnected;
		event System.EventHandler Changed;
		event System.EventHandler EjectButton;
		bool CanEject();
		bool CanPollForMedia();
		bool CanStart();
		bool CanStartDegraded();
		bool CanStop();
		void Eject(GLib.MountUnmountFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool EjectFinish(GLib.IAsyncResult result);
		void EjectWithOperation(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool EjectWithOperationFinish(GLib.IAsyncResult result);
		string EnumerateIdentifiers();
		GLib.IIcon Icon { 
			get;
		}
		string GetIdentifier(string kind);
		string Name { 
			get;
		}
		GLib.DriveStartStopType StartStopType { 
			get;
		}
		GLib.IVolume[] Volumes { 
			get;
		}
		bool HasMedia { 
			get;
		}
		bool HasVolumes { 
			get;
		}
		bool IsMediaCheckAutomatic { 
			get;
		}
		bool IsMediaRemovable { 
			get;
		}
		void PollForMedia(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool PollForMediaFinish(GLib.IAsyncResult result);
		void Start(GLib.DriveStartFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool StartFinish(GLib.IAsyncResult result);
		void Stop(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool StopFinish(GLib.IAsyncResult result);
	}
#endregion
}
