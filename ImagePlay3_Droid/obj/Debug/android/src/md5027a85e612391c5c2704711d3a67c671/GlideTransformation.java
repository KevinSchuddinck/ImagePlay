package md5027a85e612391c5c2704711d3a67c671;


public abstract class GlideTransformation
	extends com.bumptech.glide.load.resource.bitmap.BitmapTransformation
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_transform:(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;:GetTransform_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_IIHandler\n" +
			"n_getId:()Ljava/lang/String;:GetGetIdHandler\n" +
			"";
		mono.android.Runtime.register ("ImagePlay3_Droid.Transformations.Glide.GlideTransformation, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GlideTransformation.class, __md_methods);
	}


	public GlideTransformation (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == GlideTransformation.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Transformations.Glide.GlideTransformation, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public GlideTransformation (com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == GlideTransformation.class)
			mono.android.TypeManager.Activate ("ImagePlay3_Droid.Transformations.Glide.GlideTransformation, ImagePlay3_Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Com.Bumptech.Glide.Load.Engine.Bitmap_recycle.IBitmapPool, GlideAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public android.graphics.Bitmap transform (com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool p0, android.graphics.Bitmap p1, int p2, int p3)
	{
		return n_transform (p0, p1, p2, p3);
	}

	private native android.graphics.Bitmap n_transform (com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool p0, android.graphics.Bitmap p1, int p2, int p3);


	public java.lang.String getId ()
	{
		return n_getId ();
	}

	private native java.lang.String n_getId ();

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
