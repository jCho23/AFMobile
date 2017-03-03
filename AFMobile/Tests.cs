using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AFMobile
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}


		[Test]
		public void UsernameNoPassword()
		{
			app.Tap("username");
			app.Screenshot("Let's start by tapping on the 'username' Text Field");

			app.EnterText("BillGates");
			app.Screenshot("We entered in our username, 'Bill Gates'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("login_submit");
			app.Screenshot("Then we Tapped on the 'Sign In' Button");
		}

		[Test]
		public void  PasswordNoUsername()
		{
			app.Tap("password");
			app.Screenshot("Let's start by tapping on the 'password' Text Field");

			app.EnterText("AFMobile");
			app.Screenshot("We entered in our password, 'AFMobile'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("login_submit");
			app.Screenshot("Then we Tapped on the 'Sign In' Button");
		}
	}
}
