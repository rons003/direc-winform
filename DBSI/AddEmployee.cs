using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DBSI
{
    public partial class AddEmployee : Form
    {

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var data = new Dictionary<string, string>
                {
                    { "lastname",  lastname_tb.Text},
                    { "firstname", firstname_tb.Text },
                    { "middlename", middlename_tb.Text },
                    { "contact_number", contact_tb.Text },
                    { "email", email_tb.Text },
                    { "address", adress_rtb.Text },
                    { "gender", gender_cb.Text },
                    { "national", national_tb.Text }
                };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Main.access_token);
            client.BaseAddress = new Uri(Utils.url);
            HttpResponseMessage response = client.PostAsJsonAsync("api/employee/add", data).Result;
            if (response.IsSuccessStatusCode)
            {
                JObject jobject = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                if(jobject["result"].ToString() == "success")
                {
                    MessageBox.Show("Successfully Added!");
                    this.Hide();
                }
            }
        }
    }
}
