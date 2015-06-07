namespace d4launcher
{
    partial class Launcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.comboBoxRes = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.checkBoxVsync = new System.Windows.Forms.CheckBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxShadows = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::d4launcher.Properties.Resources.Splash;
            this.pictureBox1.InitialImage = global::d4launcher.Properties.Resources.Splash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 375);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(185, 401);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(60, 13);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "Resolution:";
            // 
            // comboBoxRes
            // 
            this.comboBoxRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRes.FormattingEnabled = true;
            this.comboBoxRes.Location = new System.Drawing.Point(298, 398);
            this.comboBoxRes.Name = "comboBoxRes";
            this.comboBoxRes.Size = new System.Drawing.Size(148, 21);
            this.comboBoxRes.TabIndex = 2;
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Location = new System.Drawing.Point(188, 443);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(74, 17);
            this.checkBoxFullscreen.TabIndex = 5;
            this.checkBoxFullscreen.Text = "Fullscreen";
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxVsync
            // 
            this.checkBoxVsync.AutoSize = true;
            this.checkBoxVsync.Location = new System.Drawing.Point(290, 443);
            this.checkBoxVsync.Name = "checkBoxVsync";
            this.checkBoxVsync.Size = new System.Drawing.Size(58, 17);
            this.checkBoxVsync.TabIndex = 6;
            this.checkBoxVsync.Text = "V-sync";
            this.checkBoxVsync.UseVisualStyleBackColor = true;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(563, 441);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 7;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 441);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxShadows
            // 
            this.checkBoxShadows.AutoSize = true;
            this.checkBoxShadows.Location = new System.Drawing.Point(376, 443);
            this.checkBoxShadows.Name = "checkBoxShadows";
            this.checkBoxShadows.Size = new System.Drawing.Size(70, 17);
            this.checkBoxShadows.TabIndex = 9;
            this.checkBoxShadows.Text = "Shadows";
            this.checkBoxShadows.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 476);
            this.Controls.Add(this.checkBoxShadows);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.checkBoxVsync);
            this.Controls.Add(this.checkBoxFullscreen);
            this.Controls.Add(this.comboBoxRes);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "D4 Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.ComboBox comboBoxRes;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox checkBoxFullscreen;
        private System.Windows.Forms.CheckBox checkBoxVsync;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxShadows;
    }
}

