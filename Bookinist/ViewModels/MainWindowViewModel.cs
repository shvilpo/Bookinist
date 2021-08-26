using MathCore.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        #region Title : string - Заголовок 
        private string _Title = "Main window";
        public string Title { get => Title; set => Set(ref _Title, value); }
        #endregion
    }
}
