using OPTCGBot.Model.Cards;
using OPTCGBot.Model.Enums;
using OPTCGBot.Model.Rest;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Attribute = OPTCGBot.Model.Enums.Attribute;
using Color = OPTCGBot.Model.Enums.Color;

namespace OPTCGBot.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var api = new OPTCGAPIGet();
            var op01001 = api.GetSetCardId("OP01-001");
            var op01004 = api.GetSetCardId("OP01-004");

            var st23001 = api.GetDeckCardId("ST23-001");

            var st23 = api.GetDeckId("ST-23");

            Console.WriteLine("");

            //Card c = new Card(
            //    0,
            //    5000,
            //    Attribute.Strike,
            //    0,
            //    new List<string>() { "" },
            //    null,
            //    new List<Color>() { Color.Red },
            //    Category.Leader,
            //    "Monkey.D.Luffy",
            //    5,
            //    new List<Type>(),
            //    "ST01-001",
            //    Rarity.L,
            //    BlockSymbol.One,
            //    1,
            //    ""
            //);
        }
    }
}