using OPTCGBot.Model.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public interface ICardGet
    {
        public List<Card>? GetAllSets();
        public List<Card>? GetAllDecks();
        public List<Card>? GetSetId(string id);
        public List<Card>? GetSetCardId(string id);
        public List<Card>? GetDeckId(string id);
        public List<Card>? GetDeckCardId(string id);
        public List<Card>? GetSetIdColor(string id, string color);
        public List<Card>? GetDeckIdColor(string id, string color);
    }
}
