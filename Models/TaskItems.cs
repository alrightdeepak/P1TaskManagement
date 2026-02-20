using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TaskManagement.Models
{
    public class TaskItems : INotifyPropertyChanged
    {
        public int userId {  get; set; }
        private bool _Status;
        private int _TaskId;
        private string _Description;

        public int TaskID
        {
            get => _TaskId;
            set
            {
                if (_TaskId != value)
                {
                    _TaskId = value;
                    OnPropertyChanged(nameof(TaskID));
                }
            }
        }
        public bool Status
        {
            get => _Status;
            set
            {
                if (_Status != value)
                {
                    _Status = value;
                    OnPropertyChanged(nameof(Status));
                }
            }
        }
        public string Description
        {
            get => _Description;
            set
            {
                if (_Description != value)
                {
                    _Description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}