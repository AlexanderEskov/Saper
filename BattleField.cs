namespace Saper
{
    public enum DifficultyLevel
    {
        Easy,
        Normal,
        Hard
    }

    public partial class BattleField : Form
    {
        const int cellSize = 24;
        public BattleField()
        {
            InitializeComponent();
            GenerateButtons();
        }

        public BattleField(MenuForm mainform)
        {
            InitializeComponent();
            this.MainForm = mainform;
            GenerateButtons();
        }

        public BattleField(MenuForm mainform, DifficultyLevel difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            this.MainForm = mainform;
            Init();
            GenerateButtons();
        }

        private void Init()
        {
            // Размер поля зависит от уровня сложности
            fieldSize = difficulty switch
            {
                DifficultyLevel.Easy => new Size(10, 10),
                DifficultyLevel.Normal => new Size(16, 16),
                DifficultyLevel.Hard => new Size(30, 16),
                _ => new Size(10, 10)
            };
            
            spaceSize = (groupBox1.Location.X + groupBox1.Size.Width + 10);

            Size = new Size(
                (fieldSize.Width + 1) * cellSize + spaceSize,
                (fieldSize.Height + 2) * cellSize
             );
        }

        private void InitMap()
        {
            for (int i = 0; i < fieldSize.Width; i++)
            {
                for(int j = 0; j < fieldSize.Height; j++)
                {
                    mapppp[i, j] = 0;
                }
            }

            // Генерация бомб
            // Количество зависит от сложности
            int bombCount = difficulty switch
            {
                DifficultyLevel.Easy => 10,
                DifficultyLevel.Normal => 20,
                DifficultyLevel.Hard => 90,
                _ => 10,
            };

            Random generator = new Random();
            int plantCounter = 0;

            // Если бомба уже поставлена, то попробовать снова
            while(plantCounter < bombCount)
            {
                int posX = generator.Next(0, fieldSize.Width);
                int posY = generator.Next(0, fieldSize.Height);
                // TODO исправить
                
                //if (map[posX, posY] == 0)
                //{
                //    mapp[posX, posY] = 1;
                //    plantCounter++;
                //}
            }
        }

        private bool isBomb(int i, int j)
        {
            if (mapppp[i, j] == 1)
            {
                return true;
            }
            return false;
        }

        private void CellButtonCLickHandler(object sender, MouseEventArgs e)
        {
            Cell cell = (Cell)sender;
            switch(e.Button)
            {
                case MouseButtons.Right:
                    cell.ToggleFlag();

                    break;
                case MouseButtons.Left:
                    if(cell.hasBomb())
                    {
                        GameOver();
                    }
                    else
                    {
                        OpenCell(cell);
                    }
                    break;
            }
        }

        private bool isValidCellNumber(int i, int j)
        {
            if (i < fieldSize.Width && j < fieldSize.Height && i >= 0 && j >= 0)
            {
                return true;
            }
            return false;
        }

        // Возвращает число бомб в окрестности
        private int BombCountAround(int i, int j)
        {
            int count = 0;
            // TODO проверить
            for (int k = i - 1; k >= i + 1; k++)
            {
                for (int l = j - 1; l >= j + 1; l++)
                {
                    if (map[i,j].hasBomb() && i != k && j != k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // Открывает текущую ячейку и рекурсивно все свободные ячейки вокруг
        private void OpenCell(Cell cell)
        {
            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    if (ReferenceEquals(cell, map[i,j]))
                    {
                        for (int k = i - 1; k >= i + 1; k++)
                        {
                            for (int l = j - 1; l >= j + 1; l++)
                            {
                                if (isValidCellNumber(k, l) && !cell.hasBomb())
                                {
                                    if(!cell.empty())
                                    {
                                        cell.Text = Convert.ToString(BombCountAround(k, l));
                                    }
                                    OpenCell(map[k, l]);
                                }
                                else if(cell.hasBomb())
                                {
                                    GameOver();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void GenerateButtons()
        {
            map = new Cell[fieldSize.Width, fieldSize.Height];

            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    map[i, j] = new Cell();
                    map[i, j].Location = new Point(i* cellSize + spaceSize, j * cellSize + 5);
                    map[i, j].Size = new Size(cellSize, cellSize);
                    map[i, j].Text = "";
                    map[i, j].Image = null;
                    map[i, j].UseVisualStyleBackColor = true;
                    map[i, j].Margin = new Padding(0);
                    map[i, j].Padding = new Padding(0);
                    map[i, j].FlatStyle = FlatStyle.Flat;
                    map[i, j].MouseDown += new MouseEventHandler(CellButtonCLickHandler);
                    // 
                    // Form1
                    // 

                   
                    //AutoScaleDimensions = new SizeF(7F, 15F);
                    //AutoScaleMode = AutoScaleMode.Font;
                    Controls.Add(map[i,j]);
                }
            }
        }

        private void GameOver()
        {
            for(int i = 0; i < fieldSize.Width; i++)
            {
                for(int j = 0; j < fieldSize.Height; j++)
                {
                    if (map[i, j].hasBomb())
                    {
                        map[i, j].Image = Properties.Resources.explosion;
                    }
                }
            }
        }

        private Size fieldSize;             // Размер поля
        private Cell[,] map;                // Кнопки на поле
        private int[,] mapppp;                 // Статус карты
        private int spaceSize;              // Отступ начала поля
        private DifficultyLevel difficulty; // Уровень сложности
    }
}
