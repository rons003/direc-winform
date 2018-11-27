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

namespace DBSI
{
    public class Token
    {
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var data = new Dictionary<string, string>
                {
                    { "grant_type", "password" },
                    { "client_id", "2" },
                    { "client_secret", "xJN7L9YZHfkPvmca3jtYRBb0A30SFBrr9o9lidpi" },
                    { "username", username_tb.Text },
                    { "password", password_tb.Text },
                    { "scope", "" }
                };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri(Utils.url);
            HttpResponseMessage response = client.PostAsJsonAsync("oauth/token", data).Result;
            if (response.IsSuccessStatusCode)
            {
                var res = response.Content.ReadAsStringAsync().Result;
                Token tokenInfo = JsonConvert.DeserializeObject<Token>(res);
                if (tokenInfo.access_token != null)
                {
                    Main mainForm = new Main(tokenInfo.access_token);
                    mainForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
