using System;
using UIKit;
using CoreGraphics;

namespace TableViewWithDynamicCellHeight
{
	public class TDDynamicCellHeightViewController: UIViewController
	{
		private nfloat _width;
		private nfloat _height;
		private UITableView _tableView;
		private TDTableSource _tableSource;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			_width = View.Bounds.Width;
			_height = View.Bounds.Height;
			View.BackgroundColor = UIColor.White;
			// add tableview
			_tableView = new UITableView (new CGRect (0, 50, _width, _height - 50));
			View.AddSubview (_tableView);

			// set table source
			_tableSource = new TDTableSource ();
			_tableView.Source = _tableSource;
			_tableView.RegisterClassForCellReuse(typeof(TDCustomCell),TDCustomCell.Key);

		}
	}
}

