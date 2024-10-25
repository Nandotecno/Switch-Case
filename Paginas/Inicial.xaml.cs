using App1.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {
        public Inicial()
        {
            InitializeComponent();
            btn_enviar.Clicked += Btn_enviar_Clicked;
        }

        private void Btn_enviar_Clicked(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string idade = txt_idade.Text;
            banco_funcoes dbf = new banco_funcoes();
            dbf.criarBancoDeDados();

            dbf.inserirAluno(nome, idade);
        }
    }
}