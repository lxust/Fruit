namespace Fruit
{
    public partial class Form1 : Form
    {

        public static Player player; 

        public Dictionary<string, List<string>> fruitImages = new Dictionary<string, List<string>>() {
            ["bad"] = new List<string>() { "1.png", "2.png", "3.png", "4.png" },
            ["good"] = new List<string> { "5.png" }
        };

        List<PictureBox> pictureBoxes;

        public Form1()
        {
            InitializeComponent();
            
            
            player = new Player(lblMoney, lblLevel, lblHelp);
            CourentPcbs();
            FillLBL();
        }

        private void CourentPcbs()
        {
            if (player.lvl >= 0 && player.lvl < 4)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2};
                pcb1.Enabled = true;
                pcb2.Enabled = true;

                pcb3.ImageLocation = null;
                pcb3.Enabled = false;
                pcb4.ImageLocation = null;
                pcb4.Enabled = false;
                pcb5.ImageLocation = null;
                pcb5.Enabled = false;
            }
            else if (player.lvl >= 4 && player.lvl < 7)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2, pcb3 };
                pcb1.Enabled= true;
                pcb2.Enabled= true;
                pcb3.Enabled= true;
                pcb3.Enabled = true;
                pcb4.ImageLocation = null;
                pcb4.Enabled = false;
            }
            else if (player.lvl >= 7 && player.lvl < 9)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2, pcb3, pcb4 };
                pcb1.Enabled = true;
                pcb2.Enabled = true;
                pcb3.Enabled = true;
                pcb4.Enabled = true;
                pcb5.ImageLocation = null;
                pcb5.Enabled = false;
                pcb4.Enabled = true;
            }
            else if (player.lvl >=10)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2, pcb3, pcb4, pcb5 };
                pcb1.Enabled = true;
                pcb2.Enabled = true;
                pcb3.Enabled = true;
                pcb4.Enabled = true;
                pcb5.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GetFruits();
        }

        private void GetFruits()
        {
            

            Random random = new Random();
            int IdGoodPCB = random.Next(0, pictureBoxes.Count);

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                if (i == IdGoodPCB)
                {
                    pictureBoxes[i].ImageLocation = $@"..\..\..\Images\Good\{GetPicture("good")}";
                }
                else
                {
                    pictureBoxes[i].ImageLocation = $@"..\..\..\Images\Bad\{GetPicture("bad")}";
                }
            }

        }

        private string GetPicture(string FruitType)
        {
            var PictureList = fruitImages[FruitType];
            Random random = new Random();
            int Id = random.Next(0, PictureList.Count);

            return PictureList[Id];
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb2);
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb1);
        }

        private void CheckAnswer(PictureBox pcb)
        {
            string type = pcb.ImageLocation.Split(@"\")[^2];

            if (type == "Bad")
            {
                if (player.cash >= 20)
                    player.cash -= 20;
                else
                    player.cash = 0;

                if (player.lvl > 0)
                    player.lvl--;

                player.mestaces++;
                MessageBox.Show("Ïëîõîé ôðóêò!");
            }
            else if (type == "Good")
            {
                player.cash += 10;
                player.lvl++;
            }

            FillLBL();
            CheckWin();
            CourentPcbs();
            GetFruits();
        }

        public void FillLBL()
        {
            player.UpdateInfo();
        }
        private void CheckWin()
        {
            if (player.lvl == 11)
            {
                MessageBox.Show($"ÏÎÁÅÄÀ!\n$={player.cash}\nÎøèáîê={player.mestaces}");
                player.lvl = 0;
                player.cash = 0;
                player.mestaces = 0;
                player.usethelp = 0;
                player._help = 0; 
                FillLBL();
            }
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb3);
        }

        private void pcb4_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb4);
        }

        private void pcb5_Click(object sender, EventArgs e)
        {
            CheckAnswer(pcb5);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FillLBL();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (player._help >= 1 && player.usethelp <= 1)
            {
                player.usethelp++;
                player._help--;
                int countDel = pictureBoxes.Count / 2;

                foreach (PictureBox pictureBox in pictureBoxes)
                {
                    if (countDel > 0)
                    {
                        string type = pictureBox.ImageLocation.Split(@"\")[^2];
                        if (type == "Bad")
                        {
                            pictureBox.ImageLocation = null;
                            pictureBox.Enabled = false;
                            countDel--;
                        } 
                    }
                }

                FillLBL();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShop formShop = new FormShop();
            formShop.Show();
        }
    }
}