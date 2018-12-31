namespace Türsprechanlage
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelStatus3 = new System.Windows.Forms.Label();
            this.labelStatus4 = new System.Windows.Forms.Label();
            this.labelStatus5 = new System.Windows.Forms.Label();
            this.labelMqttStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.LightGray;
            this.labelPage.Location = new System.Drawing.Point(480, 38);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(87, 32);
            this.labelPage.TabIndex = 0;
            this.labelPage.Text = "Main";
            // 
            // buttonLeft
            // 
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLeft.Location = new System.Drawing.Point(133, 38);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 48);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRight.Location = new System.Drawing.Point(834, 41);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 48);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(209, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(625, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(209, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(625, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(209, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(625, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(209, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(625, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(209, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(625, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus1.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus1.Location = new System.Drawing.Point(840, 166);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(107, 32);
            this.labelStatus1.TabIndex = 8;
            this.labelStatus1.Text = "label1";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus2.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus2.Location = new System.Drawing.Point(840, 225);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(107, 32);
            this.labelStatus2.TabIndex = 9;
            this.labelStatus2.Text = "label1";
            // 
            // labelStatus3
            // 
            this.labelStatus3.AutoSize = true;
            this.labelStatus3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus3.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus3.Location = new System.Drawing.Point(840, 284);
            this.labelStatus3.Name = "labelStatus3";
            this.labelStatus3.Size = new System.Drawing.Size(107, 32);
            this.labelStatus3.TabIndex = 10;
            this.labelStatus3.Text = "label1";
            // 
            // labelStatus4
            // 
            this.labelStatus4.AutoSize = true;
            this.labelStatus4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus4.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus4.Location = new System.Drawing.Point(840, 343);
            this.labelStatus4.Name = "labelStatus4";
            this.labelStatus4.Size = new System.Drawing.Size(107, 32);
            this.labelStatus4.TabIndex = 11;
            this.labelStatus4.Text = "label1";
            // 
            // labelStatus5
            // 
            this.labelStatus5.AutoSize = true;
            this.labelStatus5.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus5.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus5.Location = new System.Drawing.Point(840, 402);
            this.labelStatus5.Name = "labelStatus5";
            this.labelStatus5.Size = new System.Drawing.Size(107, 32);
            this.labelStatus5.TabIndex = 12;
            this.labelStatus5.Text = "label1";
            // 
            // labelMqttStatus
            // 
            this.labelMqttStatus.AutoSize = true;
            this.labelMqttStatus.ForeColor = System.Drawing.Color.LightGray;
            this.labelMqttStatus.Location = new System.Drawing.Point(12, 578);
            this.labelMqttStatus.Name = "labelMqttStatus";
            this.labelMqttStatus.Size = new System.Drawing.Size(74, 13);
            this.labelMqttStatus.TabIndex = 13;
            this.labelMqttStatus.Text = "MQTT Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.ControlBox = false;
            this.Controls.Add(this.labelMqttStatus);
            this.Controls.Add(this.labelStatus5);
            this.Controls.Add(this.labelStatus4);
            this.Controls.Add(this.labelStatus3);
            this.Controls.Add(this.labelStatus2);
            this.Controls.Add(this.labelStatus1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelPage);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "TS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelStatus3;
        private System.Windows.Forms.Label labelStatus4;
        private System.Windows.Forms.Label labelStatus5;
        private System.Windows.Forms.Label labelMqttStatus;
    }
}

