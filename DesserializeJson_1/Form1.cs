using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonSampleLibrary;
using JsonSampleLibrary.Classes;
using JsonSampleLibrary.Models;


namespace DesserializeJson_1
{
    /// <summary>
    /// Requires this NuGet package
    /// https://www.nuget.org/packages/System.Text.Json
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomerOperations.OnExceptionEvent += CustomerOperations_OnExceptionEvent;
        }


        private DeserializeException _deserializeException;
        private void CustomerOperations_OnExceptionEvent(DeserializeException container)
        {
            _deserializeException = container;
        }

        private void deserializeButton_Click(object sender, EventArgs e)
        {
            string style = @"
    table.blueTable {
      border: 1px solid #1C6EA4;
      background-color: #EEEEEE;
      width: 100%;
      text-align: left;
      border-collapse: collapse;
    }
    table.blueTable td, table.blueTable th {
      border: 1px solid #AAAAAA;
      padding: 3px 2px;
    }
    table.blueTable tbody td {
      font-size: 13px;
    }
    table.blueTable tr:nth-child(even) {
      background: #D0E4F5;
    }
    table.blueTable thead {
      background: #1C6EA4;
      background: -moz-linear-gradient(top, #5592bb 0%, #327cad 66%, #1C6EA4 100%);
      background: -webkit-linear-gradient(top, #5592bb 0%, #327cad 66%, #1C6EA4 100%);
      background: linear-gradient(to bottom, #5592bb 0%, #327cad 66%, #1C6EA4 100%);
      border-bottom: 2px solid #444444;
    }
    table.blueTable thead th {
      font-size: 15px;
      font-weight: bold;
      color: #FFFFFF;
      border-left: 2px solid #D0E4F5;
    }
    table.blueTable thead th:first-child {
      border-left: none;
    }

    table.blueTable tfoot {
      font-size: 14px;
      font-weight: bold;
      color: #FFFFFF;
      background: #D0E4F5;
      background: -moz-linear-gradient(top, #dcebf7 0%, #d4e6f6 66%, #D0E4F5 100%);
      background: -webkit-linear-gradient(top, #dcebf7 0%, #d4e6f6 66%, #D0E4F5 100%);
      background: linear-gradient(to bottom, #dcebf7 0%, #d4e6f6 66%, #D0E4F5 100%);
      border-top: 2px solid #444444;
    }
    table.blueTable tfoot td {
      font-size: 14px;
    }
    table.blueTable tfoot .links {
      text-align: right;
    }
    table.blueTable tfoot .links a{
      display: inline-block;
      background: #1C6EA4;
      color: #FFFFFF;
      padding: 2px 8px;
      border-radius: 5px;
    }
    h1 { color: #7c795d; font-family: 'Trocchi', serif; font-size: 45px; font-weight: normal; line-height: 48px; margin: 0; }
    h2 { color: #7c795d; font-family: 'Source Sans Pro', sans-serif; font-size: 28px; font-weight: 400; line-height: 32px; margin: 0 0 24px; }
";
            var sb = new StringBuilder();

            var fileName = "coldfusion.json";
            var json = File.ReadAllText(fileName);
            var results = JsonSerializer.Deserialize<List<ColdFusion>>(json);
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");

            sb.AppendLine("<style>");
            sb.AppendLine(style);
            sb.AppendLine("</style>");


            sb.AppendLine("</head>");
            sb.AppendLine("</body>");

            sb.AppendLine("<h1>Cold Fusion extension for VS Code</h1>");
            sb.AppendLine("<h2>Extracted from source by Karen Payne</h2>");

            sb.AppendLine("<table class='blueTable'>");
            foreach (var coldFusion in results)
            {
                sb.AppendLine("<tr>");
                sb.AppendLine($"<td><strong>{coldFusion.prefix}</strong></td>");
                sb.AppendLine("</tr>");

                sb.AppendLine("<tr>");
                
                sb.AppendLine($"<td><pre>{coldFusion.documentation.Replace("**USAGE:**", "<strong>USAGE:</strong>").Replace("**PARAMETERS:**", "<strong>PARAMETERS:</strong>").Replace("*", "")}</pre></td>");
                sb.AppendLine("</tr>");

            }

            sb.AppendLine("</table>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            File.WriteAllText("coldfusion.html", sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Customer> customers;
            _deserializeException = new DeserializeException();
            customers = CustomerOperations.IgnoreNullValuesTest(5);

            if (!_deserializeException.HasException)
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.Id}, {customer.CompanyName}, [{customer.ContactTitle}] [{customer.ContactFirstName}] [{customer.ContactLastName}] [{customer.CountryIdentifier == null}]");
                }

            }
            else
            {
                MessageBox.Show($"Failed to read customers\n{_deserializeException.Exception.Message}\nfrom {_deserializeException.MethodName}");
            }

        }
    }


    public class Data1
    {
        public string field_name { get; set; }
        public object field_value { get; set; }
    }


    public class ColdFusion 
    {
        public string prefix { get; set; }
        public string body { get; set; }
        public string documentation { get; set; }
        public override string ToString() => documentation;

    }


}
