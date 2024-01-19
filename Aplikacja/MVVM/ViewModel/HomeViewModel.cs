using Aplikacja.Core;
using Aplikacja.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.ViewModel
{
    public class HomeViewModel : ObservableObject
    {
        private MenuQuery _menu;
        private PresenceQuery _presence;

        public HomeViewModel()
        {
            _menu = new MenuQuery();
            _menu = _menu.GetMenu1();
            menuOne = _menu.menuOne;

            _presence = new PresenceQuery();
            _presence = _presence.GetPresence1();
            presenceOne = _presence.presenceOne;

        }

        public MenuQuery Menu
        {
            get { return _menu; }
            set
            {
                _menu = value;
            }
        }

        #region menuOne
        public string menuOne
        {
            get { return _menu.menuOne; }
            set
            {
                _menu.menuOne = value;
                OnPropertyChanged(nameof(_menu.menuOne));
            }
        }
        #endregion

        public PresenceQuery PresenceToday
        {
            get { return _presence; }
            set
            {
                _presence = value;
            }
        }

        #region presenceOne
        public string presenceOne
        {
            get { return _presence.presenceOne; }
            set
            {
               _presence.presenceOne = value;
                OnPropertyChanged(nameof(_presence.presenceOne));
            }
        }
        #endregion
    }
}
