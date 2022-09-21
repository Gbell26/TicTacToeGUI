namespace SpecialProject1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int turnCount = 0;

        private void button_Click(object sender, EventArgs e)
        {
            // sets the variable button to the button used to access event
            var button = sender as Button;
                
            //Validates if the button is empty 
                if (button.Text == "")
                {
                //If the space is empty checks what turn it is and outputs an X or O respectively
                    if (turnCount % 2 == 0)
                    {
                        button.Text = "X";
                    }
                    else
                    {
                        button.Text = "O";
                    }

                    //Advances to the next turn
                    turnCount++;
                }
                //If the space is already occupied an error message displays
                else
                {
                    MessageBox.Show("Invalid Choice");
                }

            if (turnCount >= 5) {
                CheckWinner();
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void CheckWinner()
        {
            //Method checks for a winner and displays a winner message

            //Checks from right corner across the top/down left side/ diagnol from top left to bottom right
            if (btnR1C1.Text != "" && btnR1C1.Text == btnR1C2.Text && btnR1C2.Text == btnR1C3.Text
                || btnR1C1.Text == btnR2C1.Text && btnR2C1.Text == btnR3C1.Text || btnR1C1.Text
                == btnR2C2.Text && btnR2C2.Text == btnR3C3.Text) { MessageBox.Show($"Winner! 3 {btnR1C1.Text}'s in a row!"); }
            
            //checks from bottom left corner up right side / across bottom
            if (btnR3C3.Text != "" && btnR3C3.Text == btnR3C2.Text && btnR3C2.Text == btnR3C1.Text
                || btnR3C3.Text == btnR2C3.Text && btnR2C3.Text == btnR1C1.Text) { MessageBox.Show($"Winner! 3 {btnR3C3.Text}'s in a row!"); }
            
            // checks diagnolly from bottom left to top right
            if (btnR1C3.Text != "" && btnR1C3.Text == btnR2C2.Text && btnR3C1.Text == btnR2C2.Text) { MessageBox.Show($"Winner! 3 {btnR3C3.Text}'s in a row!"); }

            //checks the middle 3 buttons across
            if (btnR1C2.Text != "" && btnR1C2.Text == btnR2C2.Text && btnR3C2.Text == btnR2C2.Text) { MessageBox.Show($"Winner! 3 {btnR1C2.Text}'s in a row!"); }

            //checks the middle 3 buttons top down
            if (btnR2C1.Text != "" && btnR2C1.Text == btnR2C2.Text && btnR2C3.Text == btnR2C2.Text) { MessageBox.Show($"Winner! 3 {btnR2C1.Text}'s in a row!"); }
        }
        private void DisableClicks()
        {

        }
    
    }
}