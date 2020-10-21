using System;
using System.ComponentModel;

namespace Safety_Instructions.Data.Models
{
    public class Instruction : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public String Title { get; set; }
        public String AnimationJson { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
