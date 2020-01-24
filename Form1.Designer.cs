namespace GitHub学習用
{
    partial class F1000
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.cmbEnzanshi = new System.Windows.Forms.ComboBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnzan1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnzan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue1
            // 
            this.txtValue1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtValue1.Location = new System.Drawing.Point(25, 65);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(60, 23);
            this.txtValue1.TabIndex = 0;
            // 
            // cmbEnzanshi
            // 
            this.cmbEnzanshi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnzanshi.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbEnzanshi.FormattingEnabled = true;
            this.cmbEnzanshi.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.cmbEnzanshi.Location = new System.Drawing.Point(86, 65);
            this.cmbEnzanshi.Name = "cmbEnzanshi";
            this.cmbEnzanshi.Size = new System.Drawing.Size(52, 24);
            this.cmbEnzanshi.TabIndex = 1;
            // 
            // txtValue2
            // 
            this.txtValue2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtValue2.Location = new System.Drawing.Point(139, 65);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(60, 23);
            this.txtValue2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(202, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // txtEnzan1
            // 
            this.txtEnzan1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtEnzan1.Location = new System.Drawing.Point(219, 65);
            this.txtEnzan1.Name = "txtEnzan1";
            this.txtEnzan1.ReadOnly = true;
            this.txtEnzan1.Size = new System.Drawing.Size(60, 23);
            this.txtEnzan1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "計算システム";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnzan
            // 
            this.btnEnzan.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEnzan.Location = new System.Drawing.Point(25, 32);
            this.btnEnzan.Name = "btnEnzan";
            this.btnEnzan.Size = new System.Drawing.Size(81, 29);
            this.btnEnzan.TabIndex = 6;
            this.btnEnzan.Text = "計算開始";
            this.btnEnzan.UseVisualStyleBackColor = true;
            this.btnEnzan.Click += new System.EventHandler(this.btnEnzan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(112, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEnd.Location = new System.Drawing.Point(397, 119);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(103, 29);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "システム終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // F1000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 160);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnzan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnzan1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.cmbEnzanshi);
            this.Controls.Add(this.txtValue1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "F1000";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F1000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.ComboBox cmbEnzanshi;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnzan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnzan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}

