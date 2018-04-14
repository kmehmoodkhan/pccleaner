using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Common;

namespace PCCleaner.Controls.Common
{
    public partial class UCResultRegistry : UserControl
    {
        public UCResultRegistry()
        {
            InitializeComponent();
        }

        public void ShowResult(ResultView view, ResultSummary summary)
        {

            if (view == ResultView.Detail)
            {

                this.dataGridViewDetail.Visible = true;

                var bindingList = new BindingList<ResultDetail>(summary.DetailResult);
                var source = new BindingSource(bindingList, null);
                this.dataGridViewDetail.AutoGenerateColumns = false;
                this.dataGridViewDetail.DataSource = source;
                this.dataGridViewDetail.RowHeadersVisible = false;
                this.dataGridViewDetail.ColumnHeadersVisible = false;
                this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
        }
        
    }
}
