using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace LongNeckNerd
{
	public class AttractionViewHolder : RecyclerView.ViewHolder
	{
		public ImageView Image { get; private set; }
		public TextView Description { get; private set; }
		
		public AttractionViewHolder(View itemView) : base(itemView)
		{
			// Locate and cache view references:
			Image = itemView.FindViewById<ImageView>(Resource.Id.imageViewAttraction);
			Description = itemView.FindViewById<TextView>(Resource.Id.textViewAttractionDescription);
		}
	}
}

