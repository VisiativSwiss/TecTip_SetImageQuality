using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace TecTip_ImageQuality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;

            swModel.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swImageQualityApplyToAllReferencedPartDoc,
                (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            swModel.SetTessellationQuality(50);
        }
    }
}
