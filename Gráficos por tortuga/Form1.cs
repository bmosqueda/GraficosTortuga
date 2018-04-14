using System;
using System.Windows.Forms;

namespace Gráficos_por_tortuga
{
    public partial class Form1 : Form
    {
        public class Tablero
        {
            public int[,] tablero { get; set; }
            private int rows;
            private int cols;

            public int Rows { get { return rows; } }
            public int Cols { get { return cols; } }

            public Tablero(int rows, int columns)
            {
                tablero = new int[rows, columns];
                this.rows = rows;
                this.cols = columns;

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        tablero[i, j] = 0;
            }

            public string mostrar()
            {
                string tableroString = "";

                for (int i = 0; i < rows; i++)
                {
                    tableroString += i > 9 ? i + "       " :i + "         ";
                    for(int j = 0; j < cols; j++)
                    {
                        tableroString += tablero[i, j] + "   ";
                    }
                    tableroString += "\n";
                }
                return tableroString;
            }
        }

        public class Tortuga
        {
            public Tablero tablero; 
            //UP = 1, DOWN, LEFT, RIGHT
            public int Direction { get; set; }
            // Abajo = 0, Arriba
            public int PlumaState { get; set; }

            private int rowPosition;
            private int colPosition;

            public int RowPosition { get { return rowPosition; } }
            public int ColPosition { get { return colPosition; } }

            public Tortuga(int RowsTablero, int ColsTablero)
            {
                tablero = new Tablero(RowsTablero, ColsTablero);
                //Rigth
                Direction = 4;
                //Arriba
                PlumaState = 1;

                rowPosition = 0;
                colPosition = 0;
            }

            public string getPosition()
            {
                return "[" + rowPosition + ", " + colPosition + "]";
            }

            public void avanzar(int avance)
            {
                int hasta;
                switch (Direction)
                {
                    case 1:
                        hasta = rowPosition - avance < 0 ? 0 : rowPosition - avance;
                        for (int i = rowPosition; i >= hasta; i--)
                            tablero.tablero[i, colPosition] = PlumaState == 0 ? 1 : tablero.tablero[i, colPosition];

                        rowPosition = hasta;
                        break;
                    case 2:
                        hasta = rowPosition + avance >= tablero.Rows ? tablero.Rows - 1 : rowPosition + avance;
                        for(int i = rowPosition; i <= hasta; i++)
                            tablero.tablero[i, colPosition] = PlumaState == 0 ? 1 : tablero.tablero[i, colPosition];

                        rowPosition = hasta;
                        break;
                    case 3:
                        hasta = colPosition - avance < 0 ? 0 : colPosition - avance;
                        for (int i = colPosition; i >= hasta; i--)
                            tablero.tablero[rowPosition, i] = PlumaState == 0 ? 1 : tablero.tablero[rowPosition, i];

                        colPosition = hasta;
                        break;
                    case 4:
                        hasta = colPosition + avance >= tablero.Cols ? tablero.Cols - 1 : colPosition + avance;
                        for(int i = colPosition; i <= hasta; i++)
                            tablero.tablero[rowPosition, i] = PlumaState == 0 ? 1 : tablero.tablero[rowPosition, i];

                        colPosition = hasta;
                        break;
                }
            }
        }

        private enum Direction { UP = 1, DOWN, LEFT, RIGHT };
        private enum Pluma { DOWN = 0, UP };
        private Tortuga tortuga;

        public Form1()
        {
            InitializeComponent();
            tortuga = new Tortuga(20, 20);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            tortuga.Direction = (int)Direction.UP;
            lblEstado.Text = "Arriba";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            tortuga.Direction = (int)Direction.DOWN;
            lblEstado.Text = "Abajo";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            tortuga.Direction = (int)Direction.LEFT;
            lblEstado.Text = "Izquierda";
        }

        private void btnRigth_Click(object sender, EventArgs e)
        {
            tortuga.Direction = (int)Direction.RIGHT;
            lblEstado.Text = "Derecha";
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            tortuga.PlumaState = (int)Pluma.UP;
            lblPlumaSatate.Text = "Pluma arriba";
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            tortuga.PlumaState = (int)Pluma.DOWN;
            lblPlumaSatate.Text = "Pluma abajo";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtTablero.Text = tortuga.tablero.mostrar();
            lblCoordenadas.Text = tortuga.getPosition();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            int avance = Convert.ToInt32(numAvance.Value);
            tortuga.avanzar(avance);

            txtTablero.Text = tortuga.tablero.mostrar();
            lblCoordenadas.Text = tortuga.getPosition();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            string[] datos = txtDatos.Text.Split(',');

            for (int i = 0; i < datos.Length; i++)
            {
                int num = Convert.ToInt32(datos[i].Trim());
                switch (num)
                {
                    case 1:
                        tortuga.PlumaState = (int)Pluma.UP;
                        break;
                    case 2:
                        tortuga.PlumaState = (int)Pluma.DOWN;
                        break;
                    case 3:
                        girar(true);
                        break;
                    case 4:
                        girar(false);
                        break;
                    case 5:
                        numAvance.Value = Convert.ToDecimal(datos[i + 1].Trim());
                        btnAvanzar.PerformClick();
                        break;
                    case 6:
                        btnMostrar.PerformClick();
                        break;
                    case 7:
                        MessageBox.Show("Terminado");
                        return;
                }
            }
        }

        public void girar(bool isRight)
        {
            switch(tortuga.Direction)
            {
                case ((int)Direction.UP):
                    tortuga.Direction = isRight ? (int)Direction.RIGHT : (int)Direction.LEFT;
                    break;
                case ((int)Direction.DOWN):
                    tortuga.Direction = isRight ? (int)Direction.LEFT : (int)Direction.RIGHT;
                    break;
                case ((int)Direction.RIGHT):
                    tortuga.Direction = isRight ? (int)Direction.DOWN : (int)Direction.UP;
                    break;
                case ((int)Direction.LEFT):
                    tortuga.Direction = isRight ? (int)Direction.UP : (int)Direction.DOWN;
                    break;
            }
        }
    }
}
