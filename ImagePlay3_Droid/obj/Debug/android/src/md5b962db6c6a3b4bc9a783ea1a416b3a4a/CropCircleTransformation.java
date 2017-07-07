package md5b962db6c6a3b4bc9a783ea1a416b3a4a;


public class CropCircleTransformation
	extends md5b962db6c6a3b4bc9a783ea1a416b3a4a.TransformImage
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ImagePlay3_Droid.Transformations.CropCircleTransformation, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CropCircleTransformation.class, __md_methods);
	}


	public CropCircleTransformation () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CropCircleTransformation.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Transformations.CropCircleTransformation, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
