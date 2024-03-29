﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class ViewModel
    {
        #region Fields

        private ObservableCollection<ListViewContactInfo> contactsInfo;

        #endregion

        #region Constructor

        public ViewModel()
        {
            GenerateSource(100);
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewContactInfo> ContactsInfo
        {
            get { return contactsInfo; }
            set { this.contactsInfo = value; }
        }

        #endregion

        #region ItemSource

        public void GenerateSource(int count)
        {
            ListViewContactsInfoRepository contactRepository = new();
            contactsInfo = contactRepository.GetContactDetails(count);
        }

        #endregion
    }
}
