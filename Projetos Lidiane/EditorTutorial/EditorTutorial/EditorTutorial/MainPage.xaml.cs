using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EditorTutorial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Manipuladores de eventos (métodos) que atuarão, quando um evento estiver atribuído à eles 
        
        /* 
            • Quando o texto na Editor mudar, o método OnEditorTextChanged será executado.

            • argumento sender: é o objeto Editor que é responsável por acionar o evento TextChanged
                                e pode ser usado para acessar o objeto Editor;

            • argumento TextChangedEventArgs: fornece os valores novos e antigos do texto de antes 
                                              e depois da alteração do texto.
        */
        void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }


        /*
            Quando a edição é concluída, o método OnEditorCompleted é executado.

            • Isso é feito desfocando Editor ou, além disso, pressionando o botão "Concluído" no iOS.
              Sendo necessário o uso a propriedade Completed, em Editor, no MainPage.xaml

            • argumento sender: é o objeto Editor que é responsável por acionar o evento TextChanged
                                e pode ser usado para acessar o objeto Editor;
       */
        void OnEditorCompleted(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }

    }
}
