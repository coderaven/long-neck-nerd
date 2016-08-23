using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace LongNeckNerd
{
	public class AttractionViewHolder : RecyclerView.ViewHolder
	{
		public ImageView Image { get; private set; }
		public TextView Name { get; private set; }
		public TextView OneLineAddress { get; private set; }
		public TextView Price { get; private set; }
		
		public AttractionViewHolder(View itemView) : base(itemView)
		{
			// Locate and cache view references:
			Image = itemView.FindViewById<ImageView>(Resource.Id.imageViewAttraction);
			Name = itemView.FindViewById<TextView>(Resource.Id.textViewAttractionName);
			OneLineAddress = itemView.FindViewById<TextView>(Resource.Id.textViewAttractionOneLineAddress);
			Price = itemView.FindViewById<TextView>(Resource.Id.textViewAttractionPrice);
		}
	}
}

