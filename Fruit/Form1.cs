namespace Fruit
{
    public partial class Form1 : Form
    {
        int lvl = 0;
        int cash = 0;
        int mestaces = 0;

        public Dictionary<string, List<string>> fruitImages = new Dictionary<string, List<string>>() {
            ["bad"] = new List<string>() { "1.png", "2.png", "3.png", "4.png" },
            ["good"] = new List<string> { "5.png" }
        };

        List<PictureBox> pictureBoxes;

        public Form1()
        {
            InitializeComponent();
            FillLBL();
            CourentPcbs();
        }

        private void CourentPcbs()
        {
            if (lvl >= 0 && lvl < 4)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2};
            }
            else if (lvl >= 4 && lvl < 7)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2, pcb3 };
            }
            else if (lvl >= 7 && lvl < 9)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2, pcb3, pcb4 };
            }
            else if (lvl >=10)
            {
                pictureBoxes = new List<PictureBox> { pcb1, pcb2, pcb3, pcb4, pcb5 };
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
                if (cash >= 20)
                    cash -= 20;
                else
                    cash = 0;

                if (lvl > 0)
                    lvl--;

                mestaces++;
                MessageBox.Show("Плохой фрукт!");
            }
            else if (type == "Good")
            {
                cash += 10;
                lvl++;
            }

            FillLBL();
            CheckWin();
            CourentPcbs();
            GetFruits();
        }

        private void FillLBL()
        {
            lblLevel.Text = lvl.ToString();
            lblMoney.Text = cash.ToString();
        }
        private void CheckWin()
        {
            if (lvl == 11)
            {
                MessageBox.Show($"ПОБЕДА!\n$={cash}\nОшибок={mestaces}");
                lvl = 0;
                cash = 0;
                mestaces = 0;
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
    }
}