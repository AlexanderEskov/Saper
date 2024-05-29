using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class Cell : Button
    {
        public enum Flag
        {
            None = 0,
            Marked = 1,
            Unknown = 2
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
            throw new NotImplementedException();
        }

        public Content content;
        public Flag flag;
        public int BombsAround;
    }
}
