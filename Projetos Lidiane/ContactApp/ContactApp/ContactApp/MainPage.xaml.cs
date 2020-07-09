using ContactApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactApp
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

        void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                LastName = lastNameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Address = adressEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "contact.db3")))
            {
                conn.CreateTable<Contact>();
                int rowsAdded = conn.Insert(contact);
            }

        }

        void MostraButton_Clicked(object sender, EventArgs e)
        {
            // faz a conexão
            using (SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath
                  (Environment.SpecialFolder.LocalApplicationData), "contact.db3")))
            {
                //cria a tabela
                conn.CreateTable<Contact>();
                //método toList para carregar os dados no objeto contacts
                var contacts = conn.Table<Contact>().ToList();
                //carrega os dados no listview
                contactListView.ItemsSource = contacts;

            }

        }
    }
}
