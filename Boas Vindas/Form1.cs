namespace Boas_Vindas
{
    public partial class frmAula01 : Form
    {
        public frmAula01()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario;//Declaração de uma variável do tipo string 

            nomeUsuario = txtNome.Text;


            MessageBox.Show($"Bem vindo ao C# {nomeUsuario}", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = $"Bem Vindo ao C# {nomeUsuario}";
        }

       
        
        
    }
}
