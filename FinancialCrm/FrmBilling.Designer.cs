namespace FinancialCrm
{
    partial class FrmBilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBillList = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 546);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(23, 456);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Çıkış Yap";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(23, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ayarlar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(23, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 40);
            this.button7.TabIndex = 5;
            this.button7.Text = "Dashboard";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(23, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 40);
            this.button8.TabIndex = 4;
            this.button8.Text = "Banka Hareketleri";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(23, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(23, 108);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(177, 40);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateBill);
            this.panel2.Controls.Add(this.btnRemoveBill);
            this.panel2.Controls.Add(this.btnCreateBill);
            this.panel2.Controls.Add(this.btnBillList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(223, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 236);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(219, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 230);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Id :";
            // 
            // txtBillId
            // 
            this.txtBillId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillId.Location = new System.Drawing.Point(113, 10);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(619, 32);
            this.txtBillId.TabIndex = 1;
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillTitle.Location = new System.Drawing.Point(113, 53);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(619, 32);
            this.txtBillTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık :";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillAmount.Location = new System.Drawing.Point(113, 99);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(619, 32);
            this.txtBillAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar :";
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillPeriod.Location = new System.Drawing.Point(113, 148);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(619, 32);
            this.txtBillPeriod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periyot : ";
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.Transparent;
            this.btnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillList.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.ForeColor = System.Drawing.Color.Black;
            this.btnBillList.Location = new System.Drawing.Point(133, 193);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(142, 41);
            this.btnBillList.TabIndex = 8;
            this.btnBillList.Text = "Ödeme Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(223, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 292);
            this.panel4.TabIndex = 3;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBill.Location = new System.Drawing.Point(281, 193);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(142, 41);
            this.btnCreateBill.TabIndex = 9;
            this.btnCreateBill.Text = "Yeni Ödeme";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnRemoveBill
            // 
            this.btnRemoveBill.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBill.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBill.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBill.Location = new System.Drawing.Point(429, 193);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(142, 41);
            this.btnRemoveBill.TabIndex = 10;
            this.btnRemoveBill.Text = "Ödeme Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = false;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBill.Location = new System.Drawing.Point(577, 193);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(142, 41);
            this.btnUpdateBill.TabIndex = 11;
            this.btnUpdateBill.Text = "Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}