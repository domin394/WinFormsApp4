namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            //szerokoœæ okna aplikacji
            int windowWidth = Size.Width;
            //wysokoœæ okna aplikacji
            int windowHeight = Size.Height;

            windowWidth -= button1.Width;
            windowHeight -= button1.Height;

            //inicjalizacja generatora liczb losowych
            Random rnd = new Random();

            //losowa odleg³oœæ od lewej - nie wiêcej ni¿ szerokoœæ okna
            int randomLeft = rnd.Next(windowWidth);

            //analogicznie z odleg³oœci¹ od góry
            int randomTop = rnd.Next(windowHeight);

            //przesuwamy guzik
            //location musi byæ przekazywany jako punkt na ekranie
            Point topLeftCorner = new Point(randomLeft, randomTop);
            //centerButton to nazwa (atrybut Name) mojego guzika
            button1.Location = topLeftCorner;
        }
    }
}