using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_VN
{
    public partial class DB_Form : Form
    {
        public DB_Form()
        {
            InitializeComponent();
        }

        private void fVSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.fVSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBProjekt_VNDataSet);*/

        }

        private void DB_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProjekt_VNDataSet.FVSelect' table. You can move, or remove it, as needed.
            this.fVSelectTableAdapter.Fill(this.dBProjekt_VNDataSet.FVSelect);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
