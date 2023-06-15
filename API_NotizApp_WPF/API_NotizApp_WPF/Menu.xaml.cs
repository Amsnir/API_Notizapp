using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace API_NotizApp_WPF
{
    public partial class Menu : UserControl
    {
        public int row = 0;
        public int column = 0;

        public int i = -1;

        public List<Notiz> notizen = new List<Notiz>();
        public List<Note> notes = new List<Note>();
        public List <Button> buttons= new List<Button>();

        public Menu()
        {
            InitializeComponent();
            Switcher.menuSwitcher = this;



            HttpClient client = new HttpClient();
            string data = client.GetStringAsync("http://localhost:4000/Notiz").Result;
            notes = JsonConvert.DeserializeObject<List<Note>>(data);


            if(notes != null)
            {
                foreach(Note n in notes)
                {
                    Button button = new Button();
                    button.Click += new RoutedEventHandler(button_Click);
                    button.Name = "button" + (i + 1).ToString();
                    button.Content = n.Title;
                    button.Style = (Style)Resources["ButtonStyle"];
                    buttons.Add(button);


                    Notiz notiz = new Notiz(this, this);
                    notiz.Id = n.Id;
                    notiz.Note = n;
                    notiz.titleBox.Text = n.Title;
                    notiz.inhaltBox.Text = n.Inhalt;
                    notizen.Add(notiz);


                    i++;
                }
            }
            updateGrid();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Button button = new Button();
                button.Click += new RoutedEventHandler(button_Click);
                button.Name = "button" + (i + 1).ToString();
                button.Style = (Style)Resources["ButtonStyle"];
                buttons.Add(button);


                Notiz notiz = new Notiz(this, this);
                notizen.Add(notiz);


                updateGrid();
                
                i++;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
                string content = (sender as Button).Name.ToString();
                string index = content.Substring(6);
                Switcher.Switch(notizen[int.Parse(index)]);   
        }

        public void updateGrid()
        {
            grid.Children.Clear();
            row = 0;
            column = 0;
            i = -1;

            foreach(Button b in buttons)
            {
                b.Name = "button" + (i + 1).ToString();
                grid.Children.Add(b);
                

                Grid.SetRow(b, row);
                Grid.SetColumn(b, column);

                if (column < grid.ColumnDefinitions.Count - 1)
                {
                    column++;
                }
                else
                {
                    column = 0;
                    row++;

                    RowDefinition rowdefinition = new RowDefinition();
                    grid.RowDefinitions.Add(rowdefinition);
                }
                i++;
            }
        }
    }
}
