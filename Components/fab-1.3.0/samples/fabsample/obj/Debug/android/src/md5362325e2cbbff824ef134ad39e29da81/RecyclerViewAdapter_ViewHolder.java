package md5362325e2cbbff824ef134ad39e29da81;


public class RecyclerViewAdapter_ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("FabSample.RecyclerViewAdapter+ViewHolder, FabSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RecyclerViewAdapter_ViewHolder.class, __md_methods);
	}


	public RecyclerViewAdapter_ViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == RecyclerViewAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("FabSample.RecyclerViewAdapter+ViewHolder, FabSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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