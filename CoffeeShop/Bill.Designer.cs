﻿
namespace CoffeeShop
{
    partial class Bill
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
            this.listBox_Bill = new System.Windows.Forms.ListBox();
            this.tb_cashin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Cashback = new System.Windows.Forms.TextBox();
            this.bt_Done = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btzalopay = new System.Windows.Forms.Button();
            this.btmomo = new System.Windows.Forms.Button();
            this.picboxqr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxqr)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Bill
            // 
            this.listBox_Bill.BackColor = System.Drawing.SystemColors.GrayText;
            this.listBox_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Bill.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Bill.FormattingEnabled = true;
            this.listBox_Bill.ItemHeight = 25;
            this.listBox_Bill.Location = new System.Drawing.Point(-1, 0);
            this.listBox_Bill.Name = "listBox_Bill";
            this.listBox_Bill.Size = new System.Drawing.Size(403, 354);
            this.listBox_Bill.TabIndex = 1;
            this.listBox_Bill.SelectedIndexChanged += new System.EventHandler(this.listBox_Bill_SelectedIndexChanged);
            // 
            // tb_cashin
            // 
            this.tb_cashin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_cashin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cashin.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_cashin.Location = new System.Drawing.Point(591, 7);
            this.tb_cashin.Name = "tb_cashin";
            this.tb_cashin.Size = new System.Drawing.Size(268, 30);
            this.tb_cashin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cash in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cash back:";
            // 
            // tb_Cashback
            // 
            this.tb_Cashback.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Cashback.Enabled = false;
            this.tb_Cashback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cashback.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Cashback.Location = new System.Drawing.Point(591, 67);
            this.tb_Cashback.Name = "tb_Cashback";
            this.tb_Cashback.Size = new System.Drawing.Size(268, 30);
            this.tb_Cashback.TabIndex = 4;
            // 
            // bt_Done
            // 
            this.bt_Done.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Done.Location = new System.Drawing.Point(728, 129);
            this.bt_Done.Name = "bt_Done";
            this.bt_Done.Size = new System.Drawing.Size(131, 47);
            this.bt_Done.TabIndex = 6;
            this.bt_Done.Text = "Done";
            this.bt_Done.UseVisualStyleBackColor = false;
            this.bt_Done.Click += new System.EventHandler(this.bt_Done_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1006, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Or pay with";
            // 
            // btzalopay
            // 
            this.btzalopay.BackgroundImage = global::CoffeeShop.Properties.Resources.zalopay;
            this.btzalopay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btzalopay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btzalopay.Location = new System.Drawing.Point(1171, 69);
            this.btzalopay.Name = "btzalopay";
            this.btzalopay.Size = new System.Drawing.Size(109, 84);
            this.btzalopay.TabIndex = 10;
            this.btzalopay.UseVisualStyleBackColor = true;
            this.btzalopay.Click += new System.EventHandler(this.btzalopay_Click);
            // 
            // btmomo
            // 
            this.btmomo.BackgroundImage = global::CoffeeShop.Properties.Resources.momo;
            this.btmomo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmomo.Location = new System.Drawing.Point(926, 67);
            this.btmomo.Name = "btmomo";
            this.btmomo.Size = new System.Drawing.Size(109, 84);
            this.btmomo.TabIndex = 9;
            this.btmomo.UseVisualStyleBackColor = true;
            this.btmomo.Click += new System.EventHandler(this.btmomo_Click);
            // 
            // picboxqr
            // 
            this.picboxqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxqr.Location = new System.Drawing.Point(926, 222);
            this.picboxqr.Name = "picboxqr";
            this.picboxqr.Size = new System.Drawing.Size(354, 329);
            this.picboxqr.TabIndex = 11;
            this.picboxqr.TabStop = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1403, 563);
            this.Controls.Add(this.picboxqr);
            this.Controls.Add(this.btzalopay);
            this.Controls.Add(this.btmomo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Cashback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cashin);
            this.Controls.Add(this.listBox_Bill);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxqr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Bill;
        private System.Windows.Forms.TextBox tb_cashin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Cashback;
        private System.Windows.Forms.Button bt_Done;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btzalopay;
        private System.Windows.Forms.Button btmomo;
        private System.Windows.Forms.PictureBox picboxqr;
    }
}