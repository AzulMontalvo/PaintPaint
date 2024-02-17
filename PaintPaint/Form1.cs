using System.Drawing.Imaging;

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
        List<Point> pTriangulo = new List<Point>(); //Lista de puntos para el triángulo
        public Form1()
        {
            InitializeComponent();
            //picBoxPapel.Image = new Bitmap(picBoxPapel.Height, picBoxPapel.Width);
            //papel = picBoxPapel.CreateGraphics();
            Bitmap bmp = new Bitmap(picBoxPapel.Width, picBoxPapel.Height);//Crear bmp con las medidas del picBoxPapel
            picBoxPapel.Image = bmp; //Asignar al bmp lo que haya en el picBoxPapel
            papel = Graphics.FromImage(picBoxPapel.Image); //Crear un gráfico a partir de lo que hay en picBoxPapel
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
                int ancho = Math.Abs(e.X - x); //Asignar la posición del mouse como el ancho (o inicio) de la elipse
                int alto = Math.Abs(e.Y - y); //Asignar la posición del mouse como el alto (o final) de la elipse
                papel.DrawEllipse(pen, x, y, ancho, alto);
                moviendo = false;

                picBoxPapel.Invalidate(); //Actualizar el papel para que se muestren los cambios
                // dibCirculo = false;
            }

            if (dibCuadrado)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                int ancho = Math.Abs(e.X - x);
                int alto = Math.Abs(e.Y - y);
                papel.DrawRectangle(pen, x, y, ancho, alto);
                moviendo = false;
                picBoxPapel.Invalidate();
                // dibCirculo = false;
            }

            if (dibTriangulo)
            {
                pTriangulo.Add(new Point(e.X, e.Y)); //Comenzar a agregar los puntos a la lista
                if (pTriangulo.Count == 3) //Validar que ya existan 3 puntos
                {
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                    papel.DrawPolygon(pen, pTriangulo.ToArray()); //Dibujar polígono en base a los puntos guardados
                    pTriangulo.Clear(); //Borrar los puntos de la lista
                    moviendo = false;
                    picBoxPapel.Invalidate();

                }
            }
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
            dibCirculo = false;
            dibCuadrado = false;
            dibTriangulo = false;
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            borrar = true;
            pintar = false;
            dibCirculo = false;
            dibCuadrado = false;
            dibTriangulo = false;
        }

        private void picBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

                picBoxPapel.Invalidate();
            }

            if (moviendo && borrar)
            {
                cambiarPincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

                picBoxPapel.Invalidate();
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
            lblTamaPincel.Text = trackTamañoPincel.Value.ToString(); //Asignar el valor del trackBar al label
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
            using (OpenFileDialog ofd = new OpenFileDialog()) //Cuadro de diálogo para abrir el archivo
            {
                ofd.Title = "Seleccionar fondo"; //Nombre del cuadro de diálogo
                ofd.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpeg;*.jpeg;*.png;*.bmp"; //Archivos permitidos

                if (ofd.ShowDialog() == DialogResult.OK) //Validar que se haya cerrado el cuadro de diálogo
                {
                    //picBoxPapel.Image = new Bitmap(ofd.FileName);
                    //picBoxPapel.SizeMode = PictureBoxSizeMode.StretchImage;
                    Image imagencargada = Image.FromFile(ofd.FileName); //Variable que almacena la imagen

                    if (picBoxPapel.Image != null) //Permite pintar sobre el nuevo objeto, libera la imagen anterior
                    {
                        picBoxPapel.Image.Dispose();
                        //picBoxPapel.Image = null;
                    }

                    Bitmap bmp = new Bitmap(imagencargada.Width, imagencargada.Height);// Asigna la imagen como un nuevo bmp

                    using (Graphics g = Graphics.FromImage(bmp)) //Asignar el gráfico al bmp
                    {
                        g.DrawImage(imagencargada, 0, 0, bmp.Width, bmp.Height);
                    }

                    picBoxPapel.Image = bmp;

                    if (papel != null)
                    {
                        papel.Dispose();
                    }
                    papel = Graphics.FromImage(picBoxPapel.Image);
                    papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                }

            }
        }

        private void GuardarImagen()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Guardar";
                sfd.Title = "Archivo PNG (*.png)|*.png|Archivo JPEG (*.jpeg;*jpg)|*.jpeg;*jpg|Archivo BMP (*.bmp)|*.bmp";

                if (sfd.ShowDialog()== DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;
                    switch (Path.GetExtension(sfd.FileName).ToLower())
                    {
                        case ".jpg":
                        case "jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    picBoxPapel.Image.Save(sfd.FileName, format);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarImagen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}