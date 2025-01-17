﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

using System.Text;
using TiTsEd.Model;

namespace TiTsEd.ViewModel
{
    public sealed partial class GameVM : ObjectVM
    {

        // Public helper for the various subordinate body part view models (e.g. CockVM)
        public void NotifyPropertyChanged(string propertyName = null)
        {
            OnPropertyChanged(propertyName);
        }

        public void BeforeSerialization()
        {
            if (!IsPC)
            {
                CharacterSelection = "PC";
            }

            SetValue("playerGender", Character.GenderId);
            Character.BeforeSerialization();
        }
    }
}
