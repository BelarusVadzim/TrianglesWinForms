using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangles.Utils;
using TrianglesWinForms.Operations;
using TrianglesWinForms.ViewModels.Factories;

namespace TrianglesWinForms
{
    public partial class TrianglesForm : Form
    {
        private readonly GetTrianglesViewModelOperation getTrianglesViewModelOperation;

        public TrianglesForm()
        {
            InitializeComponent();

            getTrianglesViewModelOperation = new GetTrianglesViewModelOperation();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TrianglesForm_Load(object sender, EventArgs e)
        {
            var view = getTrianglesViewModelOperation.Execute();

            infoTextLabel.Text = view.Info;

            if (view.HasErrors)
                return;

            pictureBox1.Image = view.RenderedTriangles;
        }
    }
}
