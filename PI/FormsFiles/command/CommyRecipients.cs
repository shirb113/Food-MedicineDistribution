﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
    public class CommyRecipients: ICommand
    {
        private ViewModelFiles Cvm;

        public ViewModelMainWindow MCvm;
        public CommyRecipients(ViewModelFiles vm, ViewModelMainWindow mvm)
        {
            Cvm = vm;
            MCvm = mvm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MCvm.UserControl = new UserControlMyRecipients();
        }
    }
}
