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
    public partial class Main : Form
    {
        public static string access_token = null;
        public Main(string token)
        {
            InitializeComponent();
            access_token = token;
            getAllEmployee();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeeForm = new AddEmployee();
            addEmployeeForm.ShowDialog();
        }

        private void getAllEmployee()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(Utils.url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Main.access_token);
            HttpResponseMessage response = client.GetAsync("api/employee").Result;
            if (response.IsSuccessStatusCode)
            {
                JObject jobject = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                if(jobject["result"].ToString() == "success")
                {
                    JArray jarray = (JArray)jobject["employee"];
                    Employee[] employee = jarray.ToObject<Employee[]>();
                    dataGridView1.DataSource = employee;
                }
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            getAllEmployee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAllEmployee();
        }
    }
}
