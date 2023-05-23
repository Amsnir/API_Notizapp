namespace API_Notizapp_WebServer.Data
{
    public class Notiz
    {
        public string id { get; set; }
        public string title { get; set; }
        public string datum { get; set; }
        public string inhalt { get; set; }

        public Notiz() { }

        public Notiz(string id, string title, string datum, string inhalt)
        {
            this.id = id;
            this.title = title;
            this.datum = datum;
            this.inhalt = inhalt;
        }
    }
}
