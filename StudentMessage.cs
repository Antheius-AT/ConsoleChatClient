using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge
{
    public class StudentMessage
    {
        private string name;
        private string message;

        public StudentMessage(string name, string message)
        {
            this.Name = name;
            this.Message = message;
        }

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value ?? throw new ArgumentNullException(nameof(value), "MEssage must not be null.");
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value ?? throw new ArgumentNullException(nameof(value), "Name must not be null.");
            }
        }
    }
}
