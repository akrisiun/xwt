// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IActionGroup : GLib.IWrapper {

		event GLib.ActionEnabledChangedHandler ActionEnabledChanged;
		event GLib.ActionRemovedHandler ActionRemoved;
		event GLib.ActionStateChangedHandler ActionStateChanged;
		event GLib.ActionAddedHandler ActionAdded;
		void EmitActionAdded(string action_name);
		void EmitActionEnabledChanged(string action_name, bool enabled);
		void EmitActionRemoved(string action_name);
		void EmitActionStateChanged(string action_name, GLib.Variant state);
		void ActivateAction(string action_name, GLib.Variant parameter);
		void ChangeActionState(string action_name, GLib.Variant value);
		bool GetActionEnabled(string action_name);
		GLib.VariantType GetActionParameterType(string action_name);
		GLib.Variant GetActionState(string action_name);
		GLib.Variant GetActionStateHint(string action_name);
		GLib.VariantType GetActionStateType(string action_name);
		bool HasAction(string action_name);
		string ListActions();
	}

	[GLib.GInterface (typeof (ActionGroupAdapter))]
	public partial interface IActionGroupImplementor : GLib.IWrapper {

		bool HasAction (string action_name);
		string ListActions ();
		bool GetActionEnabled (string action_name);
		GLib.VariantType GetActionParameterType (string action_name);
		GLib.VariantType GetActionStateType (string action_name);
		GLib.Variant GetActionStateHint (string action_name);
		GLib.Variant GetActionState (string action_name);
		void ChangeActionState (string action_name, GLib.Variant value);
		void ActivateAction (string action_name, GLib.Variant parameter);
	}
#endregion
}
