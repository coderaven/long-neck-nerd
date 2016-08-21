
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Graphics;
using System.Net;
using Square.Picasso;

namespace LongNeckNerd
{
	[Activity(Label = "ImageURLViewActivity")]
	public class ImageURLViewActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.ImageURLView);
			// Create your application here
			ImageView imagen = FindViewById<ImageView>(Resource.Id.urlImageView);
			String imageURL = "https://trabblestorageaccount.blob.core.windows.net/trabbleimages/AttractionImages/attraction_attractions_GardensByTheBay.jpg";

			Picasso.With(this).Load(imageURL).Placeholder(Resource.Drawable.placeholder).Into(imagen);
		}

	}
}

