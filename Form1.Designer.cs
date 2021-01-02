namespace Rubik_s_Cube_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelFront = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDownMid = new System.Windows.Forms.Button();
            this.buttonDownRight = new System.Windows.Forms.Button();
            this.buttonClockFront = new System.Windows.Forms.Button();
            this.buttonAnticlockFront = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBack = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClockMid = new System.Windows.Forms.Button();
            this.buttonClockBack = new System.Windows.Forms.Button();
            this.buttonAnticlockMid = new System.Windows.Forms.Button();
            this.buttonAnticlockBack = new System.Windows.Forms.Button();
            this.buttonLeftBottom = new System.Windows.Forms.Button();
            this.buttonLeftMid = new System.Windows.Forms.Button();
            this.buttonLeftTop = new System.Windows.Forms.Button();
            this.buttonRightBottom = new System.Windows.Forms.Button();
            this.buttonRightMid = new System.Windows.Forms.Button();
            this.buttonRightTop = new System.Windows.Forms.Button();
            this.buttonDownLeft = new System.Windows.Forms.Button();
            this.buttonUpLeft = new System.Windows.Forms.Button();
            this.buttonUpMid = new System.Windows.Forms.Button();
            this.buttonUpRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFront
            // 
            this.tableLayoutPanelFront.BackColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanelFront.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelFront.ColumnCount = 3;
            this.tableLayoutPanelFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFront.Location = new System.Drawing.Point(220, 220);
            this.tableLayoutPanelFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelFront.Name = "tableLayoutPanelFront";
            this.tableLayoutPanelFront.RowCount = 3;
            this.tableLayoutPanelFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFront.Size = new System.Drawing.Size(133, 130);
            this.tableLayoutPanelFront.TabIndex = 0;
            this.tableLayoutPanelFront.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanelFront_CellPaint);
            // 
            // buttonDownMid
            // 
            this.buttonDownMid.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.down;
            this.buttonDownMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDownMid.Location = new System.Drawing.Point(277, 485);
            this.buttonDownMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownMid.Name = "buttonDownMid";
            this.buttonDownMid.Size = new System.Drawing.Size(20, 45);
            this.buttonDownMid.TabIndex = 5;
            this.buttonDownMid.UseVisualStyleBackColor = true;
            this.buttonDownMid.Click += new System.EventHandler(this.ButtonDownMid_Click);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.down;
            this.buttonDownRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDownRight.Location = new System.Drawing.Point(320, 485);
            this.buttonDownRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(20, 45);
            this.buttonDownRight.TabIndex = 6;
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.ButtonDownRight_Click);
            // 
            // buttonClockFront
            // 
            this.buttonClockFront.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.down;
            this.buttonClockFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClockFront.Location = new System.Drawing.Point(366, 354);
            this.buttonClockFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClockFront.Name = "buttonClockFront";
            this.buttonClockFront.Size = new System.Drawing.Size(20, 45);
            this.buttonClockFront.TabIndex = 13;
            this.buttonClockFront.UseVisualStyleBackColor = true;
            this.buttonClockFront.Click += new System.EventHandler(this.ButtonClockFront_Click);
            // 
            // buttonAnticlockFront
            // 
            this.buttonAnticlockFront.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.up;
            this.buttonAnticlockFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnticlockFront.Location = new System.Drawing.Point(366, 170);
            this.buttonAnticlockFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnticlockFront.Name = "buttonAnticlockFront";
            this.buttonAnticlockFront.Size = new System.Drawing.Size(20, 45);
            this.buttonAnticlockFront.TabIndex = 14;
            this.buttonAnticlockFront.UseVisualStyleBackColor = true;
            this.buttonAnticlockFront.Click += new System.EventHandler(this.ButtonAnticlockFront_Click);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanelTop.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(220, 89);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 3;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(133, 130);
            this.tableLayoutPanelTop.TabIndex = 15;
            this.tableLayoutPanelTop.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanelTop_CellPaint);
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.BackColor = System.Drawing.Color.YellowGreen;
            this.tableLayoutPanelRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelRight.ColumnCount = 3;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(354, 220);
            this.tableLayoutPanelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 3;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(133, 130);
            this.tableLayoutPanelRight.TabIndex = 16;
            this.tableLayoutPanelRight.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanelRight_CellPaint);
            // 
            // tableLayoutPanelBack
            // 
            this.tableLayoutPanelBack.BackColor = System.Drawing.Color.SandyBrown;
            this.tableLayoutPanelBack.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelBack.ColumnCount = 3;
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.Location = new System.Drawing.Point(488, 220);
            this.tableLayoutPanelBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelBack.Name = "tableLayoutPanelBack";
            this.tableLayoutPanelBack.RowCount = 3;
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBack.Size = new System.Drawing.Size(133, 130);
            this.tableLayoutPanelBack.TabIndex = 17;
            this.tableLayoutPanelBack.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanelBack_CellPaint);
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanelLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLeft.ColumnCount = 3;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(86, 220);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 3;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(133, 130);
            this.tableLayoutPanelLeft.TabIndex = 18;
            this.tableLayoutPanelLeft.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanelLeft_CellPaint);
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelBottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelBottom.ColumnCount = 3;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(220, 351);
            this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 3;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(133, 130);
            this.tableLayoutPanelBottom.TabIndex = 18;
            this.tableLayoutPanelBottom.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanelBottom_CellPaint);
            // 
            // buttonClockMid
            // 
            this.buttonClockMid.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.down;
            this.buttonClockMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClockMid.Location = new System.Drawing.Point(410, 354);
            this.buttonClockMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClockMid.Name = "buttonClockMid";
            this.buttonClockMid.Size = new System.Drawing.Size(20, 45);
            this.buttonClockMid.TabIndex = 19;
            this.buttonClockMid.UseVisualStyleBackColor = true;
            this.buttonClockMid.Click += new System.EventHandler(this.ButtonClockMid_Click);
            // 
            // buttonClockBack
            // 
            this.buttonClockBack.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.down;
            this.buttonClockBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClockBack.Location = new System.Drawing.Point(454, 354);
            this.buttonClockBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClockBack.Name = "buttonClockBack";
            this.buttonClockBack.Size = new System.Drawing.Size(20, 45);
            this.buttonClockBack.TabIndex = 20;
            this.buttonClockBack.UseVisualStyleBackColor = true;
            this.buttonClockBack.Click += new System.EventHandler(this.ButtonClockBack_Click);
            // 
            // buttonAnticlockMid
            // 
            this.buttonAnticlockMid.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.up;
            this.buttonAnticlockMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnticlockMid.Location = new System.Drawing.Point(410, 170);
            this.buttonAnticlockMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnticlockMid.Name = "buttonAnticlockMid";
            this.buttonAnticlockMid.Size = new System.Drawing.Size(20, 45);
            this.buttonAnticlockMid.TabIndex = 21;
            this.buttonAnticlockMid.UseVisualStyleBackColor = true;
            this.buttonAnticlockMid.Click += new System.EventHandler(this.ButtonAnticlockMid_Click);
            // 
            // buttonAnticlockBack
            // 
            this.buttonAnticlockBack.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.up;
            this.buttonAnticlockBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnticlockBack.Location = new System.Drawing.Point(454, 170);
            this.buttonAnticlockBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnticlockBack.Name = "buttonAnticlockBack";
            this.buttonAnticlockBack.Size = new System.Drawing.Size(20, 45);
            this.buttonAnticlockBack.TabIndex = 22;
            this.buttonAnticlockBack.UseVisualStyleBackColor = true;
            this.buttonAnticlockBack.Click += new System.EventHandler(this.ButtonAnticlockBack_Click);
            // 
            // buttonLeftBottom
            // 
            this.buttonLeftBottom.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.left;
            this.buttonLeftBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeftBottom.Location = new System.Drawing.Point(35, 318);
            this.buttonLeftBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeftBottom.Name = "buttonLeftBottom";
            this.buttonLeftBottom.Size = new System.Drawing.Size(45, 20);
            this.buttonLeftBottom.TabIndex = 12;
            this.buttonLeftBottom.UseVisualStyleBackColor = true;
            this.buttonLeftBottom.Click += new System.EventHandler(this.ButtonLeftBottom_Click);
            // 
            // buttonLeftMid
            // 
            this.buttonLeftMid.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.left;
            this.buttonLeftMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeftMid.Location = new System.Drawing.Point(35, 276);
            this.buttonLeftMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeftMid.Name = "buttonLeftMid";
            this.buttonLeftMid.Size = new System.Drawing.Size(45, 20);
            this.buttonLeftMid.TabIndex = 11;
            this.buttonLeftMid.UseVisualStyleBackColor = true;
            this.buttonLeftMid.Click += new System.EventHandler(this.ButtonLeftMid_Click);
            // 
            // buttonLeftTop
            // 
            this.buttonLeftTop.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.left;
            this.buttonLeftTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeftTop.Location = new System.Drawing.Point(35, 235);
            this.buttonLeftTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeftTop.Name = "buttonLeftTop";
            this.buttonLeftTop.Size = new System.Drawing.Size(45, 20);
            this.buttonLeftTop.TabIndex = 10;
            this.buttonLeftTop.UseVisualStyleBackColor = true;
            this.buttonLeftTop.Click += new System.EventHandler(this.ButtonLeftTop_Click);
            // 
            // buttonRightBottom
            // 
            this.buttonRightBottom.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.right;
            this.buttonRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRightBottom.Location = new System.Drawing.Point(625, 318);
            this.buttonRightBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRightBottom.Name = "buttonRightBottom";
            this.buttonRightBottom.Size = new System.Drawing.Size(45, 20);
            this.buttonRightBottom.TabIndex = 9;
            this.buttonRightBottom.UseVisualStyleBackColor = true;
            this.buttonRightBottom.Click += new System.EventHandler(this.ButtonRightBottom_Click);
            // 
            // buttonRightMid
            // 
            this.buttonRightMid.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.right;
            this.buttonRightMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRightMid.Location = new System.Drawing.Point(625, 276);
            this.buttonRightMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRightMid.Name = "buttonRightMid";
            this.buttonRightMid.Size = new System.Drawing.Size(45, 20);
            this.buttonRightMid.TabIndex = 8;
            this.buttonRightMid.UseVisualStyleBackColor = true;
            this.buttonRightMid.Click += new System.EventHandler(this.ButtonRightMid_Click);
            // 
            // buttonRightTop
            // 
            this.buttonRightTop.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.right;
            this.buttonRightTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRightTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRightTop.Location = new System.Drawing.Point(625, 235);
            this.buttonRightTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRightTop.Name = "buttonRightTop";
            this.buttonRightTop.Size = new System.Drawing.Size(45, 20);
            this.buttonRightTop.TabIndex = 7;
            this.buttonRightTop.UseVisualStyleBackColor = true;
            this.buttonRightTop.Click += new System.EventHandler(this.ButtonRightTop_Click);
            // 
            // buttonDownLeft
            // 
            this.buttonDownLeft.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.down;
            this.buttonDownLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDownLeft.Location = new System.Drawing.Point(232, 485);
            this.buttonDownLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownLeft.Name = "buttonDownLeft";
            this.buttonDownLeft.Size = new System.Drawing.Size(20, 45);
            this.buttonDownLeft.TabIndex = 4;
            this.buttonDownLeft.UseVisualStyleBackColor = true;
            this.buttonDownLeft.Click += new System.EventHandler(this.ButtonDownLeft_Click);
            // 
            // buttonUpLeft
            // 
            this.buttonUpLeft.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.up;
            this.buttonUpLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpLeft.Location = new System.Drawing.Point(232, 40);
            this.buttonUpLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpLeft.Name = "buttonUpLeft";
            this.buttonUpLeft.Size = new System.Drawing.Size(20, 45);
            this.buttonUpLeft.TabIndex = 3;
            this.buttonUpLeft.UseVisualStyleBackColor = true;
            this.buttonUpLeft.Click += new System.EventHandler(this.ButtonUpLeft_Click);
            // 
            // buttonUpMid
            // 
            this.buttonUpMid.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.up;
            this.buttonUpMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpMid.Location = new System.Drawing.Point(277, 40);
            this.buttonUpMid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpMid.Name = "buttonUpMid";
            this.buttonUpMid.Size = new System.Drawing.Size(20, 45);
            this.buttonUpMid.TabIndex = 2;
            this.buttonUpMid.UseVisualStyleBackColor = true;
            this.buttonUpMid.Click += new System.EventHandler(this.ButtonUpMid_Click);
            // 
            // buttonUpRight
            // 
            this.buttonUpRight.BackgroundImage = global::Rubik_s_Cube_Interface.Properties.Resources.up;
            this.buttonUpRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpRight.Location = new System.Drawing.Point(320, 40);
            this.buttonUpRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(20, 45);
            this.buttonUpRight.TabIndex = 1;
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.ButtonUpRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(707, 558);
            this.Controls.Add(this.tableLayoutPanelFront);
            this.Controls.Add(this.buttonAnticlockBack);
            this.Controls.Add(this.buttonAnticlockMid);
            this.Controls.Add(this.buttonClockBack);
            this.Controls.Add(this.buttonClockMid);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelLeft);
            this.Controls.Add(this.tableLayoutPanelRight);
            this.Controls.Add(this.tableLayoutPanelBack);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Controls.Add(this.buttonAnticlockFront);
            this.Controls.Add(this.buttonClockFront);
            this.Controls.Add(this.buttonLeftBottom);
            this.Controls.Add(this.buttonLeftMid);
            this.Controls.Add(this.buttonLeftTop);
            this.Controls.Add(this.buttonRightBottom);
            this.Controls.Add(this.buttonRightMid);
            this.Controls.Add(this.buttonRightTop);
            this.Controls.Add(this.buttonDownRight);
            this.Controls.Add(this.buttonDownMid);
            this.Controls.Add(this.buttonDownLeft);
            this.Controls.Add(this.buttonUpLeft);
            this.Controls.Add(this.buttonUpMid);
            this.Controls.Add(this.buttonUpRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(723, 597);
            this.MinimumSize = new System.Drawing.Size(723, 597);
            this.Name = "Form1";
            this.Text = "Rubik\'s Cube";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFront;
        private System.Windows.Forms.Button buttonUpRight;
        private System.Windows.Forms.Button buttonUpMid;
        private System.Windows.Forms.Button buttonUpLeft;
        private System.Windows.Forms.Button buttonDownLeft;
        private System.Windows.Forms.Button buttonDownMid;
        private System.Windows.Forms.Button buttonDownRight;
        private System.Windows.Forms.Button buttonRightTop;
        private System.Windows.Forms.Button buttonRightMid;
        private System.Windows.Forms.Button buttonRightBottom;
        private System.Windows.Forms.Button buttonLeftTop;
        private System.Windows.Forms.Button buttonLeftMid;
        private System.Windows.Forms.Button buttonLeftBottom;
        private System.Windows.Forms.Button buttonClockFront;
        private System.Windows.Forms.Button buttonAnticlockFront;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Button buttonClockMid;
        private System.Windows.Forms.Button buttonClockBack;
        private System.Windows.Forms.Button buttonAnticlockMid;
        private System.Windows.Forms.Button buttonAnticlockBack;
    }
}

