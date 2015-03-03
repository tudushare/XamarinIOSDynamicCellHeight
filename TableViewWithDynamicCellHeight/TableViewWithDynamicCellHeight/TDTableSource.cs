using System;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;

namespace TableViewWithDynamicCellHeight
{
	public class TDTableSource: UITableViewSource
	{
		public List<string> Contents{ get; set;}

		public TDTableSource ()
		{
			GetData ();
		}

		void GetData ()
		{
			Contents = new List<string> ();
			Contents.Add ("this is first row");
			Contents.Add ("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
			Contents.Add ("Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.");
			Contents.Add ("It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
			Contents.Add ("The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

		}

		#region implemented abstract members of UITableViewSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = (TDCustomCell) tableView.DequeueReusableCell (TDCustomCell.Key);
			var msg = Contents [indexPath.Row];
			if (indexPath.Row % 2 == 0) {
				cell.BackgroundColor = UIColor.Green;
			} else {
				cell.BackgroundColor = UIColor.White;
			}
			cell.LoadData (msg);
			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			if (Contents != null) {
				return Contents.Count;
			} else
				return 0;
		}

		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{

			var size = Helpers.CalculateLabelSize(Contents[indexPath.Row] , tableView.Bounds.Width, tableView.Bounds.Height);
			return size.Height;
		}

		
		#endregion
	}
}

