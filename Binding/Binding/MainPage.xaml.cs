using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;

namespace Binding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MensageViewModel();
        }
    }
    public class MensageViewModel:INotifyPropertyChanged
    {
        string mensagem;
        public string Mensagem
        {
            get
            {
                return mensagem;
            }
            set
            {
                if(mensagem != value)
                {
                    mensagem = value;
                    OnPropertyChanged("Mensagem");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var Changed = PropertyChanged;
            if(Changed != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
        //public MensageViewModel()
        //{
        //    this.Mensagem = "Ola Mundo";
        //    this.LabelMsg = "Ola Rai Mundo";
        //}
    }
}
