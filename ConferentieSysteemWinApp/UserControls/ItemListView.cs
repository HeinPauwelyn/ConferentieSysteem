using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public class ItemListView : ListView    
    {
        private List<object> _items = new List<object>();

        public new List<object> Items 
        {
            get 
            {
                return _items;
            }
        }

        public ItemListView()
        {
            base.FullRowSelect = true;
            base.MultiSelect = false;
            base.View = View.Details;
        }

        public void Add(object obj, ListViewItem lvi)
        {
            Items.Add(obj);

            int mod = Items.Count % 2;
            if (mod == 0)
            {
                lvi.BackColor = Color.Gainsboro;
            }
            else
            {
                lvi.BackColor = Color.White;
            }

            base.Items.Add(lvi);
        }

        public object GetSelectedItem()
        {
            if (base.SelectedItems.Count == 1)
            {
                int index = base.SelectedIndices[0];

                return this.Items[index];
            }
            else
            {
                return null;
            }
        }

        public int CountSelectedItems()
        {
            return base.SelectedItems.Count;
        }

        public List<object> GiveCheckedItems()
        {
            List<Object> CheckedItems = new List<object>();

            for (int teller = 0; teller < base.Items.Count; teller++)
            {
                ListViewItem lvi = base.Items[teller];

                if (lvi.Checked)
                {
                    CheckedItems.Add(this.Items[teller]);
                }
            }

            return CheckedItems;
        }

        public void ClearItems()
        {
            base.Items.Clear();
            this.Items.Clear();
        }
    }
}
