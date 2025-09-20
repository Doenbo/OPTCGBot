using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Enums
{
    public static class TypeConverter
    {
        public static List<string> Convert(string s) => (from type in Types where s.Contains(type) select type).ToList();

        //TODO can i do this better?
        public static readonly IList<String> Types = new ReadOnlyCollection<string>(new List<String>
        {
            "Straw Hat Crew",
            "Supernovas",
            "Land of Wano",
            "The Seven Warlords of the Sea",
            "Baroque Works",
            "Animal Kingdom Pirates",
            "Whitebeard Pirates",
            "FILM",
            "Impel Down",
            "Navy",
            "East Blue",
            "Water Seven",
            "CP",
            "Big Mom Pirates",
            "Alabasta",
            "Donquixote Pirates",
            "Dressrosa",
            "Revolutionary Army",
            "Sky Island",
            "New Fish-Man Pirates",
            "GERMA 66",
            "Thriller Bark Pirates",
            "Foxy Pirates",
            "Egghead",
            "Drum Kingdom",
            "Minks",
            "Punk Hazard",
            "Roger Pirates",
            "World Government",
            "Fake Straw Hat Crew",
            "Fishman Island",
            "Straw Hat Grand Fleet",
            "Sabaody Archipelago",
            "Giants",
            "Tontatta",
            "Merfolk",
            "Levely",
            "Kid Pirates",
            "Spade Pirates",
            "Amazon Lily"
        });
    }
}
