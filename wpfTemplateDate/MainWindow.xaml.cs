using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace wpfTemplateDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<MyTask> listTask;
        MyTask newTask = new();
        public MainWindow()
        {
            InitializeComponent();

            List<string> listPhones = new() { "iPhone 6s", "Galaxy 10", "poco"};
            listBoxPhones.ItemsSource = listPhones;

           listTask = new()
           {
               new MyTask() {TaskName="wash hands", Description="with soap", Priority=1},
               new MyTask() {TaskName="buy food", Description="healthy", Priority=2},
               new MyTask() {TaskName="chose table", Priority=3},
               new MyTask() {TaskName="eating",Priority=3}
           };
            listBoxTask.ItemsSource = listTask;

            stackPanel_Add.DataContext = new MyTask();

            buAdd.Click += BuAdd_Click; ;
        }

        private void BuAdd_Click(object sender, RoutedEventArgs e)
        {
            //listTask.Add(new MyTask() { TaskName = "1111" });
            listTask.Add(newTask);
        }
    }

    class MyTask: IDataErrorInfo
    {
       

        public string? TaskName{get; set;} 
        public string? Description{get; set;} 
        public int? Priority{get; set;}

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case "TaskName":
                        break;
                    case "Priority":
                        if ((this.Priority < 0) || (this.Priority > 10))
                            error = "priority >0 & <10";
                        break;

                }
                return error;
            }
        }

        public string Error => throw new NotImplementedException();
    }
}
