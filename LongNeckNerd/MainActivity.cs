using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;

using Android.Graphics;
using System.Net;
using Android.Content;

using Android.Support.V7.CardView;
using Square.Picasso;
using SQLite;
using System.IO;
using System.Collections.Generic;
using System;

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

			//Toast.MakeText(this, "Hello World!", ToastLength.Long).Show();

			//FindViewById<Button>(Resource.Id.buttonImageURLView).Click += delegate 
			//{
			//	StartActivity(typeof(ImageURLViewActivity));	
			//};

			//FindViewById<Button>(Resource.Id.buttonMapTestView).Click += delegate 
			//{
			//	var geoUri = Android.Net.Uri.Parse("geo:42.374260,-71.120824");
			//	var mapIntent = new Intent(Intent.ActionView, geoUri);
			//	StartActivity(mapIntent);	
			//};

			// Card View
			//var imageView = FindViewById<ImageView>(Resource.Id.imageView);
			//var imageURL = "https://trabblestorageaccount.blob.core.windows.net/trabbleimages/AttractionImages/attraction_attractions_GardensByTheBay.jpg";

			//Picasso.With(this).Load(imageURL).Placeholder(Resource.Drawable.placeholder).Into(imageView);

			// Recycle View (using CardView) for Attractions

			mAttractionsList = new AttractionList(); // Data Source

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
			Toast.MakeText(this, "You are visiting " + mAttractionsList[position].mAttractionName, ToastLength.Short).Show();
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


