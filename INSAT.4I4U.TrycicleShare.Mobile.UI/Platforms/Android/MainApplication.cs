﻿using Android.App;
using Android.Runtime;

namespace INSAT._4I4U.TrycicleShare.Mobile.UI;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
