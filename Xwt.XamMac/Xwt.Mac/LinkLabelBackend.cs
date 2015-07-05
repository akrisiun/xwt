//
// LinkLabelBackend.cs
//
// Author:
//       Alex Corrado <corrado@xamarin.com>
//
// Copyright (c) 2012 Xamarin Inc
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Xwt.Backends;

#if MONOMAC
using nint = System.Int32;
using nfloat = System.Single;
using MonoMac.Foundation;
using MonoMac.AppKit;
#else
using Foundation;
using AppKit;
#endif

#if MONOMAC 

namespace MonoMac.Foundation
{
    public static class NSStringAttributeKey
    {
        // properties
        public static MonoMac.Foundation.NSString Attachment { get { return (NSString)"Attachment"; } }

        public static MonoMac.Foundation.NSString BackgroundColor { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString BaselineOffset { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString CharacterShape { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Cursor { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Expansion { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Font { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString ForegroundColor { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString GlyphInfo { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString KerningAdjustment { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Ligature { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Link { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString MarkedClauseSegment { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Obliqueness { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString ParagraphStyle { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Shadow { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString SpellingState { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString StrikethroughColor { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString StrikethroughStyle { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString StrokeColor { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString StrokeWidth { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString Superscript { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString TextAlternatives { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString TextEffect { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString ToolTip { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString UnderlineColor { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString UnderlineStyle { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString VerticalGlyphForm { get { return (NSString)""; } }
        public static MonoMac.Foundation.NSString WritingDirection { get { return (NSString)""; } }
    }

}

#endif   

namespace Xwt.Mac
{
	public class LinkLabelBackend : LabelBackend, ILinkLabelBackend
	{
		Uri uri;

		new ILinkLabelEventSink EventSink {
			get { return (ILinkLabelEventSink)base.EventSink; }
		}

		public Uri Uri {
			get { return uri; }
			set { uri = value; }
		}

		public override string Text {
			get { return base.Text; }
			set {
				base.Text = value;
				Widget.Cell.AttributedStringValue = GetAttributedString (value);
			}
		}

		public LinkLabelBackend () : base (new LinkLabelView ())
		{
		}

		public override void Initialize ()
		{
			base.Initialize ();
			Widget.AllowsEditingTextAttributes = true;
		}

		public override void EnableEvent (object eventId)
		{
			base.EnableEvent (eventId);
			if (eventId is LinkLabelEvent) {
				switch ((LinkLabelEvent) eventId) {
				case LinkLabelEvent.NavigateToUrl:
					((LinkLabelView)Widget).Clicked += HandleClicked;
					break;
				}
			}
		}

		public override void DisableEvent (object eventId)
		{
			base.DisableEvent (eventId);
			if (eventId is LinkLabelEvent) {
				switch ((LinkLabelEvent) eventId) {
				case LinkLabelEvent.NavigateToUrl:
					((LinkLabelView)Widget).Clicked -= HandleClicked;
					break;
				}
			}
		}

		void HandleClicked (object sender, EventArgs e)
		{
			ApplicationContext.InvokeUserCode (() => {
				EventSink.OnNavigateToUrl (uri);
			});
		}

		static NSAttributedString GetAttributedString (string text)
		{
			var attrStr = new NSMutableAttributedString (text);
			var range = new NSRange (0, attrStr.Length);

			var singleUnderlineStyle = NSNumber.FromInt32 ((int)NSUnderlineStyle.Single);
			attrStr.AddAttribute (NSStringAttributeKey.ForegroundColor, NSColor.Blue, range);
			attrStr.AddAttribute (NSStringAttributeKey.UnderlineStyle, singleUnderlineStyle, range);

			return attrStr;
		}
	}

	class LinkLabelView : TextFieldView
	{
		public event EventHandler Clicked;
		public override void ResetCursorRects ()
		{
			AddCursorRect (Bounds, NSCursor.PointingHandCursor);
		}
		public override void MouseUp (NSEvent theEvent)
		{
			// Unfortunately, cocoa calls MouseUp even if the mouse is not still over this control so we have to check that
			var location = ConvertPointFromView (theEvent.LocationInWindow, null);
			if (Clicked != null && IsMouseInRect (location, Cell.DrawingRectForBounds (Bounds)))
				Clicked (this, EventArgs.Empty);
		}
	}
}

