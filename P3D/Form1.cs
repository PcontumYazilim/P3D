using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace P3D
{
    public partial class Form1 : Form
    {
        private bool escd = false;
        private bool taskbarsit = true;
        public string oda = "baslangic";
        public string oncekioda = "";
        private int aci = 0;
        private int maxbott;
        private int ortadeger;
        public bool inputmethod = true;//true keyboard-false joystick, eldiven
        Bitmap psl = new Bitmap(P3D.Properties.Resources.lego);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskbar.Width = this.ClientSize.Width;
            panelcenter.Left = (this.Size.Width / 2) - (panelcenter.Size.Width / 2);
            maxbott = -1080 + this.Size.Height;
            ortadeger = (maxbott) / 2;
            alan.Top = ortadeger;
            menu.Left = (this.Size.Width / 2) - (menu.Size.Width / 2);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                gokey("esc");
            }
            else if (e.KeyCode == Keys.P)
            {
                gokey("p");
            }
            else if (e.KeyCode == Keys.F1)
            {
                gokey("f1");
            }
            else if (e.KeyCode == Keys.F2)
            {
                gokey("f2");
            }
            else if (e.KeyCode == Keys.F3)
            {
                gokey("f3");
            }
            /*Arrow keys*/
            else if (e.KeyCode == Keys.D0)
            {
                yon("alt");
            }
            else if (e.KeyCode == Keys.D9)
            {
                yon("orta");
            }
            else if (e.KeyCode == Keys.D8)
            {
                yon("ust");
            }


            else if (e.KeyCode == Keys.A)
            {
                yon("sol");
            }
            else if (e.KeyCode == Keys.S)
            {
                yon("geri");
            }
            else if (e.KeyCode == Keys.D)
            {
                yon("sag");
            }
            else if (e.KeyCode == Keys.W)
            {
                yon("ileri");
            }
            else if (e.KeyCode == Keys.Space)
            {
                yon("zipla");
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            taskbar.Width = this.ClientSize.Width;
            panelcenter.Left = (this.Size.Width / 2) - (panelcenter.Size.Width / 2);
            menu.Left = (this.Size.Width / 2) - (menu.Size.Width / 2);
        }
        private void gokey(string val)
        {
            if (val == "esc")
            {
                if (escd == true)
                {
                    escd = false;
                    this.TopMost = true;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
                else if (escd == false)
                {
                    escd = true;
                    this.TopMost = true;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                }
            }
            else if (val == "p")
            {
                if (taskbarsit == true)
                {
                    taskbar.Visible = false;
                    taskbarsit = false;
                }
                else if (taskbarsit == false)
                {
                    taskbar.Visible = true;
                    taskbarsit = true;
                }
            }
            else if (val == "f1")
            {
                System.Diagnostics.Process.Start("http://pcontum.com/klavuz");
            }
            else if (val == "f2")
            {
                Application.Exit();
            }
            else if (val == "f3")
            {
                MessageBox.Show(
                    "Hakkında:\n" +
                    "Yazılım Adı:\n" +
                    "Pcontum 3D\n" +
                    "Emeği Geçenler:\n" +
                    "Ahmet Esat KAYA\n" +
                    "Orhan Erva UZUN\n" +
                    "Abdulaziz AYDIN\n" +
                    "Salih Enes Uçar\n" +
                    "Lisans:\n" +
                    "Pcontum Lisansı (http://pcontum.com/lisans)",
                    "Hakkında",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
        private void yon(string yonval) { 
            if (yonval == "ileri")
            {
                if (oda == "baslangic")
                {
                    if (aci > -50 || aci < 50)
                    {
                        oda = "villa";
                        alan.Left = 0;
                        aci = 0;
                    }
                }
            }
            else if (yonval == "geri")
            {
                
            }
            else if (yonval == "sag")
            {
                aci++;
                alan.Left -= 20;
            }
            else if (yonval == "sol")
            {
                aci++;
                alan.Left += 20;
            }
            else if (yonval == "zipla")
            {
                
            }
            else if (yonval == "orta")
            {
                alan.Top = ortadeger;
            }
            else if (yonval == "alt")
            {
                alan.Top = maxbott;
            }
            else if (yonval == "ust")
            {
                alan.Top = 0;
            }
        }

        private void panelgizle_Click(object sender, EventArgs e)
        {
            taskbar.Visible = false;
            taskbarsit = false;
        }
        private void haritabuton_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            harita.Visible = true;
        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }
        private void menuac_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            harita.Visible = false;
        }
        private void alan_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            harita.Visible = false;
        }
        private void pusuladeg()
        {
            psl.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pusula.Image = psl;
        }
    }
}