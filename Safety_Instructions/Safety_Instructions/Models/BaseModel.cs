using SQLite;
using System;
using System.ComponentModel;

namespace Safety_Instructions.Models
{
    public class BaseModel : System.ComponentModel.INotifyPropertyChanged
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
