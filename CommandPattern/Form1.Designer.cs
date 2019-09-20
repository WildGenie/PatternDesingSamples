namespace WindowsFormsApp7
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioDevice1 = new WindowsFormsApp7.RadioDevice();
            this.tvDevice1 = new WindowsFormsApp7.TvDevice();
            this.pOnAllCommand = new WindowsFormsApp7.CommandButton();
            this.pOffAllCommand = new WindowsFormsApp7.CommandButton();
            this.vUpAllCommand = new WindowsFormsApp7.CommandButton();
            this.vDownAllCommand = new WindowsFormsApp7.CommandButton();
            this.uCommand = new WindowsFormsApp7.CommandButton();
            this.uAllCommand = new WindowsFormsApp7.CommandButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pOnAllCommand);
            this.flowLayoutPanel1.Controls.Add(this.pOffAllCommand);
            this.flowLayoutPanel1.Controls.Add(this.vUpAllCommand);
            this.flowLayoutPanel1.Controls.Add(this.vDownAllCommand);
            this.flowLayoutPanel1.Controls.Add(this.uCommand);
            this.flowLayoutPanel1.Controls.Add(this.uAllCommand);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(572, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 349);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // radioDevice1
            // 
            this.radioDevice1.BackColor = System.Drawing.Color.AliceBlue;
            this.radioDevice1.DeviceName = "Radio";
            this.radioDevice1.Location = new System.Drawing.Point(304, 64);
            this.radioDevice1.Name = "radioDevice1";
            this.radioDevice1.Size = new System.Drawing.Size(200, 200);
            this.radioDevice1.State = false;
            this.radioDevice1.TabIndex = 2;
            this.radioDevice1.Text = "radioDevice1";
            this.radioDevice1.Volume = 5;
            // 
            // tvDevice1
            // 
            this.tvDevice1.BackColor = System.Drawing.Color.AliceBlue;
            this.tvDevice1.DeviceName = "Tv";
            this.tvDevice1.Location = new System.Drawing.Point(84, 64);
            this.tvDevice1.Name = "tvDevice1";
            this.tvDevice1.Size = new System.Drawing.Size(200, 200);
            this.tvDevice1.State = false;
            this.tvDevice1.TabIndex = 0;
            this.tvDevice1.Text = "tvDevice1";
            this.tvDevice1.Volume = 5;
            // 
            // pOnAllCommand
            // 
            this.pOnAllCommand.Location = new System.Drawing.Point(3, 3);
            this.pOnAllCommand.Name = "pOnAllCommand";
            this.pOnAllCommand.Size = new System.Drawing.Size(120, 80);
            this.pOnAllCommand.TabIndex = 0;
            this.pOnAllCommand.Text = "Power On All";
            this.pOnAllCommand.UseVisualStyleBackColor = true;
            // 
            // pOffAllCommand
            // 
            this.pOffAllCommand.Location = new System.Drawing.Point(129, 3);
            this.pOffAllCommand.Name = "pOffAllCommand";
            this.pOffAllCommand.Size = new System.Drawing.Size(120, 80);
            this.pOffAllCommand.TabIndex = 1;
            this.pOffAllCommand.Text = "Power Off All";
            this.pOffAllCommand.UseVisualStyleBackColor = true;
            // 
            // vUpAllCommand
            // 
            this.vUpAllCommand.Location = new System.Drawing.Point(3, 89);
            this.vUpAllCommand.Name = "vUpAllCommand";
            this.vUpAllCommand.Size = new System.Drawing.Size(120, 80);
            this.vUpAllCommand.TabIndex = 2;
            this.vUpAllCommand.Text = "Volume Up All";
            this.vUpAllCommand.UseVisualStyleBackColor = true;
            // 
            // vDownAllCommand
            // 
            this.vDownAllCommand.Location = new System.Drawing.Point(129, 89);
            this.vDownAllCommand.Name = "vDownAllCommand";
            this.vDownAllCommand.Size = new System.Drawing.Size(120, 80);
            this.vDownAllCommand.TabIndex = 3;
            this.vDownAllCommand.Text = "Volume Down All";
            this.vDownAllCommand.UseVisualStyleBackColor = true;
            // 
            // uCommand
            // 
            this.uCommand.Location = new System.Drawing.Point(3, 175);
            this.uCommand.Name = "uCommand";
            this.uCommand.Size = new System.Drawing.Size(120, 80);
            this.uCommand.TabIndex = 4;
            this.uCommand.Text = "Undo";
            this.uCommand.UseVisualStyleBackColor = true;
            // 
            // uAllCommand
            // 
            this.uAllCommand.Location = new System.Drawing.Point(129, 175);
            this.uAllCommand.Name = "uAllCommand";
            this.uAllCommand.Size = new System.Drawing.Size(120, 80);
            this.uAllCommand.TabIndex = 5;
            this.uAllCommand.Text = "Undo All";
            this.uAllCommand.UseVisualStyleBackColor = true;
            this.uAllCommand.Click += new System.EventHandler(this.commandButton6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 607);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radioDevice1);
            this.Controls.Add(this.tvDevice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TvDevice tvDevice1;
        private RadioDevice radioDevice1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CommandButton pOnAllCommand;
        private CommandButton pOffAllCommand;
        private CommandButton vUpAllCommand;
        private CommandButton vDownAllCommand;
        private CommandButton uCommand;
        private CommandButton uAllCommand;
    }
}

