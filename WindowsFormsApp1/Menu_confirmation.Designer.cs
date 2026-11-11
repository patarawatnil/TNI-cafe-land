namespace WindowsFormsApp1
{
    partial class Menu_confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_confirmation));
            this.confirm = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_price_text = new System.Windows.Forms.Label();
            this.discount_text = new System.Windows.Forms.Label();
            this.total_net_text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirm.Location = new System.Drawing.Point(352, 237);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(260, 60);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "ยืนยัน";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancle
            // 
            this.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancle.Location = new System.Drawing.Point(15, 237);
            this.cancle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(304, 60);
            this.cancle.TabIndex = 2;
            this.cancle.Text = "ยกเลิก";
            this.cancle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "กรุณาตรวจสอบความถูกต้องของรายการก่อนทำการยืนยันอีกครั้ง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ราคารวม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ส่วนลด";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ราคาสุทธิ";
            // 
            // total_price_text
            // 
            this.total_price_text.BackColor = System.Drawing.Color.Transparent;
            this.total_price_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.total_price_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.total_price_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total_price_text.Location = new System.Drawing.Point(105, 66);
            this.total_price_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_price_text.Name = "total_price_text";
            this.total_price_text.Size = new System.Drawing.Size(471, 35);
            this.total_price_text.TabIndex = 7;
            this.total_price_text.Text = "บาท";
            this.total_price_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discount_text
            // 
            this.discount_text.BackColor = System.Drawing.Color.Transparent;
            this.discount_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.discount_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.discount_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discount_text.Location = new System.Drawing.Point(158, 102);
            this.discount_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discount_text.Name = "discount_text";
            this.discount_text.Size = new System.Drawing.Size(418, 35);
            this.discount_text.TabIndex = 8;
            this.discount_text.Text = "บาท";
            this.discount_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // total_net_text
            // 
            this.total_net_text.BackColor = System.Drawing.Color.Transparent;
            this.total_net_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.total_net_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.total_net_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total_net_text.Location = new System.Drawing.Point(110, 138);
            this.total_net_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_net_text.Name = "total_net_text";
            this.total_net_text.Size = new System.Drawing.Size(466, 35);
            this.total_net_text.TabIndex = 9;
            this.total_net_text.Text = "บาท";
            this.total_net_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(66, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 10;
            // 
            // Menu_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(641, 313);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_net_text);
            this.Controls.Add(this.discount_text);
            this.Controls.Add(this.total_price_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.confirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu_confirmation";
            this.Text = "Menu Confirmation";
            this.Load += new System.EventHandler(this.Menu_confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_price_text;
        private System.Windows.Forms.Label discount_text;
        private System.Windows.Forms.Label total_net_text;
        private System.Windows.Forms.Label label5;
    }
}