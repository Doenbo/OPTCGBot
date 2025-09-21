using OPTCGBot.Model.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public interface IAPIGet
    {
        public List<Card>? GetAllSets();
        public List<Card>? GetAllDecks();
        public List<Card>? GetSetId(string set_id);
        public List<Card>? GetSetCardId(string card_id);
        public List<Card>? GetDeckId(string st_id);
        public List<Card>? GetDeckCardId(string card_id);
        public List<Card>? GetSetIdColor(string set_id, string card_color);
        public List<Card>? GetDeckIdColor(string st_id, string card_color);
    }
}
