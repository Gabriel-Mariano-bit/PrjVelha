namespace PrjVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";

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

           //Verifica  Empate
            if (!string.IsNullOrWhiteSpace(btn10.Text) &&
                !string.IsNullOrWhiteSpace(btn11.Text) &&
                !string.IsNullOrWhiteSpace(btn12.Text) &&
                !string.IsNullOrWhiteSpace(btn20.Text) &&
                !string.IsNullOrWhiteSpace(btn21.Text) &&
                !string.IsNullOrWhiteSpace(btn22.Text) &&
                !string.IsNullOrWhiteSpace(btn30.Text) &&
                !string.IsNullOrWhiteSpace(btn31.Text) &&
                !string.IsNullOrWhiteSpace(btn32.Text))
            {
                DisplayAlert("Deu Velha!", "Ninguém Ganhou!", "Novo jogo");
                Zerar();
            }
            else
            {
                /* Verificando se o X ganhou na 1ª linha */
                if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                /* Verificando se o X ganhou na 2ª linha */
                if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                /* Verificando se o X ganhou na 3ª linha */
                if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                /* Verificando se o X ganhou nas colunas */
                if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                /* Verificando diagonais */
                if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }

                if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
                {
                    DisplayAlert("Parabéns!", "O X ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
                if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
                {
                    DisplayAlert("Parabéns!", "O ganhou!", "Novo jogo");
                    Zerar();
                    return;
                }
            }

        
        }

        void Zerar()
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

    } 
} 
    

    
