using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PersonalData.Classes;

namespace PersonalData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            var results = JsonOperations.Read();

            if (results != null)
            {
                var profile = results.TechProfile;

                DisplayNameTextBox.Text = profile.DisplayName;
                MvpCheckBox.Checked = profile.IsMvp;
                DateAddedTextBox.Text = profile.AuthenticationModes.FirstOrDefault()?.DateAdded.ToString("d");
            }
            else
            {
                MessageBox.Show("We failed to find your file.");
            }
        }
    }
}
