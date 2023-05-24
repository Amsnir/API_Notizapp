using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_NotizApp_WPF
{
    public class Note
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string datum;
        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private string inhalt;
        public string Inhalt
        {
            get { return inhalt; }
            set { inhalt = value; }
        }

        public Note() { }

        public Note(string id, string title, string datum, string inhalt)
        {
            this.id = id;
            this.title = title;
            this.datum = datum;
            this.inhalt = inhalt;
        }
    }
}
