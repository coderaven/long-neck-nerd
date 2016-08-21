﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;

using Android.Graphics;
using System.Net;
using Android.Content;

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
			recycleViewAttractions.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));

			FindViewById<Button>(Resource.Id.buttonImageURLView).Click += delegate 
			{
				StartActivity(typeof(ImageURLViewActivity));	
			};

			FindViewById<Button>(Resource.Id.buttonMapTestView).Click += delegate 
			{
				var geoUri = Android.Net.Uri.Parse("geo:42.374260,-71.120824");
				var mapIntent = new Intent(Intent.ActionView, geoUri);
				StartActivity(mapIntent);	
			};
		}
	}
}


