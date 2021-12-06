using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfNote.Model
{
    public class ModelView : INotifyPropertyChanged
    {
        public RelayCommand AddCommand { get; set; }

        private ObservableCollection<Model> ROOT_;

        public ObservableCollection<Model> ROOT
        {
            get { return ROOT_; }
            set
            {
                ROOT_ = value;
                OnPropertyChanged("RCP");
            }
        }

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

        public ModelView()
        {
            ROOT = new ObservableCollection<Model>();
            AddCommand = new RelayCommand(AddExecuted, AddCanExecuted);
        }

        private bool AddCanExecuted(object param)
        {
            bool ret = false;
            ret = true;
            return ret;
        }

        private void AddExecuted(object param)
        {
            ROOT.Add(new Model() {Name = "TEST"});
        }
    }
}