namespace jogovelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificando se o X ganho na horizontal */
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            //Verificando se o X ganhou na vertical
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            //Verificando se o X ganhou na diagonal
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O jogador X ganhou", "OK");
                zerar();
            }
            //Verificando se o O ganhou na horizontal
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            //Verificando se o O ganhou na vertical
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            //Verificando se o O ganhou na diagonal
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Fim de Jogo", "O jogador O ganhou", "OK");
                zerar();
            }

        } //fecha o método Button_Clicked

        void zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    } //fecha classe

} // fecha namespace