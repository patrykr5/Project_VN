using System;
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
            this.Validate();
            this.fVSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBProjekt_VNDataSet);
        }

        private void DB_Form_Load(object sender, EventArgs e)
        {
            this.fVSelectTableAdapter.Fill(this.dBProjekt_VNDataSet.FVSelect);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
