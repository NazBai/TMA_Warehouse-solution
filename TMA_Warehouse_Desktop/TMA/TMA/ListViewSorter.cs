using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMA
{
    internal class ListViewSorter : IComparer
    {
        private int columnToSort;
        private SortOrder orderOfSort;
        private CaseInsensitiveComparer objectCompare;

        public ListViewSorter()
        {
            columnToSort = 0;
            orderOfSort = SortOrder.None;
            objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int result;

            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            double numberX, numberY;
            bool successX = Double.TryParse(itemX.SubItems[columnToSort].Text, NumberStyles.Number, CultureInfo.CurrentCulture, out numberX);
            bool successY = Double.TryParse(itemY.SubItems[columnToSort].Text, NumberStyles.Number, CultureInfo.CurrentCulture, out numberY);

            if (successX && successY)
            {
                result = numberX.CompareTo(numberY);
            }
            else
            {
                result = String.Compare(itemX.SubItems[columnToSort].Text, itemY.SubItems[columnToSort].Text);
            }

            if (orderOfSort == SortOrder.Descending)
            {
                result = -result;
            }

            return result;
        }

        public int SortColumn
        {
            set
            {
                columnToSort = value;
            }
            get
            {
                return columnToSort;
            }
        }

        public SortOrder Order
        {
            set
            {
                orderOfSort = value;
            }
            get
            {
                return orderOfSort;
            }
        }
    }
}