using MudBlazor;

namespace G1S1.BlazorServer
{
    public class BooksTheme
    {
        private static Palette DefaultPalette = new Palette()
        {
            Primary = Colors.Blue.Default,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.Red.Default,
            DrawerBackground = "#FFF"
            //Primary = "#1E88E5",
            //Secondary = Colors.Green.Accent4,
            //AppbarBackground = "#1E88E5",
            //Background = Colors.Grey.Lighten5,
            //DrawerBackground = "#FFF",
            //DrawerText = "rgba(0,0,0, 0.7)",
            //Success = "#007E33"
        };

        private static Typography DefaultTypography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "GothamBook" },
                //FontSize = ".875rem",
                //FontWeight = 400,
                //LineHeight = 1.43,
                //LetterSpacing = ".01071em"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = "6rem",
                FontWeight = 300,
                LineHeight = 1.167,
                LetterSpacing = "-.01562em"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = "3.75rem",
                FontWeight = 300,
                LineHeight = 1.2,
                LetterSpacing = "-.00833em"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = "3rem",
                FontWeight = 400,
                LineHeight = 1.167,
                LetterSpacing = "0"
            },
            H4 = new H4()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = "2.125rem",
                FontWeight = 400,
                LineHeight = 1.235,
                LetterSpacing = ".00735em"
            },
            H5 = new H5()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = "1.5rem",
                FontWeight = 400,
                LineHeight = 1.334,
                LetterSpacing = "0"
            },
            H6 = new H6()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = "1.25rem",
                FontWeight = 400,
                LineHeight = 1.6,
                LetterSpacing = ".0075em"
            },
            Button = new Button()
            {
                FontFamily = new[] { "GothamBold" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.75,
                LetterSpacing = ".02857em"
            },
            Body1 = new Body1()
            {
                FontFamily = new[] { "GothamBook" },
                FontSize = "1rem",
                FontWeight = 400,
                LineHeight = 1.5,
                LetterSpacing = ".00938em"
            },
            Body2 = new Body2()
            {
                FontFamily = new[] { "GothamBook" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            Caption = new Caption()
            {
                FontFamily = new[] { "GothamBook" },
                FontSize = ".75rem",
                FontWeight = 400,
                LineHeight = 1.66,
                LetterSpacing = ".03333em"
            },
            Subtitle2 = new Subtitle2()
            {
                FontFamily = new[] { "GothamBook" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.57,
                LetterSpacing = ".00714em"
            }
        };

        private static LayoutProperties DefaultLayoutProperties = new LayoutProperties()
        {
            //DefaultBorderRadius = "3px"
        };

        public static MudTheme DefaultTheme = new MudTheme()
        {
            Palette = DefaultPalette,
            Typography = DefaultTypography,
            LayoutProperties = DefaultLayoutProperties
        };
    }
}
