using System;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace LongNeckNerd
{
	public class AttractionListAdapter : RecyclerView.Adapter
	{
		public AttractionList mAttracitonList;
		private Context activityContext;

		public event EventHandler<int> attractionClick;
		
		public AttractionListAdapter(Context aContext, AttractionList attractionlist)
		{
			mAttracitonList = attractionlist;
			activityContext = aContext;
		}

		public override RecyclerView.ViewHolder 
		                            OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			// Inflate the CardView for the photo:
			View attractionView = LayoutInflater.From(parent.Context).
			                              Inflate(Resource.Layout.AttractionListLayout, parent, false);

			// Create a ViewHolder to hold view references inside the CardView:
			AttractionViewHolder viewHolder = new AttractionViewHolder(attractionView, OnClick);
			return viewHolder;
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			AttractionViewHolder viewHolder = holder as AttractionViewHolder;

			// Load the photo image resource from the photo album:
			String imageURL = mAttracitonList[position].mAttractionImageURL;
			ImageView imagen = viewHolder.Image;


			Picasso.With(activityContext).Load(imageURL).Placeholder(Resource.Drawable.placeholder).Into(imagen);

			// Load the Name
			viewHolder.Name.Text = mAttracitonList[position].mAttractionName;

			// Load the One Line Address
			viewHolder.OneLineAddress.Text = mAttracitonList[position].mAttractionOneLineAddress;

			// Load the Price
			viewHolder.Price.Text = mAttracitonList[position].mAttractionPrice;
		}

		public override int ItemCount
		{
			get { return mAttracitonList.mAttractionsCount; }
		}

		void OnClick(int position)
		{
			if (attractionClick != null)
				attractionClick(this, position);
		}
	}
}

