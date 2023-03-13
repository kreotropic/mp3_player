using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp32
{
    public partial class MPlayer : Form
    {
        public MPlayer()
        {
            InitializeComponent();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //selecionar musica
            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Multiselect = true;
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                
                for(int i = 0; i < files.Length; i++) {
                    listaMusicas.Items.Add(files[i]);
                }
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string[] paths, files;

        private void listaMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listaMusicas.SelectedIndex];    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            this.Close();
        }
    }
}
