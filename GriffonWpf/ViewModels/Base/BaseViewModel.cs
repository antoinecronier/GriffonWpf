﻿using GriffonWpf.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpf.ViewModels.Base
{
    public abstract class BaseViewModel<TPage> where TPage : BasePage, new()
    {
        protected TPage currentPage;

        public void Navigate<T>() where T : BasePage, new()
        {
            currentPage.GetWindow().Content = new T();
        }
    }
}
