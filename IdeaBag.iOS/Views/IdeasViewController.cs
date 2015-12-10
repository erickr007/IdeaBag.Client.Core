using System;
using UIKit;
using Foundation;

namespace IdeaBag.Client.iOS.Views
{
	public class IdeasViewController : UITableViewController
	{
		public IdeasViewController ()
		{
			BuildLayout ();
		}


		#region View Builder Methods

		private void BuildLayout(){
			this.TableView = new UITableView (View.Bounds);
			string[] tableItems = new string[] {"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
			this.TableView.Source = new IdeasTableViewSource(tableItems);


			//- Search Bar
			UISearchBar searchbar = new UISearchBar (
				                        new CoreGraphics.CGRect (0, 0, 320, 44));
			searchbar.Placeholder = "Search";
			this.TableView.Add (searchbar);

		}

		#endregion
	}

	public class IdeasTableViewSource : UITableViewSource{
		string[] TableItems;
		string CellIdentifier = "TableCell";

		public IdeasTableViewSource (string[] items)
		{
			TableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems[indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}
			
		public override string TitleForHeader (UITableView tableView, nint section)
		{
			if (section == 1)
				return "Recent";
			else
				return "Older Ideas";
		}

	}
}

