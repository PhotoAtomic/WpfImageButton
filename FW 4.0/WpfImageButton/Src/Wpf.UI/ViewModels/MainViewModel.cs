namespace EyeOpen.Wpf.UI
{
    using System.Windows;
    using System.Windows.Input;

    public class MainViewModel
    {
        public MainViewModel()
        {
            ClickCommand = new RelayCommand(PerformClickCommand);
        }

        private void PerformClickCommand(object obj)
        {
            MessageBox.Show("Clicked");
        }

        public ICommand ClickCommand
        {
            get;
            set;
        }
    }
}