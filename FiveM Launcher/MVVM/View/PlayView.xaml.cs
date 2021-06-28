using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;


namespace FiveM_Launcher.MVVM.View
{
    /// <summary>
    /// Interaction logic for PlayView.xaml
    /// </summary>
    public partial class PlayView : UserControl
    {
        public PlayView()
        {
            InitializeComponent();
        }

        private void P_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            try // Tries code below first
            {

                Process.Start("fivem:");
                Thread.Sleep(8500);
                Process.Start("fivem://connect/cfx.re/join/a9ekd9");

                
            }
            catch  // Catch if above code doesnt work
            {
                MessageBox.Show("Error: Please make sure you have fiveM Installed"); // Error Message
            }
        }

        private void TS_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("ts3server://voice.teamspeak.com"); // voice.teamspeak.com ? password = serverPassword
            }
            catch
            {
                MessageBox.Show("Error: Please make Shure you have Teamspeak installed!");
            }
        }

        private void Discord_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://discord.gg/5NDARUCubq");
        }

        private void Twitter_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            //Process.Start("https://twitter.com/MLordTiger");
            MessageBox.Show("Coming Soon!");
        }

        private void YT_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCfK9A-RVIBA93UNOj5HlwjA");
        }

        private void facebook_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            //Process.Start("https://www.facebook.com");
            MessageBox.Show("Coming Soon!");
        }
    }
}
