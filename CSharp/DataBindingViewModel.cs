using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CSharp
{
    public class DataBindingViewModel : INotifyPropertyChanged
    {
        public ICommand SwipedRightCommand { get; }
        int i = 10;

        public DataBindingViewModel()
        {

            SwipedRightCommand = new Command(ButtonClick, IsEnableButton);
        }

        private bool IsEnableButton()
        {
            if (i == 9)
            {
                return true;
            }
            return false;
        }

        private void ButtonClick()
        {
                Console.WriteLine("****Called");
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
        }



        string nameEntry;

        public string NameEntry
        {
            set
            {
                OnPropertyChange("NameEntry");
                OnPropertyChange("NameText");
                nameEntry = value;

                MessagingCenter.Send<string, string>("MyApp", "NotifyMsg", "From BlePairingViewModel");
            }
            get
            {
                return nameEntry;
            }
        }


        public string NameText => NameEntry;



    }
}

