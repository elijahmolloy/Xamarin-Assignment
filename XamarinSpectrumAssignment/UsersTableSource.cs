using System;
using Foundation;
using UIKit;
using System.Collections.Generic;


namespace XamarinSpectrumAssignment
{
    public class UsersTableSource : UITableViewSource
    {
        List<User> tableItems;


        public UsersTableSource(List<User> tableItems)
        {
            this.tableItems = tableItems;
        }


        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("userCell");

            String fullName = tableItems[indexPath.Row].firstName.Trim() + " " + tableItems[indexPath.Row].lastName.Trim();
            cell.TextLabel.Text = fullName;

            return cell;
        }


        public User GetItem(int id)
        {
            return tableItems[id];
        }
    }
}
