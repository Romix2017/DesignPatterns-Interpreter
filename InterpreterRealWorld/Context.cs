﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterRealWorld
{
    public class Context
    {
        private string input;
        private int output;
        public Context(string input)
        {
            this.input = input;
        }
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        public int Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
