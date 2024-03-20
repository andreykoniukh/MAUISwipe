using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAuiMenu
{
    public class ListViewModel:INotifyPropertyChanged
    {
 
        public ListViewModel(int i)
        {
            _items = new ObservableCollection<ListItem>(); 
            while (i>0)
            {
                _items.Add(new ListItem { Name = $"Item {i} Item {i} Item {i} Item {i} Item {i} Item {i}" ,Description= "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"" });
                i--;
            }
            OnPropertyChanged(nameof(Items));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region Items Property

        private ObservableCollection<ListItem> _items;

        public ObservableCollection<ListItem> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion
    }
}
