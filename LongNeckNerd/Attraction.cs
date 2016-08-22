using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace LongNeckNerd
{
	public class Attraction
	{
		public string mAttracitionID;
		public string mAttractionName;
		public string mAttractionDescription;
		public string mAttractionOneLineAddress;
		public string mAttractionNearestMRT;
		public string mAttractionImageURL;
		public string mAttractionLongitude;
		public string mAttractionLatitude;
		public string mAttractionCategory;
		public string mAttractionPrice;

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

