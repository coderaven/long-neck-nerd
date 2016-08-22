using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using SQLite;

namespace LongNeckNerd
{
	
	public class Attraction
	{
		static public string DATABASE_NAME = "attraction.db";
		static public string DATABASE_PATH = System.IO.Path.Combine(Android.OS.Environment.ExternalStorageDirectory.ToString(), DATABASE_NAME);

		public string mAttracitionID { get; set; }
		public string mAttractionName { get; set; }
		public string mAttractionDescription { get; set; }
		public string mAttractionOneLineAddress { get; set; }
		public string mAttractionNearestMRT { get; set; }
		public string mAttractionImageURL { get; set; }
		public string mAttractionLongitude { get; set; }
		public string mAttractionLatitude { get; set; }
		public string mAttractionCategory { get; set; }
		public string mAttractionPrice { get; set; }

		public Attraction()
		{
		}
	}

	public class AttractionList
	{
		static Attraction[] mBuiltInAttractions = {
			new Attraction {
				mAttracitionID = "26C73EAE-ED4D-4BFF-8741-C5BE2B217F46",
				mAttractionName = "Gardens By The Bay",
				mAttractionDescription = "Check out this multi-award winning horticultural destination featuring Supertrees and a lush Cloud Forest.",
				mAttractionOneLineAddress = "@ 18 Marina Gardens Drive",
				mAttractionNearestMRT = "Bayfront",
				mAttractionImageURL = "https://trabblestorageaccount.blob.core.windows.net/trabbleimages/AttractionImages/attraction_attractions_GardensByTheBay.jpg",
				mAttractionLongitude = "103.8614245",
				mAttractionLatitude = "1.2815737",
				mAttractionCategory = "Attractions",
				mAttractionPrice = "Under S$28"
			},
			new Attraction {
				mAttracitionID = "7F0A0C69-7D9A-4895-91B5-7D21DB45BAF8",
				mAttractionName = "Merlion Park",
				mAttractionDescription = "Snap a picture with Singapore's national icon, and admire the sweeping views of the Marina Bay from your location.",
				mAttractionOneLineAddress = "@ One Fullerton",
				mAttractionNearestMRT = "Esplanade",
				mAttractionImageURL = "https://trabblestorageaccount.blob.core.windows.net/trabbleimages/AttractionImages/attraction_attractions_MerlionPark.jpg",
				mAttractionLongitude = "103.8523435",
				mAttractionLatitude = "1.2868533",
				mAttractionCategory = "Attractions",
				mAttractionPrice = "Free"
			},
			new Attraction {
				mAttracitionID = "1AD00884-57A8-4786-8E0F-A536C334263A",
				mAttractionName = "MacRitchie Reservoir",
				mAttractionDescription = "Great place for nature lovers bordering Singapore's first reservoir and the Central Catchment Reserve.",
				mAttractionOneLineAddress = "@ MacRitchie Reservoir Park",
				mAttractionNearestMRT = "Caldecott",
				mAttractionImageURL = "https://trabblestorageaccount.blob.core.windows.net/trabbleimages/AttractionImages/attraction_nature_MacRitchieReservoir.jpg",
				mAttractionLongitude = "103.8132492",
				mAttractionLatitude = "1.3444535",
				mAttractionCategory = "Nature",
				mAttractionPrice = "Free"
			}
		};

		private Attraction[] mAttractions;

		public AttractionList()
		{
			mAttractions = mBuiltInAttractions;

			//var db = new SQLiteConnection(Attraction.DATABASE_PATH);
			//var count = db.ExecuteScalar<int>("SELECT Count(*) FROM Person");
			                      
		}

		public int mAttractionsCount
		{
			get { return mAttractions.Length; }
		}

		// Indexer (read only) for accessing a photo:
		public Attraction this[int i]
		{
			get { return mAttractions[i]; }
		}



	}
}

