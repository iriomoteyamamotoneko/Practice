using Prism.Mvvm;
using System.Windows;
using System;
using Prism.Commands;

namespace Practice.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            
        }

        private void Button_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("何で押したん？");
        }
    }
}
