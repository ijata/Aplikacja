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
            ChildernFirstName = _child.childData;

        }

        public ChildQuery Child
        {
            get { return _child; }
            set
            {
                _child = value;
            }
        }

        #region ChildernFirstName
       public string ChildernFirstName
        {
            get { return _child.childData; }
            set
            {
                _child.childData = value;
                OnPropertyChanged(nameof(_child.childData));
            }
        }
        #endregion

     
    }
}
