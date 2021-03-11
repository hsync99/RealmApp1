using RealmApp3.Models;
using RealmApp3.ViewModels;
using RealmApp3.Views;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RealmApp3.ViewModels
{
    public class ItemViewModels: INotifyPropertyChanged
    {
        Realm _getRealmInstance = Realm.GetInstance();
        
       public List<ItemObject> _listOfItems;


        public List<ItemObject> ListOfItems
        {
            get { return _listOfItems; }
            set
            {
                _listOfItems = value;
                OnPropertyChanged();
            }
        }
        private Manufactorer _manufactorer = new Manufactorer();
        private ItemObject _itemObject = new ItemObject();
        private ItemType _itemType = new ItemType();
        private Param _param = new Param();
        private ParamValue _paramValue = new ParamValue();
        public ParamValue ParamValue
        {
            get { return _paramValue; }
            set
            {
                _paramValue= value;
                OnPropertyChanged();
            }
        }
        public Param Param
        {
            get { return _param; }
            set
            {
                _param = value;
                OnPropertyChanged();
            }
        }
        public ItemType ItemType
        {
            get { return _itemType; }
            set
            {
                _itemType = value;
                OnPropertyChanged();
            }
        }
        public Manufactorer Manufactorer
        {
            get { return _manufactorer; }
            set
            {
                _manufactorer = value;
                OnPropertyChanged();
            }
        }
        public ItemObject ItemObject
        {
            get { return _itemObject; }
            set
            {
                _itemObject = value;
                OnPropertyChanged();
            }
        }
       
        public Command CreateCommand
        {
            get
            {
                return new Command(() =>
                {

                    _getRealmInstance.Write(() =>
                    {
                        _getRealmInstance.Add(_itemObject);
                        _getRealmInstance.Add(_manufactorer);
                        _getRealmInstance.Add(_itemType);
                        _getRealmInstance.Add(_param);
                        _getRealmInstance.Add(_paramValue);
                    });
                });
            }
        }
        public ItemViewModels()
        {
            this.ListOfItems = _getRealmInstance.All<ItemObject>().ToList();
        }
        public Command NavToListCommand
        {
            get
            {
                return new Command(async () =>
                {
                    
                    await App.Current.MainPage.Navigation.PushModalAsync(new ListPage1());
                   
                });
            }
        }
        public Command NavToMainPage
        {
            get
            {
                return new Command(async () =>
                {

                    await App.Current.MainPage.Navigation.PushModalAsync(new MainPage());

                });
            }
        }
        //============================================================================================
        //============================================================================================
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
