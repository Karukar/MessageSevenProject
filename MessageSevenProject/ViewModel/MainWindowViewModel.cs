﻿using MessageSevenProject.Helper.ModelBase;
using MessageSevenProject.Model;
using MessageSevenProject.Service_Clients.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MessageSevenProject.Model.Comman;

namespace MessageSevenProject.ViewModel
{
    public class MainWindowViewModel:ViewModelBase
    {
        private IMessageSevenService Service;
        private ObservableCollection<Message> _MasterData;

        public IEnumerable<Attributes> _Attributes
        {
            get
            {
                return Enum.GetValues(typeof(Attributes)).Cast<Attributes>();
            }
        }

        public IEnumerable<Operators> _Operators
        {
            get
            {
                return Enum.GetValues(typeof(Operators)).Cast<Operators>();
            }
        }

        public MainWindowViewModel(IMessageSevenService _Service)
        {
            this.Service = _Service;
            StartUp();
        }

        public void StartUp()
        {
            LoadData();
        }

        public void LoadData()
        {
            var d = Service.GeAllData();
            MasterData = new ObservableCollection<Message>(d);
        }

        public ObservableCollection<Message> MasterData
        {
            get
            {
                return _MasterData;
            }

            set
            {
                SetProperty(ref _MasterData, value);
            }
        }
    }
}