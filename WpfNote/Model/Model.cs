using System;
using System.ComponentModel;

namespace WpfNote.Model
{
    public class Model : INotifyPropertyChanged
    {
        private string _name;

        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                try
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
                catch
                {
                }
            }
        }

        public Model()
        {
        }
    }
}