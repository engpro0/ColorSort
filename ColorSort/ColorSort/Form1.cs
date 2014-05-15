using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ColorSort
{
    public partial class Form1 : Form
    {
        private Color[] col;
        public Form1()
        {
            
            InitializeComponent();
        }


        Graphics g;
        Rectangle r;
        Pen p;
        SolidBrush b;
        private Color[] intToCol(int [] intCol)
        {
            Color [] result = new Color[intCol.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ColorTranslator.FromWin32(intCol[i]);
            }
            return result;
        }
        private int[] colToInt()
        {
            int [] result = new int[col.Length];
            for (int i = 0; i < result.Length; i++ )
            {
                result[i] = ColorTranslator.ToWin32(col[i]);
            }
            return result;
        }
        private Color[] genCol(int size)
        {
            int R,G,B;
            R = G = B = 0;
            bool rCheck, gCheck, bCheck, ranRedCheck, ranGreenCheck, ranBlueCheck;
            rCheck = gCheck = bCheck = ranRedCheck= ranGreenCheck = ranBlueCheck= false;

            Random ran = new Random();

            if (this.redCheck.Checked)
            {
                rCheck = true;
            }
            if (this.greenCheck.Checked)
            {
                gCheck = true;
            }
            if (this.blueCheck.Checked)
            {
                bCheck = true;
            }
            if (this.ranRedCheck.Checked){
                ranRedCheck = true;
            }
            if (this.ranGreenCheck.Checked)
            {
                ranGreenCheck = true;
            }
            if (this.ranBlueCheck.Checked)
            {
                ranBlueCheck = true;
            }

 
            Color[] result = new Color[size];
            
            for (int i = 0; i < result.Length; i++)
            {
                if (rCheck)
                    R = ranRedCheck ?ran.Next(0, 255):255;
                else
                    R = 0;
                if (gCheck)
                    G = ranGreenCheck ? ran.Next(0, 255) : 255;
                else
                    G = 0;
                if (bCheck)
                    B = ranBlueCheck ? ran.Next(0, 255) : 255;
                else
                    B = 0;
        
                result[i] = Color.FromArgb(R,G,B);//ran.Next(0,255), ran.Next(0,255));
            }
                return result;
        }
        private void printScreen(int x1,int y1)
        {
            g = CreateGraphics();
            int i = 0;
            foreach (Color c in col)
            {

                r = new Rectangle(x1, i, 200, 1);
                g.FillRectangle(new SolidBrush(c), r);
                i++;

            }

        }
        //this.textBox1.Text = ColorTranslator.ToWin32(b.Color).ToString();
        private void Draw_button_Click(object sender, EventArgs e)
        {
            col = genCol(200);
            printScreen(0, 0);
            Sort s = new Sort();
            int[] c = colToInt();
            c = s.mergeSort(c, 0, c.Length - 1);
            this.col = this.intToCol(c);
            //System.Threading.Thread.Sleep(500); //Locks the program, dont use in actual application
            printScreen(200, 0);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Color c in col){
                this.textBox1.Text = c.ToArgb().ToString();
                
            }
            

        }


        private void redCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void greenCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void blueCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ranCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        

       
    }
}
