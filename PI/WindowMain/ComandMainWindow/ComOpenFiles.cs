﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PI
{
   public class ComOpenFiles: ICommand
    {
        public ViewModelMainWindow Cvm;
        public ComOpenFiles(ViewModelMainWindow vm)
        {
            Cvm = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            Cvm.UserControl = new UserControlFiles(Cvm);
        }
    }
}

