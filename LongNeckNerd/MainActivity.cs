using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.IO;
using Newtonsoft.Json;
using Android.Content;

namespace LongNeckNerd
{
	[Activity(Theme = "@style/CustomActionBarTheme", Label = "Long Neck Nerd", Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		RecyclerView mRecycleViewAttractions;
		RecyclerView.LayoutManager mLayoutManager;
		AttractionListAdapter mAttractionListAdapter;
		AttractionList mAttractionsList;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			prepareDatabase();

			mAttractionsList = new AttractionList();

			// Instantiate the adapter and pass in its data source:
			mAttractionListAdapter = new AttractionListAdapter(this, mAttractionsList);
			mAttractionListAdapter.attractionClick += OnAttractionClick;

			// Get our RecyclerView layout:
			mRecycleViewAttractions = FindViewById<RecyclerView>(Resource.Id.recyclerViewAttractions);

			// Plug the adapter into the RecyclerView:
			mRecycleViewAttractions.SetAdapter(mAttractionListAdapter);

			mLayoutManager = new LinearLayoutManager(this);
			mRecycleViewAttractions.SetLayoutManager(mLayoutManager);
		}
	
		void OnAttractionClick(object sender, int position)
		{
			// Toast.MakeText(this, "You are visiting " + mAttractionsList[position].mAttractionName, ToastLength.Short).Show();

			// Go to Attraction Detail Activity
			var serializedAttraction = JsonConvert.SerializeObject(mAttractionsList[position]);
			var attractionDetailsIntent = new Intent(this, typeof(AttractionDetailActivity));
			attractionDetailsIntent.PutExtra("AttractionObject", serializedAttraction);
			StartActivity(attractionDetailsIntent);
		}

		private void prepareDatabase()
		{
			// Check if DB has already been extracted.
			string dbName = Attraction.DATABASE_NAME;
			string dbPath = Attraction.DATABASE_PATH;

			if (!File.Exists(dbPath))
			{
				using (BinaryReader br = new BinaryReader(Assets.Open(dbName)))
				{
					using (BinaryWriter bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
					{
						byte[] buffer = new byte[2048];
						int len = 0;
						while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
						{
							bw.Write(buffer, 0, len);
						}
					}
				}
				Toast.MakeText(this, "Database Copied Successfully!", ToastLength.Long).Show();
			}
		}
	}
}


