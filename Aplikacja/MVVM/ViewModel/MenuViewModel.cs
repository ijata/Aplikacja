using Aplikacja.Core;
using Aplikacja.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.ViewModel
{
    class MenuViewModel : ObservableObject
    {
        private MenuQuery _menu;

        public MenuViewModel()
        {
            _menu = new MenuQuery();
            _menu = _menu.GetMenu7();
            menuSeven = _menu.menuSeven;

        }

        public MenuQuery Menu
        {
            get { return _menu; }
            set
            {
                _menu = value;
            }
        }

        #region menuSeven
        public string menuSeven
        {
            get { return _menu.menuSeven; }
            set
            {
                _menu.menuSeven = value;
                OnPropertyChanged(nameof(_menu.menuSeven));
            }
        }
        #endregion
    }
}
