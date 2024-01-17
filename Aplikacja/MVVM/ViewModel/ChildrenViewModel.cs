using Aplikacja.Core;
using Aplikacja.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.ViewModel
{
    public class ChildrenViewModel : ObservableObject
    {
        private ChildQuery _child;

        public ChildrenViewModel()
        {
            _child = new ChildQuery(); 
            _child = _child.Get();
            ChildernFirstName = _child._test;
        }

        public ChildQuery Child
        {
            get { return _child; }
            set
            {
                _child = value;
                OnPropertyChanged(nameof(_child._test));
            }
        }

        #region ChildernFirstName
        private string _childernFirstName;
        public string ChildernFirstName
        {
            get { return _child._test; }
            set
            {
                _child._test = value;
                OnPropertyChanged(nameof(_child._test));
            }
        }
        #endregion
    }

}
