namespace JogoDaVelha
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

            btn.Text = vez;
            vez = (vez == "X") ? "O" : "X";

            VerificarVitoria();
        }

        private void VerificarVitoria()
        {
        

            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") ||
                (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") ||
                (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") ||
                (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") ||
                (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") ||
                (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") ||
                (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") ||
                (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X"))
            {
                DisplayAlert("Vencedor", "Jogador X venceu!", "OK");
                Zerar();
                return;
            }
           
            if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") ||
                (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") ||
                (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") ||
                (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") ||
                (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") ||
                (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") ||
                (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") ||
                (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O"))
            {
                DisplayAlert("Vencedor", "Jogador O venceu!", "OK");
                Zerar();
                return;
            }
            else if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                btn30.Text != "" && btn31.Text != "" && btn32.Text != "")
            {
                DisplayAlert("Empate", "Deu velha!", "OK");
                Zerar();
            }
        }
        void Zerar ()
        { btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

        }


    }

}
