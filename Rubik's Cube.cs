using System;
using System.Collections.Generic;
using System.Linq;

namespace Rubik_s_Cube
{
    class RubiksCube
    {
        private Dictionary<string, string>[,,] cells = new Dictionary<string, string>[,,] { { { new Dictionary<string, string>{ { "Y", "T" }, { "R", "F" }, { "B", "L" } }, new Dictionary<string, string>{ { "Y", "T" }, { "R", "F" }, { "N", "N" } }, new Dictionary<string, string>{ { "Y", "T" }, { "R", "F" }, { "G", "R" } } },
                                                                                              { new Dictionary<string, string>{ { "N", "N" }, { "R", "F" }, { "B", "L" } }, new Dictionary<string, string>{ { "N", "N" }, { "R", "F" }, { "M", "N" } }, new Dictionary<string, string>{ { "N", "N" }, { "R", "F" }, { "G", "R" } } },
                                                                                              { new Dictionary<string, string>{ { "W", "B" }, { "R", "F" }, { "B", "L" } }, new Dictionary<string, string>{ { "W", "B" }, { "R", "F" }, { "N", "N" } }, new Dictionary<string, string>{ { "W", "B" }, { "R", "F" }, { "G", "R" } } } },
                                                                                              { { new Dictionary<string, string>{ { "Y", "T" }, { "N", "N" }, { "B", "L" } }, new Dictionary<string, string>{ { "Y", "T" }, { "N", "N" }, { "M", "N" } }, new Dictionary<string, string>{ { "Y", "T" }, { "N", "N" }, { "G", "R" } } },
                                                                                                { new Dictionary<string, string>{ { "N", "N" }, { "M", "N" }, { "B", "L" } }, new Dictionary<string, string>{ { "N", "N" }, { "M", "N" }, { "K", "N" } }, new Dictionary<string, string>{ { "N", "N" }, { "M", "N" }, { "G", "R" } } },
                                                                                                { new Dictionary<string, string>{ { "W", "B" }, { "N", "N" }, { "B", "L" } }, new Dictionary<string, string>{ { "W", "B" }, { "N", "N" }, { "M", "N" } }, new Dictionary<string, string>{ { "W", "B" }, { "N", "N" }, { "G", "R" } } } },
                                                                                                { { new Dictionary<string, string>{ { "Y", "T" }, { "O", "A" }, { "B", "L" } }, new Dictionary<string, string>{ { "Y", "T" }, { "O", "A" }, { "N", "N" } }, new Dictionary<string, string>{ { "Y", "T" }, { "O", "A" }, { "G", "R" } } },
                                                                                                  { new Dictionary<string, string>{ { "N", "N" }, { "O", "A" }, { "B", "L" } }, new Dictionary<string, string>{ { "N", "N" }, { "O", "A" }, { "M", "N" } }, new Dictionary<string, string>{ { "N", "N" }, { "O", "A" }, { "G", "R" } } },
                                                                                                  { new Dictionary<string, string>{ { "W", "B" }, { "O", "A" }, { "B", "L" } }, new Dictionary<string, string>{ { "W", "B" }, { "O", "A" }, { "N", "N" } }, new Dictionary<string, string>{ { "W", "B" }, { "O", "A" }, { "G", "R" } } } } };

        public Dictionary<string, string>[,,] Cells
        {
            get
            {
                return cells;
            }
        }

        public void ChangeCellPositionVertical(string side, string direction)
        {
            Dictionary<string, string>[,,] cellsBeforeRotation = new Dictionary<string, string>[3, 3, 3];
            Array.Copy(cells, 0, cellsBeforeRotation, 0, 27);

            int cell = -1;
            int replaceCell = -1;

            if (side == "R")
            {
                cell = 2;
                replaceCell = 2;
            }
            else if (side == "L")
            {
                cell = 0;
                replaceCell = 0;
            }
            else if (side == "M")
            {
                cell = 1;
                replaceCell = 1;
            }

            if (direction == "U")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int row = 0; row < 3; row++)
                    {
                        int replaceSlice = row;
                        int replaceRow = -1;

                        if (slice == 0)
                            replaceRow = 2;
                        else if (slice == 1)
                            replaceRow = 1;
                        else if (slice == 2)
                            replaceRow = 0;

                        this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                    }

                }
            }
            else if (direction == "D")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int row = 0; row < 3; row++)
                    {
                        int replaceSlice = Math.Abs(2 - row);
                        int replaceRow = -1;

                        if (slice == 0)
                            replaceRow = 0;
                        else if (slice == 1)
                            replaceRow = 1;
                        else if (slice == 2)
                            replaceRow = 2;

                        this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                    }
                }
            }
        }

        public void ChangeColorOrientationVertical(string side, string direction)
        {
            int cell = -1;

            if (side == "R")
                cell = 2;
            else if (side == "L")
                cell = 0;
            else if (side == "M")
                cell = 1;

            if (direction == "U")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int row = 0; row < 3; row++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string key = this.cells[slice, row, cell].ElementAt(i).Key;

                            if (cells[slice, row, cell][key] == "F")
                                cells[slice, row, cell][key] = "T";
                            else if (cells[slice, row, cell][key] == "A")
                                cells[slice, row, cell][key] = "B";
                            else if (cells[slice, row, cell][key] == "T")
                                cells[slice, row, cell][key] = "A";
                            else if (cells[slice, row, cell][key] == "B")
                                cells[slice, row, cell][key] = "F";
                        }
                    }
                }
            }
            else if (direction == "D")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int row = 0; row < 3; row++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string key = this.cells[slice, row, cell].ElementAt(i).Key;

                            if (cells[slice, row, cell][key] == "F")
                                cells[slice, row, cell][key] = "B";
                            else if (cells[slice, row, cell][key] == "A")
                                cells[slice, row, cell][key] = "T";
                            else if (cells[slice, row, cell][key] == "T")
                                cells[slice, row, cell][key] = "F";
                            else if (cells[slice, row, cell][key] == "B")
                                cells[slice, row, cell][key] = "A";
                        }
                    }
                }
            }
        }

        public void ChangeCellPositionHorizontal(string side, string direction)
        {
            Dictionary<string, string>[,,] cellsBeforeRotation = new Dictionary<string, string>[3, 3, 3];
            Array.Copy(cells, 0, cellsBeforeRotation, 0, 27);

            int row = -1;
            int replaceRow = -1;

            if (side == "T")
            {
                row = 0;
                replaceRow = 0;
            }
            else if (side == "B")
            {
                row = 2;
                replaceRow = 2;
            }
            else if (side == "M")
            {
                row = 1;
                replaceRow = 1;
            }

            if (direction == "R")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        int replaceSlice = Math.Abs(2 - cell);
                        int replaceCell = -1;

                        if (slice == 0)
                            replaceCell = 0;
                        else if (slice == 1)
                            replaceCell = 1;
                        else if (slice == 2)
                            replaceCell = 2;

                        this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                    }

                }
            }
            else if (direction == "L")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        int replaceSlice = cell;
                        int replaceCell = -1;

                        if (slice == 0)
                            replaceCell = 2;
                        else if (slice == 1)
                            replaceCell = 1;
                        else if (slice == 2)
                            replaceCell = 0;

                        this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                    }

                }
            }
        }

        public void ChangeColorOrientationHorizontal(string side, string direction)
        {
            int row = -1;

            if (side == "T")
                row = 0;
            else if (side == "B")
                row = 2;
            else if (side == "M")
                row = 1;

            if (direction == "R")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string key = this.cells[slice, row, cell].ElementAt(i).Key;

                            if (cells[slice, row, cell][key] == "F")
                                cells[slice, row, cell][key] = "R";
                            else if (cells[slice, row, cell][key] == "A")
                                cells[slice, row, cell][key] = "L";
                            else if (cells[slice, row, cell][key] == "R")
                                cells[slice, row, cell][key] = "A";
                            else if (cells[slice, row, cell][key] == "L")
                                cells[slice, row, cell][key] = "F";
                        }
                    }
                }
            }
            else if (direction == "L")
            {
                for (int slice = 0; slice < 3; slice++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string key = this.cells[slice, row, cell].ElementAt(i).Key;

                            if (cells[slice, row, cell][key] == "F")
                                cells[slice, row, cell][key] = "L";
                            else if (cells[slice, row, cell][key] == "A")
                                cells[slice, row, cell][key] = "R";
                            else if (cells[slice, row, cell][key] == "R")
                                cells[slice, row, cell][key] = "F";
                            else if (cells[slice, row, cell][key] == "L")
                                cells[slice, row, cell][key] = "A";
                        }
                    }
                }
            }
        }

        public void ChangeCellPositionClock(string side, string direction)
        {
            Dictionary<string, string>[,,] cellsBeforeRotation = new Dictionary<string, string>[3, 3, 3];
            Array.Copy(cells, 0, cellsBeforeRotation, 0, 27);

            int slice = -1;
            int replaceSlice = -1;

            if (side == "F")
            {
                slice = 0;
                replaceSlice = 0;
            }
            else if (side == "A")
            {
                slice = 2;
                replaceSlice = 2;
            }
            else if (side == "M")
            {
                slice = 1;
                replaceSlice = 1;
            }

            if (direction == "C")
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        int replaceRow = Math.Abs(2 - cell);

                        if (row == 0)
                        {
                            int replaceCell = 0;

                            this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                        }
                        else if (row == 1)
                        {
                            int replaceCell = 1;

                            this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                        }
                        else if (row == 2)
                        {
                            int replaceCell = 2;

                            this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                        }
                    }

                }
            }
            else if (direction == "A")
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        int replaceRow = cell;

                        if (row == 0)
                        {
                            int replaceCell = 2;

                            this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                        }
                        else if (row == 1)
                        {
                            int replaceCell = 1;

                            this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                        }
                        else if (row == 2)
                        {
                            int replaceCell = 0;

                            this.cells[slice, row, cell] = cellsBeforeRotation[replaceSlice, replaceRow, replaceCell];
                        }
                    }

                }
            }
        }

        public void ChangeColorOrientationClock(string side, string direction)
        {
            int slice = -1;

            if (side == "F")
                slice = 0;
            else if (side == "A")
                slice = 2;
            else if (side == "M")
                slice = 1;

            if (direction == "C")
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string key = this.cells[slice, row, cell].ElementAt(i).Key;

                            if (cells[slice, row, cell][key] == "T")
                                cells[slice, row, cell][key] = "R";
                            else if (cells[slice, row, cell][key] == "B")
                                cells[slice, row, cell][key] = "L";
                            else if (cells[slice, row, cell][key] == "R")
                                cells[slice, row, cell][key] = "B";
                            else if (cells[slice, row, cell][key] == "L")
                                cells[slice, row, cell][key] = "T";
                        }
                    }
                }
            }
            else if (direction == "A")
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string key = this.cells[slice, row, cell].ElementAt(i).Key;

                            if (cells[slice, row, cell][key] == "T")
                                cells[slice, row, cell][key] = "L";
                            else if (cells[slice, row, cell][key] == "B")
                                cells[slice, row, cell][key] = "R";
                            else if (cells[slice, row, cell][key] == "R")
                                cells[slice, row, cell][key] = "T";
                            else if (cells[slice, row, cell][key] == "L")
                                cells[slice, row, cell][key] = "B";
                        }
                    }
                }
            }
        }

        public void RotateSide(string side, string direction)
        {
            if (direction == "U" || direction == "D")
            {
                ChangeCellPositionVertical(side, direction);
                ChangeColorOrientationVertical(side, direction);
            }
            else if (direction == "R" || direction == "L")
            {
                ChangeCellPositionHorizontal(side, direction);
                ChangeColorOrientationHorizontal(side, direction);
            }
            else if (direction == "C" || direction == "A")
            {
                ChangeCellPositionClock(side, direction);
                ChangeColorOrientationClock(side, direction);
            }
        }
    }
}
