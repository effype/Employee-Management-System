namespace EmployeeManagementSystem
{
    partial class GeneratePayRoll
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.btnNameAsc = new System.Windows.Forms.Button();
            this.sortByTotalWageAsc = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payrollDataGridView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sideBarPanel.Controls.Add(this.btnNameAsc);
            this.sideBarPanel.Controls.Add(this.sortByTotalWageAsc);
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(176, 555);
            this.sideBarPanel.TabIndex = 1;
            this.sideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.sideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.sideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnNameAsc
            // 
            this.btnNameAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNameAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNameAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnNameAsc.FlatAppearance.BorderSize = 0;
            this.btnNameAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameAsc.ForeColor = System.Drawing.Color.White;
            this.btnNameAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameAsc.Location = new System.Drawing.Point(-3, 151);
            this.btnNameAsc.Name = "btnNameAsc";
            this.btnNameAsc.Size = new System.Drawing.Size(173, 40);
            this.btnNameAsc.TabIndex = 5;
            this.btnNameAsc.Text = "Nazwy rosnąco";
            this.btnNameAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameAsc.UseVisualStyleBackColor = true;
            this.btnNameAsc.Click += new System.EventHandler(this.btnNameAsc_Click);
            // 
            // sortByTotalWageAsc
            // 
            this.sortByTotalWageAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sortByTotalWageAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortByTotalWageAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.sortByTotalWageAsc.FlatAppearance.BorderSize = 0;
            this.sortByTotalWageAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortByTotalWageAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByTotalWageAsc.ForeColor = System.Drawing.Color.White;
            this.sortByTotalWageAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortByTotalWageAsc.Location = new System.Drawing.Point(2, 105);
            this.sortByTotalWageAsc.Name = "sortByTotalWageAsc";
            this.sortByTotalWageAsc.Size = new System.Drawing.Size(173, 40);
            this.sortByTotalWageAsc.TabIndex = 1;
            this.sortByTotalWageAsc.Text = "Płaca całkowita";
            this.sortByTotalWageAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortByTotalWageAsc.UseVisualStyleBackColor = true;
            this.sortByTotalWageAsc.Click += new System.EventHandler(this.sortByTotalWageAsc_Click);
            this.sortByTotalWageAsc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.sortByTotalWageAsc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.sortByTotalWageAsc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightGreen;
            this.logoPanel.Controls.Add(this.lblLogo);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(176, 53);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(67, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(80, 33);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "EMS";
            this.lblLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.LightGreen;
            this.headerPanel.Controls.Add(this.header);
            this.headerPanel.Controls.Add(this.lblMinimize);
            this.headerPanel.Controls.Add(this.lblClose);
            this.headerPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(176, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1046, 53);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.LightGreen;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.header.Location = new System.Drawing.Point(229, 8);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(139, 33);
            this.header.TabIndex = 2;
            this.header.Text = "Lista płac";
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(995, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(19, 25);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1018, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(176, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 100);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(913, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.payrollDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(176, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 402);
            this.panel2.TabIndex = 4;
            // 
            // payrollDataGridView
            // 
            this.payrollDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payrollDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payrollDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.payrollDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.payrollDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payrollDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Department,
            this.WageRate,
            this.workedHour,
            this.TotalWage});
            this.payrollDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.payrollDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.payrollDataGridView.Location = new System.Drawing.Point(0, 0);
            this.payrollDataGridView.Name = "payrollDataGridView";
            this.payrollDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.payrollDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.payrollDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.payrollDataGridView.Size = new System.Drawing.Size(1046, 402);
            this.payrollDataGridView.TabIndex = 5;
            this.payrollDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.payrollDataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.payrollDataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // FullName
            // 
            this.FullName.FillWeight = 83.94669F;
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Department
            // 
            this.Department.FillWeight = 83.94669F;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // WageRate
            // 
            this.WageRate.FillWeight = 83.94669F;
            this.WageRate.HeaderText = "Wage Rate";
            this.WageRate.Name = "WageRate";
            // 
            // workedHour
            // 
            this.workedHour.HeaderText = "WorkedHour";
            this.workedHour.Name = "workedHour";
            // 
            // TotalWage
            // 
            this.TotalWage.HeaderText = "Total Wage";
            this.TotalWage.Name = "TotalWage";
            // 
            // GeneratePayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratePayRoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratePayRoll";
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button sortByTotalWageAsc;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView payrollDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn WageRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn workedHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNameAsc;
    }
}