using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float IMC, PESO, ALTURA;
        private void button1_Click(object sender, EventArgs e)
        {

            PESO = float.Parse(txt_peso.Text);
            ALTURA = float.Parse(txt_altura.Text);

            IMC = PESO / (ALTURA * ALTURA);

            if (IMC <= 18.5)
                MessageBox.Show(" IMC :  " +IMC+  "               BAIXO PESO  :  Nesse ponto , o corpo deixa de ser saudável e o organismo fica mais vulnerável a infecções. Se o baixo peso persistir , mesmo com alimentação normal , procure ajuda medica ; a dificuldade para engordar pode ser sintoma de alguma doença insidiosa , como o diabetes.");

            if (IMC > 18.5 && IMC <= 24.9)
                MessageBox.Show(" IMC :  " +IMC+ "               PESO IDEAL  :  Seu peso esta adequado à altura. É importante manter a educação alimentar e a atividade física. Fique atento caso seu valor esteja perto dos limites para os estágios de Baixo Peso ou Sobrepeso.");

            if (IMC > 24.9 && IMC <= 29.9)
                MessageBox.Show(" IMC :  " +IMC+ "               SOBREPESO   : Esta faixa indica que você esta com predisposição a obesidade; dependendo do seu historico familiar e pessoal , pode haver um quadro pré-diabetes e hipertensão. Procure orientação médica para evitar o proximo estágio , Obesidade 1 . Quanto mais quilos extras , maior a dificuldade para emagrecer.");

            if (IMC > 29.9 && IMC <= 34.9)
                MessageBox.Show(" IMC :  " +IMC+ "               OBESIDADE GRAU 1   :  O risco de desenvolver diabetes, para quem está nesta faixa de peso , é de 20% e o hipertensão ultrapassa 25%. Há risco maior de outras doençãs cardiovasculares , articulares , distúrbios psiquiatricos , apneia de sono e até certos tipos de câncer.");

            if (IMC > 34.9 && IMC <= 39.9)
                MessageBox.Show(" IMC :  " + IMC + "               OBESIDADE GRAU 2   : O risco de desenvolver diabetes chega a 40%, e a chance de surgirem doenças associadas à obesidade , como reumatismos , câncer , apneia do sono , hipertensão e outros problemas cardiovasculares pode chegar a 50%. Procure orientaçao médica.");

            if (IMC >= 40)
                MessageBox.Show(" IMC :  " + IMC + "               OBESIDADE GRAU 3   : O risco de desenvolver doenças associadas ao excesso de peso , como diabetes, reumatismos , câncer , apneia do sono , hipertensão e outros problemas cardiovasculares chega a até 90% . Nesse estágio , a cirurgia de reduçãodo estomago pode ser indicada. Procure orientação médica imediatamente.");


            txt_altura.Clear();
            txt_peso.Clear();

            txt_peso.Focus();

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            txt_altura.Clear();
            txt_peso.Clear();

            txt_peso.Focus();
        }
    }
}
