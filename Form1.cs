using Rubik_s_Cube;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubik_s_Cube_Interface
{
    public partial class Form1 : Form
    {
        RubiksCube cube = new RubiksCube();

        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanelFront_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int slice = 0;
            int row = e.Row;
            int column = e.Column;

            ChangeCellColors(slice, row, column, "F", e);
        }

        private void TableLayoutPanelTop_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int slice = 2 - e.Row;
            int row = 0;
            int column = e.Column;

            ChangeCellColors(slice, row, column, "T", e);
        }

        private void TableLayoutPanelRight_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int slice = e.Column;
            int row = e.Row;
            int column = 2;

            ChangeCellColors(slice, row, column, "R", e);
        }

        private void TableLayoutPanelBack_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int slice = 2;
            int row = e.Row;
            int column = 2 - e.Column;

            ChangeCellColors(slice, row, column, "A", e);
        }

        private void TableLayoutPanelLeft_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int slice = 2 - e.Column;
            int row = e.Row;
            int column = 0;

            ChangeCellColors(slice, row, column, "L", e);
        }

        private void TableLayoutPanelBottom_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int slice = e.Row;
            int row = 2;
            int column = e.Column;

            ChangeCellColors(slice, row, column, "B", e);
        }

        private void ChangeCellColors(int slice, int row, int column, string direction, TableLayoutCellPaintEventArgs e)
        {
            if (cube.Cells[slice, row, column].FirstOrDefault(x => x.Value == direction).Key == "R")
                e.Graphics.FillRectangle(Brushes.IndianRed, e.CellBounds);
            else if (cube.Cells[slice, row, column].FirstOrDefault(x => x.Value == direction).Key == "W")
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            else if (cube.Cells[slice, row, column].FirstOrDefault(x => x.Value == direction).Key == "Y")
                e.Graphics.FillRectangle(Brushes.Gold, e.CellBounds);
            else if (cube.Cells[slice, row, column].FirstOrDefault(x => x.Value == direction).Key == "G")
                e.Graphics.FillRectangle(Brushes.YellowGreen, e.CellBounds);
            else if (cube.Cells[slice, row, column].FirstOrDefault(x => x.Value == direction).Key == "B")
                e.Graphics.FillRectangle(Brushes.DarkTurquoise, e.CellBounds);
            else if (cube.Cells[slice, row, column].FirstOrDefault(x => x.Value == direction).Key == "O")
                e.Graphics.FillRectangle(Brushes.SandyBrown, e.CellBounds);
        }

        private void ButtonUpRight_Click(object sender, EventArgs e)
        {
            cube.RotateSide("R", "U");
            RefreshAllCubeColors();
        }

        private void ButtonUpLeft_Click(object sender, EventArgs e)
        {
            cube.RotateSide("L", "U");
            RefreshAllCubeColors();
        }

        private void ButtonUpMid_Click(object sender, EventArgs e)
        {
            cube.RotateSide("M", "U");
            RefreshAllCubeColors();
        }

        private void ButtonDownLeft_Click(object sender, EventArgs e)
        {
            cube.RotateSide("L", "D");
            RefreshAllCubeColors();
        }

        private void ButtonDownMid_Click(object sender, EventArgs e)
        {
            cube.RotateSide("M", "D");
            RefreshAllCubeColors();
        }

        private void ButtonDownRight_Click(object sender, EventArgs e)
        {
            cube.RotateSide("R", "D");
            RefreshAllCubeColors();
        }

        private void ButtonLeftTop_Click(object sender, EventArgs e)
        {
            cube.RotateSide("T", "L");
            RefreshAllCubeColors();
        }

        private void ButtonLeftMid_Click(object sender, EventArgs e)
        {
            cube.RotateSide("M", "L");
            RefreshAllCubeColors();
        }

        private void ButtonLeftBottom_Click(object sender, EventArgs e)
        {
            cube.RotateSide("B", "L");
            RefreshAllCubeColors();
        }

        private void ButtonRightTop_Click(object sender, EventArgs e)
        {
            cube.RotateSide("T", "R");
            RefreshAllCubeColors();
        }

        private void ButtonRightMid_Click(object sender, EventArgs e)
        {
            cube.RotateSide("M", "R");
            RefreshAllCubeColors();
        }

        private void ButtonRightBottom_Click(object sender, EventArgs e)
        {
            cube.RotateSide("B", "R");
            RefreshAllCubeColors();
        }

        private void ButtonClockFront_Click(object sender, EventArgs e)
        {
            cube.RotateSide("F", "C");
            RefreshAllCubeColors();
        }

        private void ButtonAnticlockFront_Click(object sender, EventArgs e)
        {
            cube.RotateSide("F", "A");
            RefreshAllCubeColors();
        }

        private void ButtonClockMid_Click(object sender, EventArgs e)
        {
            cube.RotateSide("M", "C");
            RefreshAllCubeColors();
        }

        private void ButtonClockBack_Click(object sender, EventArgs e)
        {
            cube.RotateSide("A", "C");
            RefreshAllCubeColors();
        }

        private void ButtonAnticlockMid_Click(object sender, EventArgs e)
        {
            cube.RotateSide("M", "A");
            RefreshAllCubeColors();
        }

        private void ButtonAnticlockBack_Click(object sender, EventArgs e)
        {
            cube.RotateSide("A", "A");
            RefreshAllCubeColors();
        }

        private void RefreshAllCubeColors()
        {
            this.tableLayoutPanelFront.CellPaint += new TableLayoutCellPaintEventHandler(TableLayoutPanelFront_CellPaint);
            this.tableLayoutPanelTop.CellPaint += new TableLayoutCellPaintEventHandler(TableLayoutPanelTop_CellPaint);
            this.tableLayoutPanelRight.CellPaint += new TableLayoutCellPaintEventHandler(TableLayoutPanelRight_CellPaint);
            this.tableLayoutPanelBack.CellPaint += new TableLayoutCellPaintEventHandler(TableLayoutPanelBack_CellPaint);
            this.tableLayoutPanelBottom.CellPaint += new TableLayoutCellPaintEventHandler(TableLayoutPanelBottom_CellPaint);
            this.tableLayoutPanelLeft.CellPaint += new TableLayoutCellPaintEventHandler(TableLayoutPanelLeft_CellPaint);
            tableLayoutPanelFront.Refresh();
            tableLayoutPanelTop.Refresh();
            tableLayoutPanelRight.Refresh();
            tableLayoutPanelBack.Refresh();
            tableLayoutPanelBottom.Refresh();
            tableLayoutPanelLeft.Refresh();
        }
    }
}
