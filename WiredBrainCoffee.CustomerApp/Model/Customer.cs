﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using WiredBrainCoffee.CustomerApp.Base;

namespace WiredBrainCoffee.CustomerApp.Model
{
    [CreateFromString(MethodName = "WiredBrainCoffee.CustomerApp.Model.CustomerConverter.CreateCustomerFromString")]
    public class Customer : Observable
    {
        private string _firstName;
        private string _lastName;
        private bool _isDeveloper;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public bool IsDeveloper
        {
            get => _isDeveloper;
            set
            {
                _isDeveloper = value;
                OnPropertyChanged();
            }
        }
    }
}
