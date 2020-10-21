﻿using System.ComponentModel;

namespace Safety_Instructions.Data.Models
{
    public class Profile : INotifyPropertyChanged
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
