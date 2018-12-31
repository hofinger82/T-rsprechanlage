namespace Türsprechanlage
{
    partial class DoorCam
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
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.streamPlayerControl1 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.buttonOpenDoor = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRight
            // 
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRight.Location = new System.Drawing.Point(822, 15);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 48);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLeft.Location = new System.Drawing.Point(121, 12);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 48);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.LightGray;
            this.labelPage.Location = new System.Drawing.Point(468, 12);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(135, 32);
            this.labelPage.TabIndex = 3;
            this.labelPage.Text = "Haustür";
            // 
            // streamPlayerControl1
            // 
            this.streamPlayerControl1.BackColor = System.Drawing.Color.DimGray;
            this.streamPlayerControl1.Location = new System.Drawing.Point(12, 66);
            this.streamPlayerControl1.Name = "streamPlayerControl1";
            this.streamPlayerControl1.Size = new System.Drawing.Size(768, 450);
            this.streamPlayerControl1.TabIndex = 6;
            // 
            // buttonOpenDoor
            // 
            this.buttonOpenDoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenDoor.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenDoor.Location = new System.Drawing.Point(787, 220);
            this.buttonOpenDoor.Name = "buttonOpenDoor";
            this.buttonOpenDoor.Size = new System.Drawing.Size(209, 175);
            this.buttonOpenDoor.TabIndex = 7;
            this.buttonOpenDoor.Text = "Tür öffnen";
            this.buttonOpenDoor.UseVisualStyleBackColor = true;
            this.buttonOpenDoor.Click += new System.EventHandler(this.buttonOpenDoor_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(787, 483);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(209, 33);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "raus";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DoorCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOpenDoor);
            this.Controls.Add(this.streamPlayerControl1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelPage);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoorCam";
            this.Text = "DoorCam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label labelPage;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl streamPlayerControl1;
        private System.Windows.Forms.Button buttonOpenDoor;
        private System.Windows.Forms.Button buttonExit;
    }
}