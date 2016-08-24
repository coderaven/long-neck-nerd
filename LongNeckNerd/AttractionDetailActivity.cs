
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using Square.Picasso;

namespace LongNeckNerd
{
	[Activity(Label = "Attraction Details", Theme = "@style/CustomActionBarTheme", Icon = "@mipmap/icon")]
	public class AttractionDetailActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.AttractionDetail);

			var serializedAttraction = Intent.GetStringExtra("AttractionObject");
			var attraction = JsonConvert.DeserializeObject<Attraction>(serializedAttraction);

			// Display Image
			var imageView = FindViewById<ImageView>(Resource.Id.attractionDetailImage);
			Picasso.With(this).Load(attraction.mAttractionImageURL).Placeholder(Resource.Drawable.placeholder).Into(imageView);

			// Display Attraction Name
			FindViewById<TextView>(Resource.Id.attractionDetailText).Text = attraction.mAttractionName;

			// Display Attraction Type
			FindViewById<TextView>(Resource.Id.attractionTypeText).Text = attraction.mAttractionCategory;

			// Display Attraction Price
			FindViewById<TextView>(Resource.Id.attractionPriceText).Text = attraction.mAttractionPrice;

			// Display Attraction Description
			FindViewById<TextView>(Resource.Id.attractionDescriptionText).Text = attraction.mAttractionDescription;
		}
	}
}

