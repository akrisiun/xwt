using System;
using Xwt;
//using Xwt.Drawing;
//using MonoDevelop.Components.Chart;

namespace Samples
{
	public class App
	{
        [STAThread]
        public static void Main()
        {
            if (Environment.OSVersion.Platform.Equals(PlatformID.Win32NT))
                Run(ToolkitType.Wpf);
            else
                Run(ToolkitType.XamMac);
        }

        public static void Run (ToolkitType type)
		{
			Application.Initialize (type);
			
			MainWindow w = new MainWindow ();
			w.Show ();
			
			Application.Run ();
			
			w.Dispose ();

			Application.Dispose ();
		}
	}
}	

