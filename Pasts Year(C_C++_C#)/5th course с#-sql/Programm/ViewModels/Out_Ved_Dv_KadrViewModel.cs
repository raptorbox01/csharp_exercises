﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Programm.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Programm.Helpers;

namespace Programm.ViewModels
{
    public class Out_Ved_Dv_KadrViewModel : DocumentViewModel
    {
        #region Private fields
        private List<Out_Ved_Dv_Kadr> _data;
        private RelayCommand _selectCommand;
        private Out_Ved_Dv_Kadr _itog;
        private OperationType _opType = OperationType.None;
        #endregion
        
        #region Constructors
        public Out_Ved_Dv_KadrViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<Out_Ved_Dv_Kadr> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<Out_Ved_Dv_Kadr>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }

        public Out_Ved_Dv_Kadr Itog
        {
            get
            {
                if (_itog == null)
                    _itog = new Out_Ved_Dv_Kadr();
                return _itog;
            }
            private set
            {
                _itog = value;
                OnPropertyChanged("Itog");
            }
        }
        #endregion

        #region SelectCommand
        public ICommand SelectCommand
        {
            get
            {
                if (_selectCommand == null)
                {
                    _selectCommand = new RelayCommand(param => this.Select());
                }

                return _selectCommand;
            }
        }

        public void Select()
        {
            _mainModelView.SelectDocument(this);
            this.Refresh();
        }
        #endregion
        
        #region Operations methods
        #region Refresh
        public override void Refresh()
        {
            this.Data.Clear();

            Data = new List<Out_Ved_Dv_Kadr>(DataBase.DataBase.GetOut_Ved_Dv_Kadr());
            Itog = DataBase.DataBase.GetOut_Ved_Dv_KadrItog();
        }

        public override bool CanRefresh()
        {
            return true && _opType == OperationType.None;
        }
        #endregion

        #region Delete
        public override void Delete()
        {            
        }

        public override bool CanDelete()
        {
            return false;
        }
        #endregion

        #region Add
        public override void Add()
        {
        }

        public override bool CanAdd()
        {
            return false;
        }
        #endregion

        #region Edit
        public override void Edit()
        {
        }

        public override bool CanEdit()
        {
            return false;
        }
        #endregion
        #endregion
    }
}