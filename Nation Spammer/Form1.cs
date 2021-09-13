using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RestSharp;

namespace Nation_Spammer
{
    public partial class Form1 : Form
    {
        public TextBox textTokens = new TextBox();
        public TextBox textProxies = new TextBox();
        bool spamming;
        bool threader;
        bool typer;
        public static Random rand = new Random();
        internal static readonly char[] everything = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textTokens.Text = File.ReadAllText("tokens.txt");
            bunifuLabel11.Text = File.ReadLines("tokens.txt").Count().ToString();
            textProxies.Text = File.ReadAllText("proxies.txt");
            bunifuLabel2.Text = File.ReadLines("proxies.txt").Count().ToString();
            /*var client = new RestClient("https://discord.com/api/v9/auth/verify");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "ODcwMzgxODA2OTEyOTM0MDEw.YQL8Ow.FvYW9WeXBhbO_ys1_JUG-8lszUA");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);*/
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        { 
            Process.GetCurrentProcess().Kill();
        }
        public static int randomNumber(int min, int cap)
        {
            return rand.Next(min, cap);
        }

        public string[] ProxyGet()
        {
            try
            {
                WebClient webClient = new WebClient();
                TextBox textboxa = new TextBox();
                textboxa.Text = File.ReadAllLines("proxies.txt").ToString();
                return Strings.Split(textboxa.Lines[randomNumber(0, textboxa.Lines.Length)], ":");
            }
            catch (Exception)
            {
            }
            return new string[] { };
        }

        private void ThreadLeaver()
        {
            try
            {
            }
            catch (Exception)
            {
            }
        }


        private void ThreadSpammer()
        {
            try
            {
                while (!threader)
                {
                    foreach (string token in textTokens.Lines)
                    {
                        string data = "{\"name\":Raid-By-SaturneSpammer\"\",\"type\":GUILD_PUBLIC_THREAD\"\",\"auto_archive_duration\":1440\"}";
                        string url = "https://discord.com/api/v9/channels/" + bunifuTextBox15.Text + "/threads"; ;
                        var client = new RestClient(url);
                        var request = new RestRequest(Method.POST);
                        request.AddHeader("Authorization", token);
                        request.AddHeader("X-Audit-Log-Reason", "Raid-By-SaturneSpammer-xD");
                        request.AddJsonBody(data, "application/json");
                        //request.AddHeader("Content-Type", "application/json");
                        //request.AddParameter("application/json", "{\"name\":\"" + "Raid-By-SaturneSpammer" + "\"}");
                        IRestResponse response = client.Execute(request);
                        Console.WriteLine(response.Content);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void username()
        {
            try
            {
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discord.com/api/v9/users/@me/settings");
                    var request = new RestRequest(Method.PATCH);
                    request.AddHeader("Authorization", token);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{\"username\":\"" + bunifuTextBox13.Text + "\"}");
                    IRestResponse response = client.Execute(request);
                }
            }
            catch
            {
            }
        }

        private void Status()
        {
            try
            {
                string statusso = "online";
                if (metroComboBox2.SelectedItem.ToString() == "Online")
                {
                    statusso = "online";
                }
                else if (metroComboBox2.SelectedItem.ToString() == "Idle")
                {
                    statusso = "idle";
                }
                else if (metroComboBox2.SelectedItem.ToString() == "Do Not Disturbe")
                {
                    statusso = "dnd";
                }
                else if (metroComboBox2.SelectedItem.ToString() == "Invisible")
                {
                    statusso = "invisible";
                }

                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discord.com/api/v9/users/@me/settings");
                    var request = new RestRequest(Method.PATCH);
                    request.AddHeader("Authorization", token);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{\"status\":\"" + statusso + "\"}");
                    IRestResponse response = client.Execute(request);
                }
            }
            catch
            {
            }
        }
        private void HypeSquad()
        {
            try
            {
                int hypesquad = 0;
                if (metroComboBox1.SelectedItem.ToString() == "HypeSquad Bravery")
                {
                    hypesquad = 1;
                }
                if (metroComboBox1.SelectedItem.ToString() == "HypeSquad Balance")
                {
                    hypesquad = 3;
                }
                else if (metroComboBox1.SelectedItem.ToString() == "HypeSquad Brilliance")
                {
                    hypesquad = 2;
                }

                foreach(string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discord.com/api/v9/hypesquad/online");
                    var request = new RestRequest(Method.PATCH);
                    request.AddHeader("Authorization", token);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{\"house_id\":" + hypesquad.ToString() + "}");
                    IRestResponse response = client.Execute(request);
                }
            }
            catch
            {
            }
        }

        private void checkTokens()
        {
            try
            {
                //token checker qui
            }
            catch (Exception)
            {
            }
        }

        private void friendAdder()
        {
            try
            {
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discordapp.com/api/v9/users/@me/relationships/" + bunifuTextBox12.Text);
                    var request = new RestRequest(Method.PUT);
                    request.AddHeader("Authorization", token);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{}");
                    IRestResponse response = client.Execute(request);
                    Thread.Sleep(bunifuHSlider2.Value);
                }
            }
            catch (Exception)
            {
            }
        }

        private void friendRemover()
        {
            try
            {
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discordapp.com/api/v9/users/@me/relationships/" + bunifuTextBox12.Text);
                    var request = new RestRequest(Method.DELETE);
                    request.AddHeader("Authorization", token);
                    IRestResponse response = client.Execute(request);
                }
            }
            catch (Exception)
            {
            }
        }

        private void guildLeaver()
        {
            try
            {
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discordapp.com/api/v9/users/@me/guilds/" + bunifuTextBox7.Text);
                    var request = new RestRequest(Method.DELETE);
                    request.AddHeader("Authorization", token);
                    IRestResponse response = client.Execute(request);
                }
            }
            catch (Exception)
            {
            }
        }

        private void guildJoiner()
        {
            try
            {
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("http://discordapp.com/api/guilds/" + bunifuTextBox7.Text + "/members/869013303286988870");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Authorization", token);
                    /*request.AddHeader("Accept", "");
                    request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                    request.AddHeader("Accept-Language", "en-US");
                    request.AddHeader("Alt-Used", "discord.com");
                    request.AddHeader("Authorization", token);
                    request.AddHeader("Connection", "keep-alive");
                    request.AddHeader("Content-Length", "0");
                    request.AddHeader("Cookie", GetCookies());
                    request.AddHeader("DNT", "1");
                    request.AddHeader("Host", "discord.com");
                    request.AddHeader("Origin", "https://discord.com");
                    request.AddHeader("Referer", "https://discord.com/channels/@me");
                    request.AddHeader("TE", "Trailers");
                    request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0");
                    request.AddHeader("X-Context-Properties", "eyJsb2NhdGlvbiI6IkpvaW4gR3VpbGQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6IjgyMDMyODI4NzAxMTQ3MTM5MCIsImxvY2F0aW9uX2NoYW5uZWxfaWQiOiI4MjAzMjgyODcwMzI5NjcyMjkiLCJsb2NhdGlvbl9jaGFubmVsX3R5cGUiOjB9");
                    request.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzkwLjAuNDQzMC44NSBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTAuMC40NDMwLjg1Iiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiJodHRwczovL3JlcGwuaXQvIiwicmVmZXJyaW5nX2RvbWFpbiI6InJlcGwuaXQiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");*/
                    IRestResponse response = client.Execute(request);
                    MessageBox.Show(response.Content);
                }
            }
            catch (Exception)
            {
            }
        }

        public static string GetTest()
        {
            try
            {
                string dayOfWeek = "", month = "", day = "", year = "", hour = "", minute = "", second = "";

                DateTime nowTime = GetCurrentRealDateTime();
                day = nowTime.Day.ToString();

                if (day.Length == 1)
                {
                    day = "0" + day;
                }

                year = nowTime.Year.ToString();
                hour = nowTime.Hour.ToString();
                minute = nowTime.Minute.ToString();
                second = nowTime.Second.ToString();

                if (hour.Length == 1)
                {
                    hour = "0" + hour;
                }

                if (minute.Length == 1)
                {
                    minute = "0" + minute;
                }

                if (second.Length == 1)
                {
                    second = "0" + second;
                }

                if (nowTime.Month == 1)
                {
                    month = "Jan";
                }
                else if (nowTime.Month == 2)
                {
                    month = "Feb";
                }
                else if (nowTime.Month == 3)
                {
                    month = "Mar";
                }
                else if (nowTime.Month == 4)
                {
                    month = "Apr";
                }
                else if (nowTime.Month == 5)
                {
                    month = "May";
                }
                else if (nowTime.Month == 6)
                {
                    month = "Jun";
                }
                else if (nowTime.Month == 7)
                {
                    month = "Jul";
                }
                else if (nowTime.Month == 8)
                {
                    month = "Aug";
                }
                else if (nowTime.Month == 9)
                {
                    month = "Sep";
                }
                else if (nowTime.Month == 10)
                {
                    month = "Oct";
                }
                else if (nowTime.Month == 11)
                {
                    month = "Nov";
                }
                else if (nowTime.Month == 12)
                {
                    month = "Dec";
                }

                if (nowTime.DayOfWeek == DayOfWeek.Monday)
                {
                    dayOfWeek = "Mon";
                }
                else if (nowTime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    dayOfWeek = "Tue";
                }
                else if (nowTime.DayOfWeek == DayOfWeek.Wednesday)
                {
                    dayOfWeek = "Wed";
                }
                else if (nowTime.DayOfWeek == DayOfWeek.Thursday)
                {
                    dayOfWeek = "Thu";
                }
                else if (nowTime.DayOfWeek == DayOfWeek.Friday)
                {
                    dayOfWeek = "Fri";
                }
                else if (nowTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    dayOfWeek = "Sat";
                }
                else if (nowTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    dayOfWeek = "Sun";
                }

                return "isIABGlobal=false&datestamp=" + dayOfWeek + "+" + month + "+" + day + "+" + year + "+" + hour + ":" + minute + ":" + second + "+GMT+0200+(Ora+legale+dellâEuropa+centrale)&version=6.17.0&hosts=&landingPath=NotLandingPage&groups=C0001:1,C0002:1,C0003:1&geolocation=IT;62&AwaitingReconsent=false";
            }
            catch
            {
                return "";
            }
        }

        public string GetCookies()
        {
            string cookie = "";
            cookie = GetRandomCookie();
            return cookie + "; OptanonConsent=" + GetTest();
        }

        public static DateTime GetCurrentRealDateTime()
        {
            try
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds + 7200L);
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public static string GetRandomCookie()
        {
            try
            {
                return "__cfduid=" + GetUniqueKey1(43) + "; __dcfduid=" + GetUniqueKey1(32) + "; rebrand_bucket=" + GetUniqueKey1(32) + "; OptanonAlertBoxClosed=2021-05-30T14:59:00.092Z; locale=" + "en-US";
            }
            catch
            {
                return "";
            }
        }

        public static string GetUniqueKey1(int size)
        {
            try
            {
                byte[] data = new byte[4 * size];

                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }

                StringBuilder result = new StringBuilder(size);

                for (int i = 0; i < size; i++)
                {
                    var rnd = BitConverter.ToUInt32(data, i * 4);
                    var idx = rnd % everything.Length;

                    result.Append(everything[idx]);
                }

                return result.ToString();
            }
            catch
            {
                return "";
            }
        }

        private void typing()
        {
            try
            {
                while(!typer)
                {
                    foreach (string token in textTokens.Lines)
                    {
                        var client = new RestClient("https://discord.com/api/v9/channels/" + bunifuTextBox9.Text + "/typing");
                        var request = new RestRequest(Method.POST);
                        request.AddHeader("Authorization", token);
                        IRestResponse response = client.Execute(request);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void reactionRemover()
        {
            try
            {
                string emoji = HttpUtility.UrlEncode(bunifuTextBox4.Text);
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discordapp.com/api/v9/channels/" + bunifuTextBox6.Text + "/messages/" + bunifuTextBox3.Text + "/reactions/" + emoji + "/@me");
                    var request = new RestRequest(Method.DELETE);
                    request.AddHeader("Authorization", token);
                    IRestResponse response = client.Execute(request);
                }
            }
            catch (Exception)
            {
            }
        }
        private void reactionAdder()
        { 
            try
            {
                string emoji = HttpUtility.UrlEncode(bunifuTextBox4.Text);
                foreach (string token in textTokens.Lines)
                {
                    var client = new RestClient("https://discordapp.com/api/v9/channels/" + bunifuTextBox6.Text + "/messages/" + bunifuTextBox3.Text + "/reactions/" + emoji + "/@me");
                    var request = new RestRequest(Method.PUT);
                    request.AddHeader("Authorization", token);
                    IRestResponse response = client.Execute(request);
                }
            }
            catch (Exception)
            {
            }
        }

        private void spammer()
        {
            try
            {
                var args = bunifuTextBox1.Text.Split(", ".ToCharArray());
                if(metroCheckBox2.Checked)
                {
                    foreach(string canale in args)
                    {
                        while (!spamming)
                        {
                            foreach (string token in textTokens.Lines)
                            {
                                try
                                {
                                    string data = "";
                                    if (bunifuTextBox10.Text == "")
                                    {
                                        data = "{\"content\":\"" + bunifuTextBox2.Text + "\",\"tts\":false}";
                                    }
                                    else
                                    {
                                        data = "{\"content\":\"" + bunifuTextBox2.Text + "\",\"tts\":false,\"message_reference\":{\"channel_id\":\"" + bunifuTextBox1.Text + "\",\"message_id\":\"" + bunifuTextBox10.Text + "\"}}";
                                    }
                                    var client = new RestClient("https://discord.com/api/v9/channels/" + canale + "/messages");
                                    var request = new RestRequest(Method.POST);
                                    request.AddHeader("Authorization", token);
                                    request.AddHeader("Content-Type", "application/json");
                                    request.AddParameter("application/json", data, ParameterType.RequestBody);
                                    IRestResponse response = client.Execute(request);
                                    if(metroCheckBox3.Checked)
                                    {
                                        Thread.Sleep(bunifuHSlider4.Value);
                                    }
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                    }
                }
                else
                {
                    while (!spamming)
                    {
                        foreach (string token in textTokens.Lines)
                        {
                            try
                            {
                                string data = "";
                                if (bunifuTextBox10.Text == "")
                                {
                                    data = "{\"content\":\"" + bunifuTextBox2.Text + "\",\"tts\":false}";
                                }
                                else
                                {
                                    data = "{\"content\":\"" + bunifuTextBox2.Text + "\",\"tts\":false,\"message_reference\":{\"channel_id\":\"" + bunifuTextBox1.Text + "\",\"message_id\":\"" + bunifuTextBox10.Text + "\"}}";
                                }
                                var client = new RestClient("https://discord.com/api/v9/channels/" + bunifuTextBox1.Text + "/messages");
                                var request = new RestRequest(Method.POST);
                                request.AddHeader("Authorization", token);
                                request.AddHeader("Content-Type", "application/json");
                                request.AddParameter("application/json", data, ParameterType.RequestBody);
                                IRestResponse response = client.Execute(request);
                                if (metroCheckBox3.Checked)
                                {
                                    Thread.Sleep(bunifuHSlider4.Value);
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = 3;
                if (metroRadioButton2.Checked)
                {
                    numero = 3;
                }
                else if (metroRadioButton1.Checked)
                {
                    numero = 10;
                }
                else if (metroRadioButton9.Checked)
                {
                    numero = 15;
                }
                for (int i = 0; i < numero; i++)
                {
                    Thread thread = new Thread(new ThreadStart(spammer));
                    thread.Start();
                }
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                spamming = false;
                Thread thread = new Thread(new ThreadStart(spammer));
                thread.Abort();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(typing));
                thread.Start();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            try
            {
                typer = false;
                Thread thread = new Thread(typing);
                thread.Abort();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(guildLeaver);
                thread.Abort();
                Thread threade = new Thread(new ThreadStart(guildJoiner));
                threade.Start();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(guildJoiner);
                thread.Abort();
                Thread threade = new Thread(new ThreadStart(guildLeaver));
                threade.Start();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threade = new Thread(reactionRemover);
                threade.Abort();
                Thread thread = new Thread(new ThreadStart(reactionAdder));
                thread.Start();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(reactionAdder);
                thread.Abort();
                Thread threade = new Thread(new ThreadStart(reactionRemover));
                threade.Start();
            }
            catch (Exception)
            {
            }
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(friendRemover);
                thread.Abort();
                Thread threade = new Thread(new ThreadStart(friendAdder));
                threade.Start();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(friendAdder);
                thread.Abort();
                Thread threade = new Thread(new ThreadStart(friendRemover));
                threade.Start();
            }
            catch (Exception)
            {
            }
        }

        private void metroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuHSlider5_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                //metroLabel1.Text = $"Delay ({bunifuHSlider5.Value} ms)";
            }
            catch (Exception)
            {
            }
        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                //metroLabel5.Text = $"Delay ({bunifuHSlider2.Value} ms)";
            }
            catch (Exception)
            {
            }
        }

        private void bunifuHSlider4_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                metroLabel2.Text = $"Delay: ({bunifuHSlider4.Value}ms)";
            }
            catch (Exception)
            {
            }
        }

        private void bunifuHSlider3_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                //metroLabel3.Text = $"Delay ({bunifuHSlider3.Value} ms)";
            }
            catch (Exception)
            {
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                //metroLabel4.Text = $"Delay ({bunifuHSlider1.Value} ms)";
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            try
            {
                //checkTokens();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            try
            {
                textTokens.Text = "";
                bunifuLabel11.Text = "0";
            }
            catch (Exception)
            {
            }
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            try
            {
                HypeSquad();
            }
            catch (Exception)
            {
            }
        }

        private void metroTabPage7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton18_Click(object sender, EventArgs e)
        {
            try
            {
                Status();
            }
            catch (Exception)
            {
            }
        }

        private void bunifuTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            try
            {
                username();
            }
            catch (Exception) 
            { 
            }
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            textProxies.Text = "";
            bunifuLabel2.Text = "0";
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(ThreadSpammer));
                thread.Start();
            }
            catch (Exception)
            {
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {

        }
    }
}
