using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Lektion3.ObservableCollection
{
    public class Person : BindableBase
    {
        private string _name;
        private string _emejl;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Emejl
        {
            get { return _emejl; }
            set
            {
                _emejl = value;
                NotifyPropertyChanged("Emejl");
            }
        }
    }
}
