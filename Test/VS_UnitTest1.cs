using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xwt;
using System.Reflection;

namespace Test_VS
{
    [TestClass]
    public class VS_UnitTest1
    {
        public TestContext TestContext { get; set; }

        #region Additional test attributes

        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            var version = Gtk.CoreGtk3.Instance.ToString();

            System.AppDomain.CurrentDomain.AssemblyResolve += 
                (s, e) => ResolveAsm(s, e);

            Xwt.Application.Initialize(ToolkitType.Gtk3);

            System.AppDomain.CurrentDomain.AssemblyResolve -= ResolveAsm;
        }

        public static Assembly ResolveAsm(object s, ResolveEventArgs args)
        {
            var name = args.Name.Split(",".ToCharArray());

            var asm = Assembly.LoadFrom(name[0].Trim() + ".dll");
            return asm;
        }

        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // [TestInitialize()]
        // [TestCleanup()]

        #endregion

        [TestMethod]
        public void Test_Frame()
        {
            var frame = new FrameTests();
            frame.Init();

            frame.Cleanup();
        }
    }
}
