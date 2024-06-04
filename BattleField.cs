namespace Saper
{
    public enum DifficultyLevel
    {
        Easy,
        Normal,
        Hard
    }

    public enum Status
    {
        Continue,
        Win,
        Fail
    }

    public partial class BattleField : Form
    {
        const int cellSize = 24;
        public BattleField()
        {
            InitializeComponent();
            GenerateButtons();
        }

        //public BattleField(MenuForm mainform)
        //{
        //    InitializeComponent();
        //    this.MainForm = mainform;
        //    GenerateButtons();
        //}

        public BattleField(MenuForm mainform, DifficultyLevel difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            this.MainForm = mainform;
            this.IsFirstClick = true;
            this.GameStatus = Status.Continue;
            this.bombCount = 0;
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

            // Отступ слева
            spaceSize = (groupBox1.Location.X + groupBox1.Size.Width + 10);

            // Размер окна в пикселях
            Size = new Size(
                (fieldSize.Width + 1) * cellSize + spaceSize,
                (fieldSize.Height + 2) * cellSize
             );
        }

        // Обработка нажатия на ячейку минного поля
        private void CellButtonCLickHandler(object sender, MouseEventArgs e)
        {
            Cell cell = (Cell)sender;
            // При первом нажатии игрок не должен попасть на бомбу,
            // поэтому расставление бомб происходит после первого нажатия
            if (IsFirstClick)
            {
                PlantBombs(cell.x, cell.y);
                BombCountInit();
                IsFirstClick = false;
            }
            switch (e.Button)
            {
                case MouseButtons.Right:
                    cell.ToggleFlag();

                    break;
                case MouseButtons.Left:
                    if (cell.hasBomb())
                    {
                        GameOver(cell.x, cell.y);
                    }
                    else
                    {
                        OpenCell(cell.x, cell.y);
                    }
                    break;
            }
            MarkVisited();
        }

        // Проверка координат на нахождение в пределах поля
        private bool isValidCellNumber(int i, int j)
        {
            if (i < fieldSize.Width && j < fieldSize.Height && i >= 0 && j >= 0)
            {
                return true;
            }
            return false;
        }

        // Расставление количества бомб на карте
        private void BombCountInit()
        {
            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    if (map[i,j].empty())
                    {
                        int count = 0;
                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                //if(!isValidCellNumber(k, l))
                                //{
                                //    continue;
                                //}

                                // TODO
                                // Косяк в map[k,l] - k и l еще не проверены
                                if (isValidCellNumber(k, l) && map[k, l].hasBomb() && !((i == k) && (j == k)))
                                {
                                    count++;
                                }
                            }
                        }
                        map[i, j].setBombsAround(count);
                      
                    }
                }
            }
        }


        private Color GetCellColor(int rang)
        {
            switch (rang)
            {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.DarkBlue;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.DarkCyan;
                case 4:
                    return Color.Cyan;
                case 5:
                    return Color.DarkGreen;
                case 6:
                    return Color.Green;
                case 7:
                    return Color.Red;
                case 8:
                    return Color.Violet;
            }
            return Color.Black;
        }
        // Открывает текущую ячейку и рекурсивно все свободные ячейки вокруг
        private void OpenCell(int x, int y)
        {
            if (!map[x, y].visited)
            {
                if (map[x, y].BombsAround != 0)
                {
                    map[x, y].Text = Convert.ToString(map[x, y].BombsAround);
                    map[x, y].Enabled = false;
                    map[x, y].BackColor = Color.WhiteSmoke;
                }
                else
                {
                    // Рекурсивно открываются ячейки вокруг пустой
                    for (int k = x - 1; k <= x + 1; k++)
                    {
                        for (int l = y - 1; l <= y + 1; l++)
                        {
                            if (isValidCellNumber(k, l))
                            {
                                map[x, y].visited = true;
                                if(map[x, y].empty())
                                {
                                    map[x, y].Enabled = false;
                                    map[x, y].BackColor = Color.WhiteSmoke;
                                }
                                OpenCell(k, l);
                            }
                        }
                    }
                }
            }
        }

        public void MarkVisited()
        {
            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    map[i, j].visited = false;
                }
            }
        }

        // Размещение бомб
        private void PlantBombs(int x, int y)
        {
            // Генерация бомб
            bombCount = difficulty switch
            {
                DifficultyLevel.Easy => 10,
                DifficultyLevel.Normal => 20,
                DifficultyLevel.Hard => 90,
                _ => 10,
            };

            Random generator = new Random();

            // Счётчик уже расставленных бомб
            int plantCounter = 0;

            // Если бомба уже поставлена, то попробовать снова
            while (plantCounter < bombCount)
            {
                int posX = generator.Next(0, fieldSize.Width);
                int posY = generator.Next(0, fieldSize.Height);
                // TODO исправить

                if (map[posX, posY].plantBomb() && (posX != x) && (posY != y))
                {
                    plantCounter++;
                }
            }
        }

        private void CellInit(int i, int j)
        {
            map[i, j] = new Cell();
            map[i, j].Location = new Point(i * cellSize + spaceSize, j * cellSize + 5);
            map[i, j].Size = new Size(cellSize, cellSize);
            map[i, j].Text = "";
            map[i, j].Image = null;
            map[i, j].UseVisualStyleBackColor = true;
            map[i, j].Margin = new Padding(0);
            map[i, j].Padding = new Padding(0);
            map[i, j].FlatStyle = FlatStyle.Flat;
            map[i, j].BackColor = Color.Silver;
            map[i, j].MouseDown += new MouseEventHandler(CellButtonCLickHandler);
            map[i, j].x = i;
            map[i, j].y = j;
            // 
            // Form1
            // 

            //AutoScaleDimensions = new SizeF(7F, 15F);
            //AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(map[i, j]);
        }

        // Генерация кнопок
        private void GenerateButtons()
        {
            map = new Cell[fieldSize.Width, fieldSize.Height];

            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    CellInit(i, j);
                }
            }
            //PlantBombs();
            //BombCountInit();
        }

        private void CheckResult()
        {
            int bombsMarked = 0;
            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    if (map[i, j].hasBomb() && (map[i, j].flag == Cell.Flag.Marked))
                    {
                        bombsMarked++;
                    }
                }
            }
            if (bombsMarked == bombCount)
            {
                GameStatus = Status.Win;
                for (int i = 0; i < fieldSize.Width; i++)
                {
                    for (int j = 0; j < fieldSize.Height; j++)
                    {
                        map[i, j].BackColor = Color.Green;
                    }
                }
            }
        }
        // Конец игры
        // Отрисовка бомб
        private void GameOver(int x, int y)
        {
            for (int i = 0; i < fieldSize.Width; i++)
            {
                for (int j = 0; j < fieldSize.Height; j++)
                {
                    if (map[i, j].hasBomb())
                    {
                        map[i, j].Image = Properties.Resources.bomb;
                    }
                }
            }
            map[x, y].Image = Properties.Resources.nuclear_explosion;
            map[x, y].BackColor = Color.Red;
        }

        private Size fieldSize;             // Размер поля
        private Cell[,] map;                // Кнопки на поле
        private int spaceSize;              // Отступ начала поля
        private DifficultyLevel difficulty; // Уровень сложности
        private Status GameStatus;
        private bool IsFirstClick;
        private int bombCount;
       
    }
}
