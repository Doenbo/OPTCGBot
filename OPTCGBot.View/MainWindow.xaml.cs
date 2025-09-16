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
using Type = OPTCGBot.Model.Enums.Type;

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

            ICardGet cg = new OPTCGAPIGet();
            var resp = cg.GetSetCardId("OP01-004");

            Card c = new Card(
                0,
                5000,
                Attribute.Strike,
                0,
                new List<string>() { "" },
                null,
                new List<Color>() { Color.Red },
                Category.Leader,
                "Monkey.D.Luffy",
                5,
                new List<Type>(),
                "ST01-001",
                Rarity.L,
                BlockSymbol.One,
                1,
                ""
            );
        }
    }
}