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
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
            btn_recarregar.Clicked += Btn_recarregar_Clicked;
        }

        private void Btn_recarregar_Clicked(object sender, EventArgs e)
        {
            banco_funcoes dbf = new banco_funcoes();
            dbf.criarBancoDeDados();

            List<Alunos> listaAlunos = new List<Alunos>();
            listaAlunos = dbf.getAlunos();
            var array = listaAlunos.ToArray();
            List<Alunos> lista = new List<Alunos>();
            for(int i = 0; i < array.Length; i++)
            {
                lista.Add(new Alunos { id = array[i].id, nome = array[i].nome.ToString(), idade = array[i].idade });
            }
            ls_alunos.ItemsSource = lista;
        }
    }
}