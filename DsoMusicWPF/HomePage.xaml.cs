using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using DsoMusicWPF.data;

namespace DsoMusicWPF
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        private MainWindow _parentWin;
        public MainWindow ParentWindow
        {
            get { return _parentWin; }
            set { _parentWin = value; }
        }

        public HomePage()
        {
            InitializeComponent();


        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KuwoSearchData.AbslistData songData = ListView.SelectedItem as KuwoSearchData.AbslistData;
            string rid = songData.MUSICRID.Replace("MUSIC_", "");
            string getUrl = "http://www.kuwo.cn/url?format=mp3&rid=" + rid + "&response=url&type=convert_url3&br=990kmp3&from=web&t=" + GetTimeStamp() + "&httpsStatus=1";
            // MessageBox.Show(getUrl);
            string resopnse = HttpsUtil.Get(getUrl);
            KuwoMusicData kuwoMusicData = JsonConvert.DeserializeObject<KuwoMusicData>(resopnse);
            _parentWin.PlaySong(kuwoMusicData.url);
        }

        // 搜索歌曲
        public void Search(string kewwords)
        {
            string url = "http://search.kuwo.cn/r.s?songname=" + kewwords + "&ft=music&rformat=json&encoding=utf8&rn=8&callback=song&vipver=MUSIC_8.0.3.1";
            // 适配 JSON
            string response = HttpsUtil.Get(url);
            response = response.Replace("try{var jsondata=", "");
            response = response.Replace(
                "\n" +
                        "; song(jsondata);}catch(e){jsonError(e)}", ""
            );
            response = response.Replace("\'", "\"");
            response = response.Replace("&nbsp;", " ");
            KuwoSearchData kuwoSearchData = JsonConvert.DeserializeObject<KuwoSearchData>(response);

            ListView.ItemsSource = kuwoSearchData.abslist;
        }

        public string GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}
