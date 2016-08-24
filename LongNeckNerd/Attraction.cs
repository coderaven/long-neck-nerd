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
		public string mAttractionAddressLine1 { get; set; }
		public string mAttractionAddressLine2 { get; set; }
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

		private Attraction[] mAttractions;

		public AttractionList()
		{

			// Load Database (Try to optimize this into lazy loading - but might take up processing power.
			var db = new SQLiteConnection(Attraction.DATABASE_PATH);
			string query = "select id as mAttracitionID, Name as mAttractionName, Description as mAttractionDescription, AddressLine1 as mAttractionAddressLine1, AddressLine2 as mAttractionAddressLine2, NearestMRT as mAttractionNearestMRT, Longitude as mAttractionLongitude,  ImageUrl as mAttractionImageURL, OneLineAddress as mAttractionOneLineAddress, Latitude as mAttractionLatitude, Category as mAttractionCategory, Price as mAttractionPrice from Attraction";
			mAttractions = db.Query<Attraction>(query).ToArray();

			// mCount = db.ExecuteScalar<int>("Select count(*) from Attraction;");

		}

		public int mAttractionsCount
		{
			get { return mAttractions.Length; }
		}

		// Indexer (read only)
		public Attraction this[int i]
		{
			get { return mAttractions[i]; }
		}



	}
}

