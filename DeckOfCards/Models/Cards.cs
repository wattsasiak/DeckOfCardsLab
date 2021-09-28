using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DeckOfCards.Models
{

    public class Root
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public List<MyCards> cards { get; set; }
    }



    public class MyCards
    {

        public string code { get; set; }
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }




    }
}
