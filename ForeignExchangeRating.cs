using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace GetForeignExchangeRate
{
    public partial class ForeignExchangeRating : DevExpress.XtraEditors.XtraForm
    {
        public class Rootobject
        {
            public List<Class1> Property1 { get; set; }
        }

        public class Class1
        {
            public DateTime last_date { get; set; }
            public string code { get; set; }
            public string rate { get; set; }
            public decimal rate_float { get; set; }
            public string name { get; set; }
        }

        public ForeignExchangeRating()
        {
            InitializeComponent();
        }

        private void ForeignExchangeRating_Load(object sender, EventArgs e)
        {
        }
        public bool verif()
        {
            if(cboBaseCurrencyType.Text == "" ||
                cboQuoteCurrency.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                /*
                var client = new WebClient();
                string rawJSON = client.DownloadString("http://monxansh.appspot.com/xansh.json?currency=USD|EUR");
                */
                string baseCType = cboBaseCurrencyType.Text;
                string quoteCtype = cboQuoteCurrency.Text;
                var http = (HttpWebRequest)WebRequest.Create("http://monxansh.appspot.com/xansh.json?currency=" + baseCType + "|" + quoteCtype);
                var response = http.GetResponse();

                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream);
                var content = sr.ReadToEnd();

                var rootobject = JsonConvert.DeserializeObject<List<Class1>>(content);

                textEditBaseCRate.Text = rootobject[0].rate;
                textEditQuoteCRate.Text = rootobject[1].rate;

                decimal baseRate = rootobject[0].rate_float;
                decimal quoteRate = rootobject[1].rate_float;

                textEditHaritsaa.Text = Convert.ToString("1/" + Convert.ToString(baseRate / quoteRate));

                
            }
            else
            {
                MessageBox.Show("Валютын төрөлөө оруулнө уу", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}