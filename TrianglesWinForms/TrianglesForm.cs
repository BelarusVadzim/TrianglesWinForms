using System.Windows.Forms;
using TrianglesWinForms.Operations;

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

        private async void TrianglesForm_Load(object sender, EventArgs e)
        {
            var view = await getTrianglesViewModelOperation.ExecuteAsync();

            infoTextLabel.Text = view.Info;

            if (view.HasErrors)
                return;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = view.RenderedTriangles;
        }
    }
}
