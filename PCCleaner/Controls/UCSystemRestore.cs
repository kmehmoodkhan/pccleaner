using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Controls
{
   
    public partial class UCSystemRestore : UserControl
    {
        public UCSystemRestore()
        {
            InitializeComponent();
            EnumRestorePoints();
        }

        private void EnumRestorePoints()
        {
            List<RestorePoint> restorePoints = new List<RestorePoint>();

            System.Management.ManagementClass objClass = new System.Management.ManagementClass("\\\\.\\root\\default", "systemrestore", new System.Management.ObjectGetOptions());
            System.Management.ManagementObjectCollection objCol = objClass.GetInstances();

            StringBuilder Results = new StringBuilder();
            foreach (System.Management.ManagementObject objItem in objCol)
            {
                RestorePoint point = new RestorePoint();
                point.Description = (string)objItem["description"];
                point.CreatedOn = System.Management.ManagementDateTimeConverter.ToDateTime((string)objItem["Creationtime"]).ToString();
                restorePoints.Add(point);
            }

            var list = restorePoints.OrderByDescending(t => t.CreatedOn);

            foreach( var grd in list)
            {
                DataGridViewRow dgrow = (DataGridViewRow)dataGridViewBackups.Rows[0].Clone();
                dgrow.Cells[0].Value = grd.Description;
                dgrow.Cells[1].Value = grd.CreatedOn;
                this.dataGridViewBackups.Rows.Add(dgrow);
            }
            

            //this.dataGridViewBackups.DataSource = restorePoints.OrderByDescending(t=>t.CreatedOn);
            this.dataGridViewBackups.Rows[0].ReadOnly = true;
        }
    }

    internal class RestorePoint
    {
        public string Description
        {
            get;
            set;
        }
        public string CreatedOn
        {
            get;
            set;
        }
    }
}
