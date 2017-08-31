using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        public int PlayerOne = 1;
        public int PlayerTwo = 2;
        public static int CurrentPlayer = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (IsValidPosition(button) == false) return;
            else if (IsValidPosition(button) == true)
            {
                if (CurrentPlayer == PlayerOne)
                {
                    button.Text = "X";
                    if (HasWon(button) == true)
                    {
                        Label1.Text = "Player 1 Won";
                        Response.Redirect("TicTacToe.aspx");
                    }
                    CurrentPlayer = PlayerTwo;
                }
                else if (CurrentPlayer == PlayerTwo)
                {
                    button.Text = "O";
                    if (HasWon(button) == true)
                    {
                        Label1.Text = "Player 2 Won";
                        Response.Redirect("TicTacToe.aspx");
                    }

                    CurrentPlayer = PlayerOne;
                }
                if(IsAllBoxesFilled(button)==true)
                {
                    Label1.Text = "Game is Draw";
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected bool IsValidPosition(Button button)
        {
            if (button.Text.Equals("X") || button.Text.Equals("O"))
            {
                Label1.Text = "Box Already Filled";
                return false;
            }
            return true;
        }
        protected bool HasWon(Button button)
        {
            if (Button1.Text.Equals(Button2.Text) && Button2.Text.Equals(Button3.Text) && Button1.Text != "choice") return true;
            if (Button1.Text.Equals(Button4.Text) && Button4.Text.Equals(Button7.Text) && Button1.Text != "choice") return true;
            if (Button1.Text.Equals(Button5.Text) && Button5.Text.Equals(Button9.Text) && Button1.Text != "choice") return true;
            if (Button3.Text.Equals(Button6.Text) && Button6.Text.Equals(Button9.Text) && Button3.Text != "choice") return true;
            if (Button3.Text.Equals(Button5.Text) && Button5.Text.Equals(Button7.Text) && Button3.Text != "choice") return true;
            if (Button7.Text.Equals(Button8.Text) && Button8.Text.Equals(Button9.Text) && Button7.Text != "choice") return true;
            if (Button4.Text.Equals(Button5.Text) && Button5.Text.Equals(Button6.Text) && Button4.Text != "choice") return true;
            if (Button2.Text.Equals(Button5.Text) && Button5.Text.Equals(Button8.Text) && Button2.Text != "choice") return true;
            return false;

        }
        protected bool IsAllBoxesFilled(Button button)
        {
            if (Button1.Text != "choice" && Button2.Text != "choice" && Button3.Text != "choice" && Button4.Text != "choice" && Button5.Text != "choice" && Button6.Text != "choice" && Button7.Text != "choice" && Button8.Text != "choice" && Button9.Text != "choice")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}