namespace WindowsFormsApp1
{
    partial class Home
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
            this.MapPanel = new System.Windows.Forms.Panel();
            this.CreateWallBtn = new System.Windows.Forms.Button();
            this.ModeLbl = new System.Windows.Forms.Label();
            this.CreateDesBtn = new System.Windows.Forms.Button();
            this.CreateSourceBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SolBtn = new System.Windows.Forms.Button();
            this.Algorithm = new System.Windows.Forms.GroupBox();
            this.DfsRadioBtn = new System.Windows.Forms.RadioButton();
            this.BfsRadiobtn = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AStarRadioBtn = new System.Windows.Forms.RadioButton();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.CountNodeLbl = new System.Windows.Forms.Label();
            this.CountPathLbl = new System.Windows.Forms.Label();
            this.Algorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapPanel
            // 
            this.MapPanel.Location = new System.Drawing.Point(12, 12);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(854, 669);
            this.MapPanel.TabIndex = 0;
            this.MapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MapPanel_Paint);
            this.MapPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapPanel_MouseClick);
            this.MapPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapPanel_MouseMove);
            // 
            // CreateWallBtn
            // 
            this.CreateWallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateWallBtn.Location = new System.Drawing.Point(882, 81);
            this.CreateWallBtn.Name = "CreateWallBtn";
            this.CreateWallBtn.Size = new System.Drawing.Size(123, 38);
            this.CreateWallBtn.TabIndex = 1;
            this.CreateWallBtn.Text = "Tạo tường";
            this.CreateWallBtn.UseVisualStyleBackColor = true;
            this.CreateWallBtn.Click += new System.EventHandler(this.CreateWallBtn_Click);
            // 
            // ModeLbl
            // 
            this.ModeLbl.AutoSize = true;
            this.ModeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLbl.Location = new System.Drawing.Point(885, 24);
            this.ModeLbl.Name = "ModeLbl";
            this.ModeLbl.Size = new System.Drawing.Size(85, 32);
            this.ModeLbl.TabIndex = 2;
            this.ModeLbl.Text = "Mode";
            // 
            // CreateDesBtn
            // 
            this.CreateDesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDesBtn.Location = new System.Drawing.Point(882, 222);
            this.CreateDesBtn.Name = "CreateDesBtn";
            this.CreateDesBtn.Size = new System.Drawing.Size(123, 38);
            this.CreateDesBtn.TabIndex = 3;
            this.CreateDesBtn.Text = "Tạo đích";
            this.CreateDesBtn.UseVisualStyleBackColor = true;
            this.CreateDesBtn.Click += new System.EventHandler(this.CreateDesBtn_Click);
            // 
            // CreateSourceBtn
            // 
            this.CreateSourceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSourceBtn.Location = new System.Drawing.Point(882, 143);
            this.CreateSourceBtn.Name = "CreateSourceBtn";
            this.CreateSourceBtn.Size = new System.Drawing.Size(123, 57);
            this.CreateSourceBtn.TabIndex = 4;
            this.CreateSourceBtn.Text = "Tạo điểm xuất phát";
            this.CreateSourceBtn.UseVisualStyleBackColor = true;
            this.CreateSourceBtn.Click += new System.EventHandler(this.CreateSourceBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(882, 278);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(123, 38);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Xóa";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SolBtn
            // 
            this.SolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolBtn.Location = new System.Drawing.Point(882, 340);
            this.SolBtn.Name = "SolBtn";
            this.SolBtn.Size = new System.Drawing.Size(123, 38);
            this.SolBtn.TabIndex = 6;
            this.SolBtn.Text = "Tìm đường";
            this.SolBtn.UseVisualStyleBackColor = true;
            this.SolBtn.Click += new System.EventHandler(this.SolBtn_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.Controls.Add(this.AStarRadioBtn);
            this.Algorithm.Controls.Add(this.DfsRadioBtn);
            this.Algorithm.Controls.Add(this.BfsRadiobtn);
            this.Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algorithm.Location = new System.Drawing.Point(1076, 81);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(200, 142);
            this.Algorithm.TabIndex = 7;
            this.Algorithm.TabStop = false;
            this.Algorithm.Text = "Thuật toán";
            // 
            // DfsRadioBtn
            // 
            this.DfsRadioBtn.AutoSize = true;
            this.DfsRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DfsRadioBtn.Location = new System.Drawing.Point(18, 62);
            this.DfsRadioBtn.Name = "DfsRadioBtn";
            this.DfsRadioBtn.Size = new System.Drawing.Size(64, 24);
            this.DfsRadioBtn.TabIndex = 1;
            this.DfsRadioBtn.TabStop = true;
            this.DfsRadioBtn.Text = "DFS";
            this.DfsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BfsRadiobtn
            // 
            this.BfsRadiobtn.AutoSize = true;
            this.BfsRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BfsRadiobtn.Location = new System.Drawing.Point(18, 32);
            this.BfsRadiobtn.Name = "BfsRadiobtn";
            this.BfsRadiobtn.Size = new System.Drawing.Size(63, 24);
            this.BfsRadiobtn.TabIndex = 0;
            this.BfsRadiobtn.TabStop = true;
            this.BfsRadiobtn.Text = "BFS";
            this.BfsRadiobtn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1076, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Đi chéo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AStarRadioBtn
            // 
            this.AStarRadioBtn.AutoSize = true;
            this.AStarRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AStarRadioBtn.Location = new System.Drawing.Point(18, 88);
            this.AStarRadioBtn.Name = "AStarRadioBtn";
            this.AStarRadioBtn.Size = new System.Drawing.Size(47, 24);
            this.AStarRadioBtn.TabIndex = 2;
            this.AStarRadioBtn.TabStop = true;
            this.AStarRadioBtn.Text = "A*";
            this.AStarRadioBtn.UseVisualStyleBackColor = true;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.Location = new System.Drawing.Point(898, 446);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(94, 20);
            this.StatusLbl.TabIndex = 9;
            this.StatusLbl.Text = "Trạng thái :";
            // 
            // CountNodeLbl
            // 
            this.CountNodeLbl.AutoSize = true;
            this.CountNodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountNodeLbl.Location = new System.Drawing.Point(898, 510);
            this.CountNodeLbl.Name = "CountNodeLbl";
            this.CountNodeLbl.Size = new System.Drawing.Size(144, 20);
            this.CountNodeLbl.TabIndex = 10;
            this.CountNodeLbl.Text = "Số nút duyệt qua :";
            // 
            // CountPathLbl
            // 
            this.CountPathLbl.AutoSize = true;
            this.CountPathLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountPathLbl.Location = new System.Drawing.Point(898, 570);
            this.CountPathLbl.Name = "CountPathLbl";
            this.CountPathLbl.Size = new System.Drawing.Size(135, 20);
            this.CountPathLbl.TabIndex = 11;
            this.CountPathLbl.Text = "Độ dài đường đi :";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 693);
            this.Controls.Add(this.CountPathLbl);
            this.Controls.Add(this.CountNodeLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.SolBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CreateSourceBtn);
            this.Controls.Add(this.CreateDesBtn);
            this.Controls.Add(this.ModeLbl);
            this.Controls.Add(this.CreateWallBtn);
            this.Controls.Add(this.MapPanel);
            this.Name = "Home";
            this.Text = "Home";
            this.Algorithm.ResumeLayout(false);
            this.Algorithm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button CreateWallBtn;
        private System.Windows.Forms.Label ModeLbl;
        private System.Windows.Forms.Button CreateDesBtn;
        private System.Windows.Forms.Button CreateSourceBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SolBtn;
        private System.Windows.Forms.GroupBox Algorithm;
        private System.Windows.Forms.RadioButton DfsRadioBtn;
        private System.Windows.Forms.RadioButton BfsRadiobtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton AStarRadioBtn;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label CountNodeLbl;
        private System.Windows.Forms.Label CountPathLbl;
    }
}

