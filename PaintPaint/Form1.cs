namespace PaintPaint
{
    public partial class Form1 : Form
    {
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;
        bool dibCirculo = false;
        bool dibCuadrado = false;
        bool dibTriangulo = false;
        List<Point> pTriangulo = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            picBoxPapel.Image = new Bitmap(picBoxPapel.Height, picBoxPapel.Width);
            papel = picBoxPapel.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Suavizar el movimiento del mouse
            tamanioPincel = trackTamañoPincel.Value; //Asignar el tamaño del pincel de acuerdo al TrackBar
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //Forma del pincel (redondeado)
        }

        private void picBoxPapel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblB_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lblB_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void picBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            x = e.X;
            y = e.Y;
            picBoxPapel.Cursor = Cursors.Cross; //Cambiar la forma del cursor, para saber que esta oprimiendo
        }

        private void picBoxPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;

            if (dibCirculo)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                int ancho = Math.Abs(e.X - x);
                int alto = Math.Abs(e.Y - y);
                papel.DrawEllipse(pen, x, y, ancho, alto);
                moviendo = false;
                // dibCirculo = false;
            }

            if (dibCuadrado)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                int ancho = Math.Abs(e.X - x);
                int alto = Math.Abs(e.Y - y);
                papel.DrawRectangle(pen, x, y, ancho, alto);
                moviendo = false;
                // dibCirculo = false;
            }

            if (dibTriangulo)
            {
                pTriangulo.Add(new Point(e.X, e.Y));
                if (pTriangulo.Count == 3)
                {
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                    papel.DrawPolygon(pen, pTriangulo.ToArray());
                    pTriangulo.Clear();
                    moviendo = false;

                }
            }
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            borrar = true;
            pintar = false;
        }

        private void picBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

            if (moviendo && borrar)
            {
                cambiarPincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

        }
        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackTamañoPincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void picBoxNegro_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void picBoxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void trackTamañoPincel_Scroll(object sender, EventArgs e)
        {
            lblTamaPincel.Text = trackTamañoPincel.Value.ToString();
        }

        private void Circulo_Click(object sender, EventArgs e)
        {
            dibCirculo = true;
            pintar = false;
            borrar = false;
            dibCuadrado = false;
            dibTriangulo = false;
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            dibCuadrado = true;
            dibCirculo = false;
            dibTriangulo = false;
            pintar = false;
            borrar = false;
        }

        private void Triangulo_Click(object sender, EventArgs e)
        {
            dibTriangulo = true;
            dibCirculo = false;
            dibCuadrado = false;
            pintar = false;
            borrar = false;
        }

        private void btnCargarFondo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar fondo";
                ofd.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpeg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picBoxPapel.Image = new Bitmap(ofd.FileName);
                    picBoxPapel.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

    }
}