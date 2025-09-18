using OPTCGBot.Model.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public class APITCGGet //: ICardGet
    {
        //private static readonly string apibase = "https://www.apitcg.com/api/one-piece/";
        private static readonly HttpClient client = new HttpClient();

        public List<Card>? GetAllDecks()
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetAllSetCards()
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetAllSets()
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetAllStCards()
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetDeckCardId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetDeckId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetDeckIdColor(string id, string color)
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetSetCardId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetSetId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Card>? GetSetIdColor(string id, string color)
        {
            throw new NotImplementedException();
        }
    }
}
