using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace MvvmLight_BaseClasses.Model
{

    public class CollectionViewModel<T> : DependencyObject //,ICollectionViewModel
    {

        protected IEnumerable<T> data;

        protected CollectionViewSource masterViewSource = new CollectionViewSource();


        public CollectionViewModel(IEnumerable<T> list)
            : this()
        {

            Data = list;

        }


        public CollectionViewModel()
        {

            AddCommand = new CommandAdd(this);

            //DeleteCommand = new CommandDelete(this);

            PreviousCommand = new CommandPrevious(this);

            //NextCommand = new CommandNext(this);

        }


        public IEnumerable<T> Data
        {
            get { return data; }

            set
            {

                data = value;

                masterViewSource.Source = data;

                MasterView = (BindingListCollectionView)masterViewSource.View;

            }

        }


        public BindingListCollectionView MasterView
        {

            get { return (BindingListCollectionView)GetValue(MasterViewProperty); }

            set { SetValue(MasterViewProperty, value); }

        }


        // Using a DependencyProperty as the backing store for MasterView.  This enables animation, styling, binding, etc...

        public static readonly DependencyProperty MasterViewProperty =

        DependencyProperty.Register("MasterView", typeof(BindingListCollectionView),

        typeof(CollectionViewModel<T>), new UIPropertyMetadata(null));


        public CollectionViewSource MasterViewSource { get { return masterViewSource; } }


        public T CurrentItem
        {

            get
            {

                return (T)GetValue(CurrentItemProperty);

            }

            set
            {

                SetValue(CurrentItemProperty, value);

            }

        }


        // Using a DependencyProperty as the backing store for CurrentItem.  This enables animation, styling, binding, etc...

        public static readonly DependencyProperty CurrentItemProperty =

        DependencyProperty.Register("CurrentItem", typeof(T), typeof(CollectionViewModel<T>),

        new UIPropertyMetadata(null, new PropertyChangedCallback(OnCurrentItemChanged)));


        private static void OnCurrentItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            /*CollectionViewModel<T> mv = (CollectionViewModel<T>)d;

                        if (mv.CurrentViewModel != null)

                            mv.CurrentViewModel.Item = (T)e.NewValue;*/

        }


        //public ItemViewModel<T> CurrentViewModel { get; set; }


        public ICommand AddCommand { get; private set; }

        public ICommand DeleteCommand { get; private set; }

        public ICommand PreviousCommand { get; private set; }

        public ICommand NextCommand { get; private set; }


        // Not all commands are shown because they are pretty simple








        /// <summary>

        /// Private implementation of the Add Command

        /// </summary>

        private class CommandAdd : MasterBaseCommand<T>
        {

            public CommandAdd(CollectionViewModel<T> viewmodel) : base(viewmodel) { }

            #region ICommand Members


            public override void Execute(object parameter)
            {

                _vm.MasterView.AddNew();

                _vm.MasterView.CommitNew();

            }


            #endregion

        }




        /// <summary>

        /// Private implementation of the Delete Command

        /// </summary>

        private class CommandPrevious : MasterBaseCommand<T>
        {


            public CommandPrevious(CollectionViewModel<T> viewmodel) : base(viewmodel) { }

            #region ICommand Members


            public override bool CanExecute(object parameter)
            {

                return _vm.MasterView.CurrentPosition > 0;

            }


            public override void Execute(object parameter)
            {

                _vm.MasterView.MoveCurrentToPrevious();

            }


            #endregion



        }


    }


    public abstract class MasterBaseCommand<T> : ICommand
    {

        protected CollectionViewModel<T> _vm;

        public MasterBaseCommand(CollectionViewModel<T> viewModel)
        {

            _vm = viewModel;

        }


        #region ICommand Members


        public virtual bool CanExecute(object parameter)
        {

            return true;

        }


        public event EventHandler CanExecuteChanged
        {

            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }

        }


        public abstract void Execute(object parameter);

        #endregion

    }
}
