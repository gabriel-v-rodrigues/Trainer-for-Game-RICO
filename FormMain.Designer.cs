namespace RICOTrainer
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            healthCheckbox = new CheckBox();
            ammoCheckbox = new CheckBox();
            label2 = new Label();
            status = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "RICO Trainer +2";
            // 
            // healthCheckbox
            // 
            healthCheckbox.AutoSize = true;
            healthCheckbox.Enabled = false;
            healthCheckbox.Location = new Point(37, 61);
            healthCheckbox.Name = "healthCheckbox";
            healthCheckbox.Size = new Size(101, 19);
            healthCheckbox.TabIndex = 1;
            healthCheckbox.Text = "Infinite Health";
            healthCheckbox.UseVisualStyleBackColor = true;
            healthCheckbox.CheckedChanged += HealthCheckbox_CheckedChanged;
            // 
            // ammoCheckbox
            // 
            ammoCheckbox.AutoSize = true;
            ammoCheckbox.Enabled = false;
            ammoCheckbox.Location = new Point(37, 86);
            ammoCheckbox.Name = "ammoCheckbox";
            ammoCheckbox.Size = new Size(103, 19);
            ammoCheckbox.TabIndex = 1;
            ammoCheckbox.Text = "Infinite Ammo";
            ammoCheckbox.UseVisualStyleBackColor = true;
            ammoCheckbox.CheckedChanged += AmmoCheckbox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 124);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Game: ";
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = Color.Red;
            status.Location = new Point(65, 124);
            status.Name = "status";
            status.Size = new Size(67, 15);
            status.TabIndex = 3;
            status.Text = "Not Found!";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(179, 156);
            Controls.Add(status);
            Controls.Add(label2);
            Controls.Add(ammoCheckbox);
            Controls.Add(healthCheckbox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            Text = "RICO Trainer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox healthCheckbox;
        private CheckBox ammoCheckbox;
        private Label label2;
        private Label status;
        public System.Windows.Forms.Timer timer1;
    }
}
