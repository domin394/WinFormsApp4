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

            //szeroko�� okna aplikacji
            int windowWidth = Size.Width;
            //wysoko�� okna aplikacji
            int windowHeight = Size.Height;

            windowWidth -= button1.Width;
            windowHeight -= button1.Height;

            //inicjalizacja generatora liczb losowych
            Random rnd = new Random();

            //losowa odleg�o�� od lewej - nie wi�cej ni� szeroko�� okna
            int randomLeft = rnd.Next(windowWidth);

            //analogicznie z odleg�o�ci� od g�ry
            int randomTop = rnd.Next(windowHeight);

            //przesuwamy guzik
            //location musi by� przekazywany jako punkt na ekranie
            Point topLeftCorner = new Point(randomLeft, randomTop);
            //centerButton to nazwa (atrybut Name) mojego guzika
            button1.Location = topLeftCorner;
        }
    }
}