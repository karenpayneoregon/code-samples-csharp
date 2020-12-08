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
using Microsoft.VisualStudio.Threading;
using PassingDataTable.Classes;

namespace PassingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Operations.StartMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Before");
            SomeTask().Forget();

            Console.WriteLine("After");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var firstNamesList = new List<string> { "Karen", "Jane", "Mike" };
            listBox1.DataSource = firstNamesList;
            comboBox1.DataSource = firstNamesList.Clone();
        }

        /// <summary>
        /// Install-Package Microsoft.VisualStudio.Threading -Version 16.8.55
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SomeTask()
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(2000);
                Console.WriteLine("hello");
                return true;
            });

        }
    }
    static class Extensions
    {
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable => 
            listToClone.Select(item => (T)item.Clone()).ToList();
    }

    public interface IOne
    {
        int Operation1(); 
    }

    public interface ITwo
    {
        int SomeOperations();
    }

    public class Example
    {
        public int Tester<T,U>(T one, U two) //where  T :IOne where  U : ITwo
        {
            return 0;
        }
    }
}
