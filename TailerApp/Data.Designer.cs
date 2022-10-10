namespace TailerApp
{
    partial class Data
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contact_search = new System.Windows.Forms.TextBox();
            this.dt_searchto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TwoDates = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.dt_searchfrom = new System.Windows.Forms.DateTimePicker();
            this.btn_Serial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search_data = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1232, 395);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txt_contact_search);
            this.splitContainer1.Panel1.Controls.Add(this.dt_searchto);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_TwoDates);
            this.splitContainer1.Panel1.Controls.Add(this.label26);
            this.splitContainer1.Panel1.Controls.Add(this.dt_searchfrom);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Serial);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_search_data);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1232, 490);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1077, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Store data in excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "تلاش کریں";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "رابط نمبر";
            // 
            // txt_contact_search
            // 
            this.txt_contact_search.Location = new System.Drawing.Point(433, 12);
            this.txt_contact_search.Name = "txt_contact_search";
            this.txt_contact_search.Size = new System.Drawing.Size(92, 20);
            this.txt_contact_search.TabIndex = 38;
            // 
            // dt_searchto
            // 
            this.dt_searchto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_searchto.CustomFormat = "dd-MM-yyyy";
            this.dt_searchto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_searchto.Location = new System.Drawing.Point(603, 49);
            this.dt_searchto.Name = "dt_searchto";
            this.dt_searchto.Size = new System.Drawing.Size(87, 20);
            this.dt_searchto.TabIndex = 37;
            this.dt_searchto.Value = new System.DateTime(2022, 9, 16, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(707, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = ": اس وقت تک";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(916, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = ": اس وقت سے";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "                      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = ": رکم";
            // 
            // btn_TwoDates
            // 
            this.btn_TwoDates.Location = new System.Drawing.Point(509, 48);
            this.btn_TwoDates.Name = "btn_TwoDates";
            this.btn_TwoDates.Size = new System.Drawing.Size(75, 23);
            this.btn_TwoDates.TabIndex = 32;
            this.btn_TwoDates.Text = "تلاش کریں";
            this.btn_TwoDates.UseVisualStyleBackColor = true;
            this.btn_TwoDates.Click += new System.EventHandler(this.button2_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1064, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(132, 20);
            this.label26.TabIndex = 31;
            this.label26.Text = "تاریخ پر تلاش کریں";
            // 
            // dt_searchfrom
            // 
            this.dt_searchfrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_searchfrom.CustomFormat = "dd-MM-yyyy";
            this.dt_searchfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_searchfrom.Location = new System.Drawing.Point(823, 51);
            this.dt_searchfrom.Name = "dt_searchfrom";
            this.dt_searchfrom.Size = new System.Drawing.Size(87, 20);
            this.dt_searchfrom.TabIndex = 30;
            this.dt_searchfrom.Value = new System.DateTime(2022, 9, 16, 0, 0, 0, 0);
            // 
            // btn_Serial
            // 
            this.btn_Serial.Location = new System.Drawing.Point(694, 13);
            this.btn_Serial.Name = "btn_Serial";
            this.btn_Serial.Size = new System.Drawing.Size(75, 23);
            this.btn_Serial.TabIndex = 2;
            this.btn_Serial.Text = "تلاش کریں";
            this.btn_Serial.UseVisualStyleBackColor = true;
            this.btn_Serial.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(888, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "گاہک کا سیریل نمبر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_search_data
            // 
            this.txt_search_data.Location = new System.Drawing.Point(775, 15);
            this.txt_search_data.Name = "txt_search_data";
            this.txt_search_data.Size = new System.Drawing.Size(92, 20);
            this.txt_search_data.TabIndex = 0;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Data";
            this.Text = "گاہک کی ریپورث";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search_data;
        private System.Windows.Forms.Button btn_Serial;
        private System.Windows.Forms.Button btn_TwoDates;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dt_searchfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_searchto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contact_search;
        private System.Windows.Forms.Button button3;
    }
}