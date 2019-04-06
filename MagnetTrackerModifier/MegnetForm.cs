using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnetTrackerModifier
{
    public partial class MegnetForm : Form
    {
        const string TRACKER_URL = "https://raw.githubusercontent.com/ngosang/trackerslist/master/trackers_best.txt";
        List<string> trackerList = new List<string>();
        bool trackersReady = false;
        public MegnetForm()
        {
            InitializeComponent();
#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            TryDownloadTrackersAsync();
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            InitFromClipboard();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!trackersReady)
            {
                MessageBox.Show("Trackers not ready.");
                return;
            }
            string strMagnet = textInput.Text;
            if (ValidateMagnetString(strMagnet))
            {
                string strResult = "";
                string[] arrays = strMagnet.Split('&');
                foreach (var item in arrays)
                {
                    if (!item.StartsWith("tr="))
                    {
                        if (strResult.Length > 0)
                        {
                            strResult += "&";
                        }
                        strResult += item;
                    }
                }
                foreach (var item in trackerList)
                {
                    strResult += string.Format("&tr={0}", item); 
                }
                textOutput.Text = strResult;
                Clipboard.SetText(strResult);
            }
            else
            {
                textOutput.Text = "Invalid format.";
            }
        }

        private async Task TryDownloadTrackersAsync()
        {
            labelState.ForeColor = Color.Yellow;
            labelState.Text = "Requesting...";
            HttpClient client = new HttpClient();
            try
            {
                string body = await client.GetStringAsync(TRACKER_URL);
                trackersReady = true;
                labelState.ForeColor = Color.Green;
                labelState.Text = "Ready";
                string[] trackers = body.Split('\n');
                foreach (var tracker in trackers)
                {
                    string trackerUrl = Uri.EscapeDataString(tracker.Trim());
                    if (trackerUrl.Length > 0)
                    {
                        trackerList.Add(trackerUrl);
                    }
                }
            }
            catch (Exception)
            {
                trackersReady = false;
                labelState.ForeColor = Color.Red;
                labelState.Text = "Failed.";
            }
            
        }

        bool ValidateMagnetString(string str)
        {
            if (str == null)
            {
                return false;
            }
            Regex r = new Regex(@"^magnet:\?xt=urn:btih:", RegexOptions.IgnoreCase);
            Match matchResult = r.Match(str);
            return matchResult.Success;
        }

        void InitFromClipboard()
        {
            IDataObject data = Clipboard.GetDataObject();
            string str = (string)data.GetData(typeof(string));
            if (ValidateMagnetString(str))
            {
                textInput.Text = str;
            }
        }

    }
}
