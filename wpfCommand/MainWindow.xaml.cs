using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace wpfCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.New, cmNew_Executed ));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.New, cmdSave_Executed,cmdSave_Can ));
            this.CommandBindings.Add(new CommandBinding(MyCommand.InsertTime,cmdInsertTime_Executed ));
        }

        private void cmdInsertTime_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            edNote.Text += DateTime.Now.ToString("HH:mm");
        }

        private void cmdSave_Can(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = edNote.Text != "";
        }

        private void cmdSave_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //MessageBox.Show("Save");
            SaveFileDialog dialog = new();
            dialog.Filter = "Text documents (.txt)|*.txt";
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, edNote.Text);
            }
        }

        private void cmNew_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            edNote.Clear();
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void InsertHello_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            edNote.Text += "Hello";
        }
    }

    public class MyCommand
    {
        public static RoutedCommand InsertHello { get; set; } = new(nameof(InsertHello), typeof(MainWindow));
        public static RoutedCommand InsertTime { get; set; } = new(nameof(InsertTime), typeof(MainWindow));
    }
}
