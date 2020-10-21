using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Safety_Instructions.Models
{
   public class Navigations:INotifyPropertyChanged
    {
        public int Imglocation { get; set; }
        public int NavigateName { get; set; }
        public int NavigateLink { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
