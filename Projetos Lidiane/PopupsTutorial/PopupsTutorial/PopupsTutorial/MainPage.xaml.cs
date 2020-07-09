using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupsTutorial
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

        /*
          
           • OnDisplayAlertButtonClicked chama o método DisplayAlert para exibir um alerta modal 
            com um botão Cancelar único. 
        
           • Depois que o alerta é descartado, o usuário pode continuar interagindo com o aplicativo.
        
           • O método DisplayAlert é assíncrono e sempre deve ser esperado com a palavra-chave await.

        */
        async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "OK");
        }

        /*
           
          • O método OnDisplayAlertQuestionButtonClicked chama uma sobrecarga do método DisplayAlert
            para exibir um alerta modal com um botão aceitar e um botão cancelar. 
        
          • Após o usuário selecionar um dos botões, a seleção será retornada como um boolean.

        */
        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Save?", "Would you like to save your data?", "Yes", "No");
            Console.WriteLine("Save data: " + response);
        }

        /*
          • Este método chama o método DisplayActionSheet, para apresentar ao usuário um conjunto de
            alternativas de como proceder em uma tarefa. 
        
          • Após o usuário selecionar uma das alternativas, a seleção será retornada como um string.

          • O método DisplayActionSheet é assíncrono e sempre deve ser esperado com a palavra-chave 
            await.
        */

        async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            Console.WriteLine("Action: " + action);
        }
    }
}
