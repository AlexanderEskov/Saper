using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class Cell : Button
    {
        public enum Flag
        {
            None,
            Marked,
            Unknown
        }

        public enum Content
        {
            Empty,
            Bomb
        }
        public Cell()
        {
            content = Content.Empty;
            flag = Flag.None;
        }

        // Переключает флаг ячейки по правой кнопке мыши
        public void ToggleFlag()
        {
            if (this.flag == Flag.None)
            {
                this.flag = Flag.Marked;
                this.Image = Properties.Resources.flag;
            }
            else if (this.flag == Flag.Marked)
            {
                this.flag = Flag.Unknown;
                this.Image = Properties.Resources.question;
            }
            else if (this.flag == Flag.Unknown)
            {
                this.flag = Flag.None;
                this.Image = null;
            }
        }

        // True, если в ячейке есть бомба
        public bool hasBomb()
        {
            if(this.content == Content.Bomb)
            {
                return true;
            }
            return false;
        }

        internal bool empty()
        {
            return !this.hasBomb();
        }

        public bool plantBomb()
        {
            if (empty())
            {
                this.content = Content.Bomb;
                return true;
            }
            return false;
        }

        public void setBombsAround(int count)
        {
            this.BombsAround = count;
        }

        public Content content;     // Реальное содержимое ячейки (Есть бомба или нет)
        public Flag flag;           // Метка установленная игроком ("Пусто", "Флаг", или "Неизвестно")
        public int BombsAround;     // Количество бомб вокруг
        public int x;               // Координата ячейки X
        public int y;               // Координата ячейки Y
        public bool visited;        // Признак посещения клетки за ход
    }
}
