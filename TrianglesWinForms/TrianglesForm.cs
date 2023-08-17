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
            var xxx = new HW.HW();
            var yyy = xxx.Execute();

            var trinaglesViewModel = await getTrianglesViewModelOperation.ExecuteAsync();

            infoTextLabel.Text = trinaglesViewModel.Info;

            if (trinaglesViewModel.HasErrors)
                return;

            pictureBox1.Image = trinaglesViewModel.RenderedTriangles;
        }
    }
}
