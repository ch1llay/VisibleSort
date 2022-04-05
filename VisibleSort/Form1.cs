namespace VisibleSort
{
    public partial class Form1 : Form
    {
        const int N = 10;
        int[] array = new int[N];
        Label[] labels = new Label[N];
        int index1, index2;
        int indexI, indexJ;
        Point newLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void SortArray(ref int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        void GenerateArray(ref int[] array)
        {
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                if(labels[i] != null)
                {
                    labels[i].Visible = false;
                }
                labels[i] = null;
                
                array[i] = random.Next(0, N);
            }
            System.GC.Collect();
        }
        void Replace(int index1, int index2)
        {
            labels[this.index1].BackColor = Color.White;
            labels[this.index2].BackColor = Form1.DefaultBackColor;
            labels[index1].BackColor = Color.Yellow;
            labels[index2].BackColor = Color.Yellow;
            (labels[index1], labels[index2]) = (labels[index2], labels[index1]);
            (labels[index1].Location, labels[index2].Location) = (labels[index2].Location, labels[index1].Location);
            (array[index1], array[index2]) = (array[index2], array[index1]);
            this.index1 = index1;
            this.index2 = index2;
        }
        private void generateNumsButton_Click(object sender, EventArgs e)
        {
            int top = 100;
            int left = 20;
            int tabIndex = 0;
            int width = 40;
            GenerateArray(ref array);
            
            for (int i = 0; i < array.Length; i++)
            {
                labels[i] = new Label
                {
                    Text = array[i].ToString(),
                    Location = new Point(left, top),
                    TabIndex = tabIndex,
                    Width = width
                };

                Controls.Add(labels[i]);
                left += width;

            }
        }
        void Fill(int index1, int index2)
        {
            labels[this.index1].BackColor = Form1.DefaultBackColor;
            labels[this.index2].BackColor = Form1.DefaultBackColor;
            labels[indexI].BackColor = Color.OrangeRed;
            labels[indexJ].BackColor = Color.OrangeRed;
            this.index1 = indexI;
            this.index2 = indexJ;
        }
        private void nextStepButton_Click(object sender, EventArgs e)
        {
            int temp;
            if (indexI < array.Length)
            {
                if (indexJ == 0)
                {
                    indexJ = indexI + 1;
                }
                if(indexJ < array.Length)
                {
                    Fill(indexI, indexJ);
                    if (array[indexI] > array[indexJ])
                    {
                        Replace(indexI, indexJ);
                    }
                    indexJ++;
                }
                else
                {
                    indexI++;
                    indexJ = 0;
                }
                
            }
            else
            {
                MessageBox.Show("Отсортировано");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var location = labels[index1].Location;
            //if (labels[index1].Location == newLocation)
            //{
            //    timer1.Enabled = false;
            //}
            //else
            //{
            //    labels[index1].Location = new Point(location.X+1, location.Y+1);

            //}
            //int temp;
            //for (int i = index; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            //Replace((int)index1Key.Value, (int)index2Key.Value);
        }
    }
}