package md5a5e3df2d02cb4566aa23aefd8635500c;


public class ViewHelper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ImagePlay3_Droid.Helpers.ViewHelper, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ViewHelper.class, __md_methods);
	}


	public ViewHelper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ViewHelper.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Helpers.ViewHelper, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ViewHelper (android.app.Activity p0, android.view.View p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == ViewHelper.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Helpers.ViewHelper, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
