﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardville.Dungeon.WFViewController
{
    public partial class GameLevelForm : Form
    {
        public GameLevelForm()
        {
            InitializeComponent();
            Game game = new Game();
            DungeonPainter dungeonPainter = new DungeonPainter(game, this);
            this.Controls.Add(dungeonPainter.GetControl());
        }
    }
}
