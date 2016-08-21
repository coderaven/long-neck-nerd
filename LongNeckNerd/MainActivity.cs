using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;

namespace LongNeckNerd
{
	[Activity(Label = "Long Neck Nerd", Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		RecyclerView recycleViewAttractions;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			recycleViewAttractions = FindViewById<RecyclerView>(Resource.Id.recyclerViewAttractions);
		}
	}
}


