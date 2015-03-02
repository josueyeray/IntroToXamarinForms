namespace Converters.ViewModels
{
    using Base;

    public class MainViewModel : BaseViewModel
    {
        private bool boolValue;

        public MainViewModel()
        {
            BoolValue = true;
        }

        public bool BoolValue
        {
            get { return this.boolValue; }
            set
            {
                this.boolValue = value;
                RaisePropertyChanged();
            }
        }
    }
}
