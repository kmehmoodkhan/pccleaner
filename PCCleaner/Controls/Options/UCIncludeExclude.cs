using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.DataAccess;
using PCCleaner.Common;

namespace PCCleaner.Controls.Options
{
    public partial class UCIncludeExclude : UserControl
    {
        public UCIncludeExclude()
        {
            InitializeComponent();

            
        }

        bool isInclude = false;
        public bool IsInclude
        {
            get
            {
                return isInclude;
            }
            set
            {
                isInclude = value;
                if (isInclude)
                {
                    var data = IncludeExcludeOptions.GetIncludedItems();
                    foreach (DataRow dr in data.Table.Rows)
                    {
                        DataGridViewRow row = (DataGridViewRow)this.listBoxSelections.Rows[0].Clone();
                        row.Cells[0].Value = dr["Path"].ToString();
                        row.Cells[1].Value = dr["ItemType"].ToString();
                        row.Cells[2].Value = dr["Id"].ToString();
                        listBoxSelections.Rows.Add(row);
                    }
                }
                else
                {
                    var data = IncludeExcludeOptions.GetExcludedItems();
                    foreach (DataRow dr in data.Table.Rows)
                    {
                        DataGridViewRow row = (DataGridViewRow)this.listBoxSelections.Rows[0].Clone();
                        row.Cells[0].Value = dr["Path"].ToString();
                        row.Cells[1].Value = dr["ItemType"].ToString();
                        row.Cells[2].Value = dr["Id"].ToString();
                        listBoxSelections.Rows.Add(row);
                    }
                }
            }
        }

        public void ShowListing()
        {
            if (isInclude)
            {
                this.listBoxSelections.Rows.Clear();
                var data = IncludeExcludeOptions.GetIncludedItems();
                foreach (DataRow dr in data.Table.Rows)
                {
                    DataGridViewRow row = (DataGridViewRow)this.listBoxSelections.Rows[0].Clone();
                    row.Cells[0].Value = dr["Path"].ToString();
                    row.Cells[1].Value = dr["ItemType"].ToString();
                    row.Cells[2].Value = dr["Id"].ToString();
                    listBoxSelections.Rows.Add(row);
                }
            }
            else
            {
                this.listBoxSelections.Rows.Clear();
                var data = IncludeExcludeOptions.GetExcludedItems();
                foreach (DataRow dr in data.Table.Rows)
                {
                    DataGridViewRow row = (DataGridViewRow)this.listBoxSelections.Rows[0].Clone();
                    row.Cells[0].Value = dr["Path"].ToString();
                    row.Cells[1].Value = dr["ItemType"].ToString();
                    row.Cells[2].Value = dr["Id"].ToString();
                    listBoxSelections.Rows.Add(row);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FrmAddItem frmAddItem = new FrmAddItem();
            frmAddItem.IsInclude = IsInclude;
            frmAddItem.StartPosition = FormStartPosition.CenterParent;
            frmAddItem.ShowDialog(this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var item = this.listBoxSelections.SelectedRows[0].Cells[0].Value.ToString();
            var itemType = this.listBoxSelections.SelectedRows[0].Cells[1].Value.ToString();
            FrmAddItem frmAddItem = new FrmAddItem();

            frmAddItem.ItemType = Convert.ToInt32(itemType);
            frmAddItem.IsInclude = IsInclude;
            frmAddItem.ItemPath = item.ToString();
            frmAddItem.StartPosition = FormStartPosition.CenterParent;
            frmAddItem.ShowDialog(this);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var item = this.listBoxSelections.SelectedRows[0].Cells[2].Value.ToString();
            CleanerApplicationSettings.RemoveItem(item);
            ShowListing();
        }
    }
}
