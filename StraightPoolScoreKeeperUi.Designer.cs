namespace StraightPoolScoreKeeper
{
    partial class StraightPoolScoreKeeperUi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StraightPoolScoreKeeperUi));
            this.gbxPlayer1 = new System.Windows.Forms.GroupBox();
            this.btnPlayer1Reset = new System.Windows.Forms.Button();
            this.gbxPlayer1Statistics = new System.Windows.Forms.GroupBox();
            this.chtPlayer1AveragesScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgPlayer1CurrentScores = new System.Windows.Forms.DataGridView();
            this.AttemptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPlayer1BallsPerInning = new System.Windows.Forms.Label();
            this.lblPlayer1TotalCount = new System.Windows.Forms.Label();
            this.txtPlayer1TotalCount = new System.Windows.Forms.TextBox();
            this.txtPlayer1BallsPerInning = new System.Windows.Forms.TextBox();
            this.btnPlayer1EndInning = new System.Windows.Forms.Button();
            this.lblPlayer1CurrentInningCount = new System.Windows.Forms.Label();
            this.numPlayer1CurrentInningCount = new System.Windows.Forms.NumericUpDown();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.gbxPlayer2 = new System.Windows.Forms.GroupBox();
            this.btnPlayer2Reset = new System.Windows.Forms.Button();
            this.gbxPlayer2Statistics = new System.Windows.Forms.GroupBox();
            this.chtPlayer2AveragesScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgPlayer2CurrentScores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPlayer2BallsPerInning = new System.Windows.Forms.Label();
            this.lblPlayer2TotalCount = new System.Windows.Forms.Label();
            this.txtPlayer2TotalCount = new System.Windows.Forms.TextBox();
            this.txtPlayer2BallsPerInning = new System.Windows.Forms.TextBox();
            this.btnPlayer2EndInning = new System.Windows.Forms.Button();
            this.lblPlayer2CurrentInningCount = new System.Windows.Forms.Label();
            this.numPlayer2CurrentInningCount = new System.Windows.Forms.NumericUpDown();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.gbxPlayer1.SuspendLayout();
            this.gbxPlayer1Statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPlayer1AveragesScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayer1CurrentScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer1CurrentInningCount)).BeginInit();
            this.gbxPlayer2.SuspendLayout();
            this.gbxPlayer2Statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPlayer2AveragesScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayer2CurrentScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer2CurrentInningCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPlayer1
            // 
            this.gbxPlayer1.Controls.Add(this.btnPlayer1Reset);
            this.gbxPlayer1.Controls.Add(this.gbxPlayer1Statistics);
            this.gbxPlayer1.Controls.Add(this.btnPlayer1EndInning);
            this.gbxPlayer1.Controls.Add(this.lblPlayer1CurrentInningCount);
            this.gbxPlayer1.Controls.Add(this.numPlayer1CurrentInningCount);
            this.gbxPlayer1.Controls.Add(this.txtPlayer1Name);
            this.gbxPlayer1.Controls.Add(this.lblPlayer1Name);
            this.gbxPlayer1.Location = new System.Drawing.Point(12, 12);
            this.gbxPlayer1.Name = "gbxPlayer1";
            this.gbxPlayer1.Size = new System.Drawing.Size(362, 539);
            this.gbxPlayer1.TabIndex = 0;
            this.gbxPlayer1.TabStop = false;
            this.gbxPlayer1.Text = "Player 1";
            // 
            // btnPlayer1Reset
            // 
            this.btnPlayer1Reset.Location = new System.Drawing.Point(9, 507);
            this.btnPlayer1Reset.Name = "btnPlayer1Reset";
            this.btnPlayer1Reset.Size = new System.Drawing.Size(347, 23);
            this.btnPlayer1Reset.TabIndex = 10;
            this.btnPlayer1Reset.Text = "Reset";
            this.btnPlayer1Reset.UseVisualStyleBackColor = true;
            this.btnPlayer1Reset.Click += new System.EventHandler(this.BtnPlayerResetClick);
            // 
            // gbxPlayer1Statistics
            // 
            this.gbxPlayer1Statistics.Controls.Add(this.chtPlayer1AveragesScores);
            this.gbxPlayer1Statistics.Controls.Add(this.dgPlayer1CurrentScores);
            this.gbxPlayer1Statistics.Controls.Add(this.lblPlayer1BallsPerInning);
            this.gbxPlayer1Statistics.Controls.Add(this.lblPlayer1TotalCount);
            this.gbxPlayer1Statistics.Controls.Add(this.txtPlayer1TotalCount);
            this.gbxPlayer1Statistics.Controls.Add(this.txtPlayer1BallsPerInning);
            this.gbxPlayer1Statistics.Location = new System.Drawing.Point(9, 151);
            this.gbxPlayer1Statistics.Name = "gbxPlayer1Statistics";
            this.gbxPlayer1Statistics.Size = new System.Drawing.Size(347, 350);
            this.gbxPlayer1Statistics.TabIndex = 9;
            this.gbxPlayer1Statistics.TabStop = false;
            this.gbxPlayer1Statistics.Text = "Statistics";
            // 
            // chtPlayer1AveragesScores
            // 
            this.chtPlayer1AveragesScores.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "# Attempts";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Interval = 14D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.Title = "Scores";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chtPlayer1AveragesScores.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chtPlayer1AveragesScores.Legends.Add(legend1);
            this.chtPlayer1AveragesScores.Location = new System.Drawing.Point(6, 142);
            this.chtPlayer1AveragesScores.Name = "chtPlayer1AveragesScores";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Score";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "BPI";
            this.chtPlayer1AveragesScores.Series.Add(series1);
            this.chtPlayer1AveragesScores.Series.Add(series2);
            this.chtPlayer1AveragesScores.Size = new System.Drawing.Size(335, 196);
            this.chtPlayer1AveragesScores.TabIndex = 14;
            this.chtPlayer1AveragesScores.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "BPI & Scores";
            this.chtPlayer1AveragesScores.Titles.Add(title1);
            // 
            // dgPlayer1CurrentScores
            // 
            this.dgPlayer1CurrentScores.AllowUserToAddRows = false;
            this.dgPlayer1CurrentScores.AllowUserToDeleteRows = false;
            this.dgPlayer1CurrentScores.AllowUserToResizeColumns = false;
            this.dgPlayer1CurrentScores.AllowUserToResizeRows = false;
            this.dgPlayer1CurrentScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPlayer1CurrentScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayer1CurrentScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttemptNumber,
            this.Scores});
            this.dgPlayer1CurrentScores.Location = new System.Drawing.Point(6, 17);
            this.dgPlayer1CurrentScores.MultiSelect = false;
            this.dgPlayer1CurrentScores.Name = "dgPlayer1CurrentScores";
            this.dgPlayer1CurrentScores.RowHeadersVisible = false;
            this.dgPlayer1CurrentScores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgPlayer1CurrentScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlayer1CurrentScores.Size = new System.Drawing.Size(98, 119);
            this.dgPlayer1CurrentScores.TabIndex = 13;
            this.dgPlayer1CurrentScores.TabStop = false;
            // 
            // AttemptNumber
            // 
            this.AttemptNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AttemptNumber.DataPropertyName = "AttemptNumber";
            this.AttemptNumber.HeaderText = "#";
            this.AttemptNumber.MaxInputLength = 3;
            this.AttemptNumber.MinimumWidth = 28;
            this.AttemptNumber.Name = "AttemptNumber";
            this.AttemptNumber.ReadOnly = true;
            this.AttemptNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AttemptNumber.Width = 28;
            // 
            // Scores
            // 
            this.Scores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Scores.DataPropertyName = "Score";
            this.Scores.HeaderText = "Scores";
            this.Scores.MaxInputLength = 3;
            this.Scores.Name = "Scores";
            this.Scores.ReadOnly = true;
            // 
            // lblPlayer1BallsPerInning
            // 
            this.lblPlayer1BallsPerInning.Location = new System.Drawing.Point(113, 82);
            this.lblPlayer1BallsPerInning.Name = "lblPlayer1BallsPerInning";
            this.lblPlayer1BallsPerInning.Size = new System.Drawing.Size(83, 13);
            this.lblPlayer1BallsPerInning.TabIndex = 6;
            this.lblPlayer1BallsPerInning.Text = "Balls Per Inning:";
            // 
            // lblPlayer1TotalCount
            // 
            this.lblPlayer1TotalCount.Location = new System.Drawing.Point(113, 17);
            this.lblPlayer1TotalCount.Name = "lblPlayer1TotalCount";
            this.lblPlayer1TotalCount.Size = new System.Drawing.Size(65, 13);
            this.lblPlayer1TotalCount.TabIndex = 4;
            this.lblPlayer1TotalCount.Text = "Total Count:";
            // 
            // txtPlayer1TotalCount
            // 
            this.txtPlayer1TotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1TotalCount.Location = new System.Drawing.Point(113, 33);
            this.txtPlayer1TotalCount.Name = "txtPlayer1TotalCount";
            this.txtPlayer1TotalCount.ReadOnly = true;
            this.txtPlayer1TotalCount.Size = new System.Drawing.Size(228, 38);
            this.txtPlayer1TotalCount.TabIndex = 5;
            this.txtPlayer1TotalCount.Tag = "Player1TotalCount.txt";
            this.txtPlayer1TotalCount.Text = "0";
            // 
            // txtPlayer1BallsPerInning
            // 
            this.txtPlayer1BallsPerInning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1BallsPerInning.Location = new System.Drawing.Point(113, 98);
            this.txtPlayer1BallsPerInning.Name = "txtPlayer1BallsPerInning";
            this.txtPlayer1BallsPerInning.ReadOnly = true;
            this.txtPlayer1BallsPerInning.Size = new System.Drawing.Size(228, 38);
            this.txtPlayer1BallsPerInning.TabIndex = 7;
            this.txtPlayer1BallsPerInning.Tag = "Player1Name.txt";
            this.txtPlayer1BallsPerInning.Text = "0";
            // 
            // btnPlayer1EndInning
            // 
            this.btnPlayer1EndInning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayer1EndInning.Location = new System.Drawing.Point(122, 107);
            this.btnPlayer1EndInning.Name = "btnPlayer1EndInning";
            this.btnPlayer1EndInning.Size = new System.Drawing.Size(228, 38);
            this.btnPlayer1EndInning.TabIndex = 8;
            this.btnPlayer1EndInning.Text = "End Inning";
            this.btnPlayer1EndInning.UseVisualStyleBackColor = true;
            this.btnPlayer1EndInning.Click += new System.EventHandler(this.BtnPlayerEndInningClick);
            // 
            // lblPlayer1CurrentInningCount
            // 
            this.lblPlayer1CurrentInningCount.AutoSize = true;
            this.lblPlayer1CurrentInningCount.Location = new System.Drawing.Point(6, 76);
            this.lblPlayer1CurrentInningCount.Name = "lblPlayer1CurrentInningCount";
            this.lblPlayer1CurrentInningCount.Size = new System.Drawing.Size(107, 13);
            this.lblPlayer1CurrentInningCount.TabIndex = 3;
            this.lblPlayer1CurrentInningCount.Text = "Current Inning Count:";
            // 
            // numPlayer1CurrentInningCount
            // 
            this.numPlayer1CurrentInningCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlayer1CurrentInningCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlayer1CurrentInningCount.Location = new System.Drawing.Point(125, 63);
            this.numPlayer1CurrentInningCount.Name = "numPlayer1CurrentInningCount";
            this.numPlayer1CurrentInningCount.ReadOnly = true;
            this.numPlayer1CurrentInningCount.Size = new System.Drawing.Size(225, 38);
            this.numPlayer1CurrentInningCount.TabIndex = 2;
            this.numPlayer1CurrentInningCount.Tag = "";
            this.numPlayer1CurrentInningCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPlayer1CurrentInningCount.ValueChanged += new System.EventHandler(this.NumPlayerCurrentInningCountValueChanged);
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(125, 18);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(225, 38);
            this.txtPlayer1Name.TabIndex = 1;
            this.txtPlayer1Name.Tag = "";
            this.txtPlayer1Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlayerNameKeyPress);
            this.txtPlayer1Name.Leave += new System.EventHandler(this.TxtPlayerNameLeave);
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(75, 31);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(38, 13);
            this.lblPlayer1Name.TabIndex = 0;
            this.lblPlayer1Name.Text = "Name:";
            // 
            // gbxPlayer2
            // 
            this.gbxPlayer2.Controls.Add(this.btnPlayer2Reset);
            this.gbxPlayer2.Controls.Add(this.gbxPlayer2Statistics);
            this.gbxPlayer2.Controls.Add(this.btnPlayer2EndInning);
            this.gbxPlayer2.Controls.Add(this.lblPlayer2CurrentInningCount);
            this.gbxPlayer2.Controls.Add(this.numPlayer2CurrentInningCount);
            this.gbxPlayer2.Controls.Add(this.txtPlayer2Name);
            this.gbxPlayer2.Controls.Add(this.lblPlayer2Name);
            this.gbxPlayer2.Location = new System.Drawing.Point(380, 12);
            this.gbxPlayer2.Name = "gbxPlayer2";
            this.gbxPlayer2.Size = new System.Drawing.Size(362, 539);
            this.gbxPlayer2.TabIndex = 10;
            this.gbxPlayer2.TabStop = false;
            this.gbxPlayer2.Text = "Player 2";
            // 
            // btnPlayer2Reset
            // 
            this.btnPlayer2Reset.Location = new System.Drawing.Point(6, 507);
            this.btnPlayer2Reset.Name = "btnPlayer2Reset";
            this.btnPlayer2Reset.Size = new System.Drawing.Size(347, 23);
            this.btnPlayer2Reset.TabIndex = 11;
            this.btnPlayer2Reset.Text = "Reset";
            this.btnPlayer2Reset.UseVisualStyleBackColor = true;
            this.btnPlayer2Reset.Click += new System.EventHandler(this.BtnPlayerResetClick);
            // 
            // gbxPlayer2Statistics
            // 
            this.gbxPlayer2Statistics.Controls.Add(this.chtPlayer2AveragesScores);
            this.gbxPlayer2Statistics.Controls.Add(this.dgPlayer2CurrentScores);
            this.gbxPlayer2Statistics.Controls.Add(this.lblPlayer2BallsPerInning);
            this.gbxPlayer2Statistics.Controls.Add(this.lblPlayer2TotalCount);
            this.gbxPlayer2Statistics.Controls.Add(this.txtPlayer2TotalCount);
            this.gbxPlayer2Statistics.Controls.Add(this.txtPlayer2BallsPerInning);
            this.gbxPlayer2Statistics.Location = new System.Drawing.Point(6, 151);
            this.gbxPlayer2Statistics.Name = "gbxPlayer2Statistics";
            this.gbxPlayer2Statistics.Size = new System.Drawing.Size(347, 350);
            this.gbxPlayer2Statistics.TabIndex = 9;
            this.gbxPlayer2Statistics.TabStop = false;
            this.gbxPlayer2Statistics.Text = "Statistics";
            // 
            // chtPlayer2AveragesScores
            // 
            this.chtPlayer2AveragesScores.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "# Attempts";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.Interval = 14D;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineWidth = 2;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.Title = "Scores";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chtPlayer2AveragesScores.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Black;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chtPlayer2AveragesScores.Legends.Add(legend2);
            this.chtPlayer2AveragesScores.Location = new System.Drawing.Point(6, 142);
            this.chtPlayer2AveragesScores.Name = "chtPlayer2AveragesScores";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DodgerBlue;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Score";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "BPI";
            this.chtPlayer2AveragesScores.Series.Add(series3);
            this.chtPlayer2AveragesScores.Series.Add(series4);
            this.chtPlayer2AveragesScores.Size = new System.Drawing.Size(335, 196);
            this.chtPlayer2AveragesScores.TabIndex = 14;
            this.chtPlayer2AveragesScores.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "BPI & Scores";
            this.chtPlayer2AveragesScores.Titles.Add(title2);
            // 
            // dgPlayer2CurrentScores
            // 
            this.dgPlayer2CurrentScores.AllowUserToAddRows = false;
            this.dgPlayer2CurrentScores.AllowUserToDeleteRows = false;
            this.dgPlayer2CurrentScores.AllowUserToResizeColumns = false;
            this.dgPlayer2CurrentScores.AllowUserToResizeRows = false;
            this.dgPlayer2CurrentScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPlayer2CurrentScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayer2CurrentScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgPlayer2CurrentScores.Location = new System.Drawing.Point(6, 17);
            this.dgPlayer2CurrentScores.MultiSelect = false;
            this.dgPlayer2CurrentScores.Name = "dgPlayer2CurrentScores";
            this.dgPlayer2CurrentScores.RowHeadersVisible = false;
            this.dgPlayer2CurrentScores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgPlayer2CurrentScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlayer2CurrentScores.Size = new System.Drawing.Size(98, 119);
            this.dgPlayer2CurrentScores.TabIndex = 13;
            this.dgPlayer2CurrentScores.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AttemptNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 28;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 28;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn2.HeaderText = "Scores";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lblPlayer2BallsPerInning
            // 
            this.lblPlayer2BallsPerInning.Location = new System.Drawing.Point(113, 82);
            this.lblPlayer2BallsPerInning.Name = "lblPlayer2BallsPerInning";
            this.lblPlayer2BallsPerInning.Size = new System.Drawing.Size(83, 13);
            this.lblPlayer2BallsPerInning.TabIndex = 6;
            this.lblPlayer2BallsPerInning.Text = "Balls Per Inning:";
            // 
            // lblPlayer2TotalCount
            // 
            this.lblPlayer2TotalCount.Location = new System.Drawing.Point(113, 17);
            this.lblPlayer2TotalCount.Name = "lblPlayer2TotalCount";
            this.lblPlayer2TotalCount.Size = new System.Drawing.Size(65, 13);
            this.lblPlayer2TotalCount.TabIndex = 4;
            this.lblPlayer2TotalCount.Text = "Total Count:";
            // 
            // txtPlayer2TotalCount
            // 
            this.txtPlayer2TotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2TotalCount.Location = new System.Drawing.Point(113, 33);
            this.txtPlayer2TotalCount.Name = "txtPlayer2TotalCount";
            this.txtPlayer2TotalCount.ReadOnly = true;
            this.txtPlayer2TotalCount.Size = new System.Drawing.Size(228, 38);
            this.txtPlayer2TotalCount.TabIndex = 5;
            this.txtPlayer2TotalCount.Tag = "Player1TotalCount.txt";
            this.txtPlayer2TotalCount.Text = "0";
            // 
            // txtPlayer2BallsPerInning
            // 
            this.txtPlayer2BallsPerInning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2BallsPerInning.Location = new System.Drawing.Point(113, 98);
            this.txtPlayer2BallsPerInning.Name = "txtPlayer2BallsPerInning";
            this.txtPlayer2BallsPerInning.ReadOnly = true;
            this.txtPlayer2BallsPerInning.Size = new System.Drawing.Size(228, 38);
            this.txtPlayer2BallsPerInning.TabIndex = 7;
            this.txtPlayer2BallsPerInning.Tag = "Player1Name.txt";
            this.txtPlayer2BallsPerInning.Text = "0";
            // 
            // btnPlayer2EndInning
            // 
            this.btnPlayer2EndInning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayer2EndInning.Location = new System.Drawing.Point(122, 107);
            this.btnPlayer2EndInning.Name = "btnPlayer2EndInning";
            this.btnPlayer2EndInning.Size = new System.Drawing.Size(228, 38);
            this.btnPlayer2EndInning.TabIndex = 8;
            this.btnPlayer2EndInning.Text = "End Inning";
            this.btnPlayer2EndInning.UseVisualStyleBackColor = true;
            this.btnPlayer2EndInning.Click += new System.EventHandler(this.BtnPlayerEndInningClick);
            // 
            // lblPlayer2CurrentInningCount
            // 
            this.lblPlayer2CurrentInningCount.AutoSize = true;
            this.lblPlayer2CurrentInningCount.Location = new System.Drawing.Point(6, 76);
            this.lblPlayer2CurrentInningCount.Name = "lblPlayer2CurrentInningCount";
            this.lblPlayer2CurrentInningCount.Size = new System.Drawing.Size(107, 13);
            this.lblPlayer2CurrentInningCount.TabIndex = 3;
            this.lblPlayer2CurrentInningCount.Text = "Current Inning Count:";
            // 
            // numPlayer2CurrentInningCount
            // 
            this.numPlayer2CurrentInningCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlayer2CurrentInningCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlayer2CurrentInningCount.Location = new System.Drawing.Point(125, 63);
            this.numPlayer2CurrentInningCount.Name = "numPlayer2CurrentInningCount";
            this.numPlayer2CurrentInningCount.ReadOnly = true;
            this.numPlayer2CurrentInningCount.Size = new System.Drawing.Size(225, 38);
            this.numPlayer2CurrentInningCount.TabIndex = 2;
            this.numPlayer2CurrentInningCount.Tag = "";
            this.numPlayer2CurrentInningCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPlayer2CurrentInningCount.ValueChanged += new System.EventHandler(this.NumPlayerCurrentInningCountValueChanged);
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.Location = new System.Drawing.Point(125, 18);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(225, 38);
            this.txtPlayer2Name.TabIndex = 1;
            this.txtPlayer2Name.Tag = "";
            this.txtPlayer2Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlayerNameKeyPress);
            this.txtPlayer2Name.Leave += new System.EventHandler(this.TxtPlayerNameLeave);
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(75, 31);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(38, 13);
            this.lblPlayer2Name.TabIndex = 0;
            this.lblPlayer2Name.Text = "Name:";
            // 
            // StraightPoolScoreKeeperUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 560);
            this.Controls.Add(this.gbxPlayer2);
            this.Controls.Add(this.gbxPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StraightPoolScoreKeeperUi";
            this.Text = "Straight Pool Score Keeper";
            this.gbxPlayer1.ResumeLayout(false);
            this.gbxPlayer1.PerformLayout();
            this.gbxPlayer1Statistics.ResumeLayout(false);
            this.gbxPlayer1Statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPlayer1AveragesScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayer1CurrentScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer1CurrentInningCount)).EndInit();
            this.gbxPlayer2.ResumeLayout(false);
            this.gbxPlayer2.PerformLayout();
            this.gbxPlayer2Statistics.ResumeLayout(false);
            this.gbxPlayer2Statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPlayer2AveragesScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayer2CurrentScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer2CurrentInningCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlayer1;
        private System.Windows.Forms.GroupBox gbxPlayer1Statistics;
        private System.Windows.Forms.DataGridView dgPlayer1CurrentScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttemptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
        private System.Windows.Forms.Label lblPlayer1BallsPerInning;
        private System.Windows.Forms.Label lblPlayer1TotalCount;
        private System.Windows.Forms.TextBox txtPlayer1TotalCount;
        private System.Windows.Forms.TextBox txtPlayer1BallsPerInning;
        private System.Windows.Forms.Button btnPlayer1EndInning;
        private System.Windows.Forms.Label lblPlayer1CurrentInningCount;
        private System.Windows.Forms.NumericUpDown numPlayer1CurrentInningCount;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPlayer1AveragesScores;
        private System.Windows.Forms.GroupBox gbxPlayer2;
        private System.Windows.Forms.GroupBox gbxPlayer2Statistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPlayer2AveragesScores;
        private System.Windows.Forms.DataGridView dgPlayer2CurrentScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblPlayer2BallsPerInning;
        private System.Windows.Forms.Label lblPlayer2TotalCount;
        private System.Windows.Forms.TextBox txtPlayer2TotalCount;
        private System.Windows.Forms.TextBox txtPlayer2BallsPerInning;
        private System.Windows.Forms.Button btnPlayer2EndInning;
        private System.Windows.Forms.Label lblPlayer2CurrentInningCount;
        private System.Windows.Forms.NumericUpDown numPlayer2CurrentInningCount;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Button btnPlayer1Reset;
        private System.Windows.Forms.Button btnPlayer2Reset;
    }
}

