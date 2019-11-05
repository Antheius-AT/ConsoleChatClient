using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuAdministrator
    {
        private int activeIndex;

        public MenuAdministrator(List<ExecutableMenuOption> options)
        {
            this.MenuOptions = options;
            this.ActiveIndex = 0;
        }

        public List<ExecutableMenuOption> MenuOptions
        {
            get;
            private set;
        }

        public int ActiveIndex
        {
            get
            {
                return this.activeIndex;
            }
            set
            {
                if (value > 0 || value > this.MenuOptions.Count - 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Value was out of range. A valid value must be between 0 and {this.MenuOptions.Count - 1}");
                }

                this.activeIndex = value;
            }
        }
    }
}