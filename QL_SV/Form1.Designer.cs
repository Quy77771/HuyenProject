namespace QL_SV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMASV = new System.Windows.Forms.TextBox();
            this.textTENSV = new System.Windows.Forms.TextBox();
            this.textLOP = new System.Windows.Forms.TextBox();
            this.textDIEM = new System.Windows.Forms.TextBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textTIMKIEM = new System.Windows.Forms.TextBox();
            this.btnTIM = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridSV = new System.Windows.Forms.DataGridView();
            this.colMASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN SINH VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "LỚP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐIỂM";
            // 
            // textMASV
            // 
            this.textMASV.Location = new System.Drawing.Point(135, 12);
            this.textMASV.Name = "textMASV";
            this.textMASV.Size = new System.Drawing.Size(178, 22);
            this.textMASV.TabIndex = 4;
            // 
            // textTENSV
            // 
            this.textTENSV.Location = new System.Drawing.Point(135, 51);
            this.textTENSV.Name = "textTENSV";
            this.textTENSV.Size = new System.Drawing.Size(178, 22);
            this.textTENSV.TabIndex = 5;
            // 
            // textLOP
            // 
            this.textLOP.Location = new System.Drawing.Point(437, 13);
            this.textLOP.Name = "textLOP";
            this.textLOP.Size = new System.Drawing.Size(178, 22);
            this.textLOP.TabIndex = 6;
            // 
            // textDIEM
            // 
            this.textDIEM.Location = new System.Drawing.Point(437, 51);
            this.textDIEM.Name = "textDIEM";
            this.textDIEM.Size = new System.Drawing.Size(46, 22);
            this.textDIEM.TabIndex = 7;
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(15, 106);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(75, 23);
            this.btnTHEM.TabIndex = 8;
            this.btnTHEM.Text = "THÊM";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(124, 106);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(75, 23);
            this.btnSUA.TabIndex = 9;
            this.btnSUA.Text = "SỬA";
            this.btnSUA.UseVisualStyleBackColor = true;
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(238, 106);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 23);
            this.btnXOA.TabIndex = 10;
            this.btnXOA.Text = "XÓA";
            this.btnXOA.UseVisualStyleBackColor = true;
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(391, 106);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(75, 23);
            this.btnLUU.TabIndex = 11;
            this.btnLUU.Text = "LƯU";
            this.btnLUU.UseVisualStyleBackColor = true;
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(540, 106);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(75, 23);
            this.btnHUY.TabIndex = 12;
            this.btnHUY.Text = "HỦY";
            this.btnHUY.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "TÌM KIẾM";
            // 
            // textTIMKIEM
            // 
            this.textTIMKIEM.Location = new System.Drawing.Point(135, 154);
            this.textTIMKIEM.Name = "textTIMKIEM";
            this.textTIMKIEM.Size = new System.Drawing.Size(261, 22);
            this.textTIMKIEM.TabIndex = 14;
            // 
            // btnTIM
            // 
            this.btnTIM.Location = new System.Drawing.Point(437, 154);
            this.btnTIM.Name = "btnTIM";
            this.btnTIM.Size = new System.Drawing.Size(75, 23);
            this.btnTIM.TabIndex = 15;
            this.btnTIM.Text = "TÌM";
            this.btnTIM.UseVisualStyleBackColor = true;
            // 
            // dataGridSV
            // 
            this.dataGridSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMASV,
            this.colTENSV,
            this.colLOP,
            this.colDIEM});
            this.dataGridSV.Location = new System.Drawing.Point(29, 197);
            this.dataGridSV.Name = "dataGridSV";
            this.dataGridSV.RowHeadersWidth = 51;
            this.dataGridSV.RowTemplate.Height = 24;
            this.dataGridSV.Size = new System.Drawing.Size(743, 219);
            this.dataGridSV.TabIndex = 16;
            // 
            // colMASV
            // 
            this.colMASV.DataPropertyName = "MASV";
            this.colMASV.HeaderText = "MÃ SINH VIÊN";
            this.colMASV.MinimumWidth = 6;
            this.colMASV.Name = "colMASV";
            this.colMASV.Width = 200;
            // 
            // colTENSV
            // 
            this.colTENSV.DataPropertyName = "TENSV";
            this.colTENSV.HeaderText = "TÊN SINH VIÊN";
            this.colTENSV.MinimumWidth = 6;
            this.colTENSV.Name = "colTENSV";
            this.colTENSV.Width = 250;
            // 
            // colLOP
            // 
            this.colLOP.DataPropertyName = "LOP";
            this.colLOP.HeaderText = "LỚP";
            this.colLOP.MinimumWidth = 6;
            this.colLOP.Name = "colLOP";
            this.colLOP.Width = 150;
            // 
            // colDIEM
            // 
            this.colDIEM.DataPropertyName = "DIEM";
            this.colDIEM.HeaderText = "ĐIỂM";
            this.colDIEM.MinimumWidth = 6;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 516);
            this.Controls.Add(this.dataGridSV);
            this.Controls.Add(this.btnTIM);
            this.Controls.Add(this.textTIMKIEM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHUY);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.textDIEM);
            this.Controls.Add(this.textLOP);
            this.Controls.Add(this.textTENSV);
            this.Controls.Add(this.textMASV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ SINH VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += LoadForm;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMASV;
        private System.Windows.Forms.TextBox textTENSV;
        private System.Windows.Forms.TextBox textLOP;
        private System.Windows.Forms.TextBox textDIEM;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTIMKIEM;
        private System.Windows.Forms.Button btnTIM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDIEM;
    }
}

