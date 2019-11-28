using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViCat.UI.Base;
using ViCat.UI.ViewModels;

namespace ViCat.UI
{
    public partial class App : Application
    {
        public static DataModel _model;
        private DataViewModel _viewModel;
        public App()
        {
            new Mapping().Create();

            _model = DataModel.Load();
            _viewModel = Mapper.Map<DataModel, DataViewModel>(_model);

            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {                                                                                                                                                                               // if(_model == null)  
                _model = Mapper.Map<DataViewModel, DataModel>(_viewModel);                                                                                                                                          
                _model.Save(); 
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
