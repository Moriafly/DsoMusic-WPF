using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DsoMusicWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomePage homePage = new HomePage();


        public MainWindow()
        {
            InitializeComponent();
            
            MainFrame.Content = homePage;
        }

        private void ButtonPlayOrPause_Click(object sender, RoutedEventArgs e)
        {
            //Uri uri = new Uri("https://win-web-ra01-sycdn.kuwo.cn/f289cedf81d476919deabe9f36eddcc6/5fff8cd0/resource/n1/192/50/36/3010355335.mp3");
            //mediaElement.Source = uri;

            string url = "https://v1.hitokoto.cn/?encode=json";
            string json = HttpsUtil.Get(url);
            Hikotoko hikotoko = JsonConvert.DeserializeObject<Hikotoko>(json);
            MessageBox.Show(hikotoko.hitokoto);
        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = homePage;
        }
    }
}
