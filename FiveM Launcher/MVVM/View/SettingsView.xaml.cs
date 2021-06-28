using Microsoft.Win32;
using System.Linq;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace FiveM_Launcher.MVVM.View
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {

        public SettingsView()
        {
            InitializeComponent();
        }

        private void txt_b_TextChanged(object sender, TextChangedEventArgs e)
        {
            try // Tries code below first
            {
                StreamReader sr = new StreamReader("fConfig.txt"); // Start of Reading the files content
                string fline = sr.ReadLine(); // Finally Reading it i guess
                txt_b.Text = fline;  // Sets the text box as the content in txt file 
                txt_b.IsReadOnly = true; // Makes Text box read only
                txt_b.IsEnabled = false; // Disables input to Text box
                sr.Close(); // end

            }catch  // Catch if above code doesnt work
            {
                txt_b.Text = "Directory Needed"; // Change Textbox Text
                txt_b.IsReadOnly = true; // Makes Text box read only
                txt_b.IsEnabled = false; // Disables input to Text box
            }
        }


        private void B_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            txt_b.Text = ""; 
            txt_b.IsReadOnly = true; 
            txt_b.IsEnabled = false; 
            OpenFileDialog OFD = new OpenFileDialog(); 
            OFD.FilterIndex = 1; 

            if (OFD.ShowDialog() == true)
            {
                string FilePath = OFD.FileName;
                txt_b.Text = FilePath;

                string cFileN = "fConfig.txt";

                if(!File.Exists(cFileN))
                {
                    TextWriter tw = new StreamWriter(cFileN);
                    tw.WriteLine(FilePath);
                    tw.Close();
                } else if(File.Exists(cFileN))
                {
                    TextWriter tw = new StreamWriter(cFileN);
                    tw.WriteLine(FilePath);
                    tw.Close();
                }
            }
        }

        private void CC_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("fConfig.txt");

            string fline = sr.ReadLine();

            string nLine = Path.GetFullPath(Path.Combine(fline + @"\..\FiveM.app\data\cache"));
            sr.Close();
            DirectoryInfo di = new DirectoryInfo(nLine);

            di.EnumerateFiles()
                .ToList().ForEach(f => f.Delete());

            di.EnumerateDirectories()
                .ToList().ForEach(d => d.Delete(true));
        }

    }
}
