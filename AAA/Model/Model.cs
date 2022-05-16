using AAA.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AAA
{
    public abstract class Model :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Changed(string Sum)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Sum));
        }
    }
}

