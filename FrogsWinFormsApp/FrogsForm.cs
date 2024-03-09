namespace FrogsWinFormsApp
{
    public partial class FrogsForm : Form
    {
        private int movesNumber = 0;
        private List<PictureBox> frogs;

        public FrogsForm()
        {
            InitializeComponent();
            AddFrogs();
        }
        private void AddFrogs()
        {
            frogs = new List<PictureBox> { leftFrogPictureBox1 , leftFrogPictureBox2, leftFrogPictureBox3, leftFrogPictureBox4,
                emptyPictureBox, rightFrogPictureBox1, rightFrogPictureBox2, rightFrogPictureBox3, rightFrogPictureBox4};
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            if (EndGame())
            {
                ShowUserEndGame();
            }
        }

        private void ShowUserEndGame()
        {
            string messegeBoxText;
            if (movesNumber > 24)
                messegeBoxText = "Вы выиграли! Но можно пройти за меньшее число шагов. \nХотите заново пройти игру?";
            else
                messegeBoxText = "Вы выиграли за минимальное количество ходов, молодец! \nХотите заново пройти игру?";

            DialogResult dialogResult = MessageBox.Show(messegeBoxText, "Поздравляем!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void Swap(PictureBox clickedPictureBox)
        {
            if (!EndGame())
            {
                var distance = Math.Abs(clickedPictureBox.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Width;

                if (distance > 2)
                {
                    MessageBox.Show("Так нельзя!");
                }
                else
                {
                    var location = clickedPictureBox.Location;
                    clickedPictureBox.Location = emptyPictureBox.Location;
                    emptyPictureBox.Location = location;
                    movesNumberLabel.Text = $"Количество ходов: {++movesNumber}";
                }
            }
        }
        public bool EndGame()
        {
            var halfWidthForm = ClientSize.Width / 2;
            if (emptyPictureBox.Location.X < halfWidthForm - emptyPictureBox.Width || emptyPictureBox.Location.X > halfWidthForm)
                return false;

            foreach (var frog in frogs)
            {
                if (frog.Tag == "leftFrog" && frog.Location.X < halfWidthForm || frog.Tag == "rightFrog" && frog.Location.X > halfWidthForm)
                {
                    return false;
                }
            }
            return true;
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Нажимай на лягушек." +
                "\n2. Лягушки могу скакать только на пустую клетку рядом или через одну лягушку." +
                "\n3. Ты выиграешь, когда все лягушки поменяются местами, лягушки справа должны ускакать налево, а слева - ускакать направо." +
                "\n4. Постарайся пройти игру за минимальное количество ходов.", "Правила игры");
        }

        private void начатьСНачалаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}