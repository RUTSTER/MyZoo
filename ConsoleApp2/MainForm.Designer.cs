using System.Windows.Forms;

namespace ConsoleApp2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BuyCageButton = new System.Windows.Forms.Button();
            this.CleaningButton = new System.Windows.Forms.Button();
            this.CuringButton = new System.Windows.Forms.Button();
            this.FeedingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.KillButton = new System.Windows.Forms.Button();
            this.LvlupButton = new System.Windows.Forms.Button();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NewCagePriceLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lvl = new System.Windows.Forms.Label();
            this.LVLValue = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.Label();
            this.ProfitValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyCageButton
            // 
            this.BuyCageButton.BackColor = System.Drawing.Color.Transparent;
            this.BuyCageButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.BuyNewCagePic;
            this.BuyCageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyCageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyCageButton.FlatAppearance.BorderSize = 0;
            this.BuyCageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyCageButton.Location = new System.Drawing.Point(758, 454);
            this.BuyCageButton.Name = "BuyCageButton";
            this.BuyCageButton.Size = new System.Drawing.Size(144, 81);
            this.BuyCageButton.TabIndex = 1;
            this.BuyCageButton.UseVisualStyleBackColor = false;
            this.BuyCageButton.Click += new System.EventHandler(this.BuyCageButton_Click);
            this.BuyCageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuyCageButton_MouseDown);
            this.BuyCageButton.MouseEnter += new System.EventHandler(this.BuyCageButton_MouseEnter);
            this.BuyCageButton.MouseLeave += new System.EventHandler(this.BuyCageButton_MouseLeave);
            this.BuyCageButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuyCageButton_MouseUp);
            // 
            // CleaningButton
            // 
            this.CleaningButton.BackColor = System.Drawing.Color.Transparent;
            this.CleaningButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.CleaningIconBase;
            this.CleaningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleaningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleaningButton.FlatAppearance.BorderSize = 0;
            this.CleaningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleaningButton.Location = new System.Drawing.Point(490, 465);
            this.CleaningButton.Name = "CleaningButton";
            this.CleaningButton.Size = new System.Drawing.Size(60, 60);
            this.CleaningButton.TabIndex = 4;
            this.CleaningButton.UseVisualStyleBackColor = false;
            this.CleaningButton.Click += new System.EventHandler(this.CleaningButton_Click);
            this.CleaningButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CleaningButton_MouseDown);
            this.CleaningButton.MouseEnter += new System.EventHandler(this.CleaningButton_MouseEnter);
            this.CleaningButton.MouseLeave += new System.EventHandler(this.CleaningButton_MouseLeave);
            this.CleaningButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CleaningButton_MouseUp);
            // 
            // CuringButton
            // 
            this.CuringButton.BackColor = System.Drawing.Color.Transparent;
            this.CuringButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.CuringIconBase;
            this.CuringButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CuringButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CuringButton.FlatAppearance.BorderSize = 0;
            this.CuringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CuringButton.Location = new System.Drawing.Point(195, 465);
            this.CuringButton.Name = "CuringButton";
            this.CuringButton.Size = new System.Drawing.Size(60, 60);
            this.CuringButton.TabIndex = 3;
            this.CuringButton.UseVisualStyleBackColor = false;
            this.CuringButton.Click += new System.EventHandler(this.CuringButton_Click);
            this.CuringButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CuringButton_MouseDown);
            this.CuringButton.MouseEnter += new System.EventHandler(this.CuringButton_MouseEnter);
            this.CuringButton.MouseLeave += new System.EventHandler(this.CuringButton_MouseLeave);
            this.CuringButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CuringButton_MouseUp);
            // 
            // FeedingButton
            // 
            this.FeedingButton.BackColor = System.Drawing.Color.Transparent;
            this.FeedingButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.FeedingIconBase;
            this.FeedingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FeedingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeedingButton.FlatAppearance.BorderSize = 0;
            this.FeedingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedingButton.Location = new System.Drawing.Point(300, 465);
            this.FeedingButton.Name = "FeedingButton";
            this.FeedingButton.Size = new System.Drawing.Size(60, 60);
            this.FeedingButton.TabIndex = 2;
            this.FeedingButton.UseVisualStyleBackColor = false;
            this.FeedingButton.Click += new System.EventHandler(this.FeedingButton_Click);
            this.FeedingButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FeedingButton_MouseDown);
            this.FeedingButton.MouseEnter += new System.EventHandler(this.FeedingButton_MouseEnter);
            this.FeedingButton.MouseLeave += new System.EventHandler(this.FeedingButton_MouseLeave);
            this.FeedingButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FeedingButton_MouseUp);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.ExitButtonPic;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(895, 1);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 24);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ButtonExit_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonExit_MouseDown);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            // 
            // KillButton
            // 
            this.KillButton.BackColor = System.Drawing.Color.Transparent;
            this.KillButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.KillIconBase;
            this.KillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KillButton.FlatAppearance.BorderSize = 0;
            this.KillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillButton.Location = new System.Drawing.Point(595, 465);
            this.KillButton.Name = "KillButton";
            this.KillButton.Size = new System.Drawing.Size(60, 60);
            this.KillButton.TabIndex = 7;
            this.KillButton.UseVisualStyleBackColor = false;
            this.KillButton.Click += new System.EventHandler(this.KillButton_Click);
            this.KillButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KillButton_MouseDown);
            this.KillButton.MouseEnter += new System.EventHandler(this.KillButton_MouseEnter);
            this.KillButton.MouseLeave += new System.EventHandler(this.KillButton_MouseLeave);
            this.KillButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KillButton_MouseUp);
            // 
            // LvlupButton
            // 
            this.LvlupButton.BackColor = System.Drawing.Color.Transparent;
            this.LvlupButton.BackgroundImage = global::ConsoleApp2.Properties.Resources.LvlupIconBase;
            this.LvlupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LvlupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvlupButton.FlatAppearance.BorderSize = 0;
            this.LvlupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LvlupButton.Location = new System.Drawing.Point(90, 465);
            this.LvlupButton.Name = "LvlupButton";
            this.LvlupButton.Size = new System.Drawing.Size(60, 60);
            this.LvlupButton.TabIndex = 6;
            this.LvlupButton.UseVisualStyleBackColor = false;
            this.LvlupButton.Click += new System.EventHandler(this.LvlupButton_Click);
            this.LvlupButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LvlupButton_MouseDown);
            this.LvlupButton.MouseEnter += new System.EventHandler(this.LvlupButton_MouseEnter);
            this.LvlupButton.MouseLeave += new System.EventHandler(this.LvlupButton_MouseLeave);
            this.LvlupButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LvlupButton_MouseUp);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.Location = new System.Drawing.Point(768, 86);
            this.MoneyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(123, 41);
            this.MoneyLabel.TabIndex = 8;
            this.MoneyLabel.Text = "$999M";
            this.MoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VersionLabel.Location = new System.Drawing.Point(930, 525);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(24, 12);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "V0.1";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCagePriceLabel
            // 
            this.NewCagePriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewCagePriceLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCagePriceLabel.Location = new System.Drawing.Point(787, 420);
            this.NewCagePriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NewCagePriceLabel.Name = "NewCagePriceLabel";
            this.NewCagePriceLabel.Size = new System.Drawing.Size(86, 29);
            this.NewCagePriceLabel.TabIndex = 10;
            this.NewCagePriceLabel.Text = "$999M";
            this.NewCagePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ConsoleApp2.Properties.Resources.SecondBackground;
            this.tabPage1.Controls.Add(this.Gender);
            this.tabPage1.Controls.Add(this.Age);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProfitValue);
            this.tabPage1.Controls.Add(this.Profit);
            this.tabPage1.Controls.Add(this.LVLValue);
            this.tabPage1.Controls.Add(this.Lvl);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lvl
            // 
            this.Lvl.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lvl.Location = new System.Drawing.Point(495, 22);
            this.Lvl.Margin = new System.Windows.Forms.Padding(0);
            this.Lvl.Name = "Lvl";
            this.Lvl.Size = new System.Drawing.Size(71, 31);
            this.Lvl.TabIndex = 1;
            this.Lvl.Text = "LVL:";
            // 
            // LVLValue
            // 
            this.LVLValue.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVLValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LVLValue.Location = new System.Drawing.Point(566, 22);
            this.LVLValue.Margin = new System.Windows.Forms.Padding(0);
            this.LVLValue.Name = "LVLValue";
            this.LVLValue.Size = new System.Drawing.Size(82, 31);
            this.LVLValue.TabIndex = 2;
            this.LVLValue.Text = "88";
            this.LVLValue.Click += new System.EventHandler(this.LVLValue_Click);
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profit.Location = new System.Drawing.Point(443, 101);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(133, 20);
            this.Profit.TabIndex = 3;
            this.Profit.Text = "PROFIT/second:";
            this.Profit.Click += new System.EventHandler(this.Profit_Click);
            // 
            // ProfitValue
            // 
            this.ProfitValue.AutoSize = true;
            this.ProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitValue.Location = new System.Drawing.Point(592, 101);
            this.ProfitValue.Name = "ProfitValue";
            this.ProfitValue.Size = new System.Drawing.Size(58, 20);
            this.ProfitValue.TabIndex = 4;
            this.ProfitValue.Text = "$999M";
            this.ProfitValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(514, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name: Qwer";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(520, 331);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(50, 16);
            this.Age.TabIndex = 7;
            this.Age.Text = "Age:10";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.Location = new System.Drawing.Point(514, 299);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(67, 16);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender: F";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 449);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Visible = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.NewCagePriceLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.KillButton);
            this.Controls.Add(this.LvlupButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CleaningButton);
            this.Controls.Add(this.CuringButton);
            this.Controls.Add(this.FeedingButton);
            this.Controls.Add(this.BuyCageButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button BuyCageButton;
        private Button FeedingButton;
        private Button CuringButton;
        private Button CleaningButton;
        private Button ExitButton;
        private Button KillButton;
        private Button LvlupButton;
        private Label MoneyLabel;
        private Label VersionLabel;
        private Label NewCagePriceLabel;
        private TabPage tabPage1;
        private Label Gender;
        private Label Age;
        private Label label5;
        private Label ProfitValue;
        private Label Profit;
        private Label LVLValue;
        private Label Lvl;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
    }
}