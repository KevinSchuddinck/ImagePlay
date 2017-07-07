package md5027a85e612391c5c2704711d3a67c671;


public class CircleCropGlide
	extends md5027a85e612391c5c2704711d3a67c671.GlideTransformation
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ImagePlay3_Droid.Transformations.Glide.CircleCropGlide, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CircleCropGlide.class, __md_methods);
	}


	public CircleCropGlide (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CircleCropGlide.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Transformations.Glide.CircleCropGlide, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public CircleCropGlide (com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CircleCropGlide.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Transformations.Glide.CircleCropGlide, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool, GlideAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
