using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuAdministrator
    {
        private int previousIndex;
        private int activeIndex;

        public MenuAdministrator(List<ExecutableMenuOption> options)
        {
            this.Menu = new Menu(options);
            this.ActiveIndex = 0;
            this.PreviousIndex = this.ActiveIndex + 1;
        }

        public int ActiveIndex
        {
            get
            {
                return this.activeIndex;
            }
            set
            {
                if (value < 0 || value > this.Menu.Entries.Count - 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Value was out of range. A valid value must be between 0 and {this.Menu.Entries.Count - 1}");
                }

                this.PreviousIndex = this.activeIndex;
                this.activeIndex = value;
            }
        }

        public int PreviousIndex
        {
            get
            {
                return this.previousIndex;
            }
            private set
            {
                if (value < 0 || value > this.Menu.Entries.Count - 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Value was out of range. A valid value must be between 0 and {this.Menu.Entries.Count - 1}");
                }

                this.previousIndex = value;
            }
        }

        public Menu Menu
        {
            get;
            private set;
        }
    }
}