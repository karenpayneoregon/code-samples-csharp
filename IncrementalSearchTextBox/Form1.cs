using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncrementalSearchTextBox
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _girlNamesBindingSource = new BindingSource();
        private BindingList<GirlName> _girlsNamesBindingList;  

        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
            SearchTextBox.TextChanged += SearchTextBoxOnTextChanged;
        }

        private void SearchTextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (_girlNamesBindingSource == null) return;

            List<GirlName> filtered = _girlsNamesBindingList.Where(nameItem => 
                nameItem.DisplayText.StartsWith(
                    SearchTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            _girlNamesBindingSource.DataSource = filtered;

        }

        private void OnShown(object sender, EventArgs e)
        {
            if (!FileOperations.GirlFileExits)
            {
                FileOperations.CreateGirlFile();
            }
            
            _girlsNamesBindingList = new BindingList<GirlName>(FileOperations.ReadGirlNames());
            _girlNamesBindingSource.DataSource = _girlsNamesBindingList;
            GirlsNameListBox.DataSource = _girlNamesBindingSource;

        }
    }


    public static class Extensions
    {
        public static string ToTitleCase(this string sender) 
            => string.IsNullOrWhiteSpace(sender) ? 
                sender : 
                CultureInfo.InvariantCulture.TextInfo.ToTitleCase(sender.ToLower());
    }

    public class FileOperations
    {

        public static string _fileName => "gNames.txt";
        public static bool GirlFileExits => File.Exists(_fileName);

        /// <summary>
        /// Used to create a list of names without extra data
        /// along with proper casing names
        /// </summary>
        public static void CreateGirlFile()
        {
            List<string> list = new List<string>();
            /*
             * girlnames.txt came from
             * https://github.com/SocialHarvest/harvester/blob/master/data/census-female-names.csv
             * populated via raw button, copied to girlnames.txt, set copy to output directory if newer
             */
            var names = File.ReadAllLines(_fileName);

            /*
             * assumes comma delimited with at least one item
             */
            foreach (var name in names)
            {
                string[] lineSplit = name.Split(',');
                list.Add(lineSplit[0].ToTitleCase());
            }

            list = list.OrderBy(item => item).ToList();

            File.WriteAllLines(_fileName, list.ToArray());
        }

        public static List<GirlName> ReadGirlNames()
        {
            List<GirlName> names = new List<GirlName>();

            var lines = File.ReadAllLines(_fileName);
            
            for (int index = 0; index < lines.Length -1; index++)
            {
                names.Add(new GirlName() {Index = index, DisplayText = lines[index]});
            }

            return names;
        }
    }
    
}
