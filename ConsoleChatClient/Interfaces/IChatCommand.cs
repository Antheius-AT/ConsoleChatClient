using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    /// <summary>
    /// This is the <see cref="IChatCommand"/> interface.
    /// This interface is used to carry over executable commands across the network.
    /// </summary>
    public interface IChatCommand
    {
        /// <summary>
        /// This method is used to invoke the specific command.
        /// </summary>
        /// <param name="commandParameter">A command parameter holding additional information that may be needed to execute the command.</param>
        void Execute(object commandParameter);
    }
}