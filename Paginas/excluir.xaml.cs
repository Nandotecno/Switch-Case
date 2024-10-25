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
    public partial class excluir : ContentPage
    {
        public excluir()
        {
            InitializeComponent();
            btn_excluir.Clicked += Btn_excluir_Clicked;
        }

        private void Btn_excluir_Clicked(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            banco_funcoes dbf =  new banco_funcoes();
            dbf.criarBancoDeDados();

            dbf.excluirAluno(id);
        }
    }
}