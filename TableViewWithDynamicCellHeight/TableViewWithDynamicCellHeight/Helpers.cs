using System;
using CoreGraphics;
using UIKit;
using Foundation;

namespace TableViewWithDynamicCellHeight
{
	public static class Helpers
	{
		public static CGSize CalculateLabelSize(string text, nfloat width, nfloat height)
		{
			UIFont font = UIFont.SystemFontOfSize (20);
			NSString str = new NSString(text);
			UIStringAttributes attr = new UIStringAttributes() {
				Font = font
			};
			CGRect boundLabel = str.GetBoundingRect(new CGSize(width, height), NSStringDrawingOptions.UsesLineFragmentOrigin, attr, null);
			return boundLabel.Size;
		}
	}
}

