using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Safety_Instructions.Models
{
   public class BaseModel: System.ComponentModel.INotifyPropertyChanged
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
            IsActive = 1;
        }
        [PrimaryKey]
        public string Id { get; set; }
        public int IsActive { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
