﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snakes
{
    public class Field : IField
    {
        private ISnake _snake;

        public ISnake Snake()
        {
            return _snake;
        }
    }
}
