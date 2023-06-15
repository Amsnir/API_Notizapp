using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace API_NotizApp_WPF
{
    public partial class Notiz : UserControl
    {
        UserControl menu;
        Menu menu2;

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private Note note = new Note();
        public Note Note
        {
            get { return note; }
            set { note = value; }
        }

        public Notiz(UserControl menu, Menu menu2)
        {
            InitializeComponent();
            Switcher.notizSwitcher = this;
            this.menu = menu;
            this.menu2 = menu2;
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Note> notes = new List<Note>();

            note.Title = titleBox.Text;
            note.Inhalt = inhaltBox.Text;

            JObject json = new JObject
            {
                    { "title", titleBox.Text },
                    { "inhalt", inhaltBox.Text },
            };


            HttpClient client = new HttpClient();

            string data = client.GetStringAsync("http://localhost:4000/Notiz").Result;
            notes = JsonConvert.DeserializeObject<List<Note>>(data);


            var requestContent = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

            if (notes.Find(x => x.Id == note.Id) != null)
            {
                client.PutAsync("http://localhost:4000/editNotiz/" + note.Id, requestContent);
            }
            else
            {
                client.PostAsync("http://localhost:4000/addNotiz", requestContent);
            }
            
            menu2.buttons[menu2.notizen.IndexOf(this)].Content = note.Title;
            Switcher.Switch(menu);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            client.DeleteAsync("http://localhost:4000/deleteNotiz/" + note.Id);

            menu2.grid.Children.Remove(menu2.buttons[menu2.notizen.IndexOf(this)]);
            menu2.buttons.Remove(menu2.buttons[menu2.notizen.IndexOf(this)]);
            menu2.notizen.Remove(this);

            menu2.updateGrid();
                
            Switcher.Switch(menu);
        }
    }
}
