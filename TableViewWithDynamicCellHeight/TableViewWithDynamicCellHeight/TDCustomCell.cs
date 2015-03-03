using System;
using UIKit;
using Foundation;

namespace TableViewWithDynamicCellHeight
{
	public class TDCustomCell: UITableViewCell
	{
		public static readonly NSString Key = new NSString ("TDCustomCell");
		protected UILabel _msg;

		public TDCustomCell (IntPtr handle) : base (handle)
		{
			_msg = new UILabel ();
			_msg.Font = UIFont.SystemFontOfSize (20);
			_msg.Lines = 0;
			_msg.TextColor = UIColor.Blue;
			AddSubview (_msg);
		}

		/// <summary>
		/// Load the data.
		/// </summary>
		/// <param name="msg">Message.</param>
		public void LoadData(string msg)
		{
			_msg.Text = msg;
			var size = Helpers.CalculateLabelSize (msg, Bounds.Width, float.MaxValue);
			_msg.Frame = new CoreGraphics.CGRect (0, 0, Bounds.Width, size.Height);
			SetNeedsLayout();
		}
	}
}

