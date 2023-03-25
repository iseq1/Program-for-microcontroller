namespace MicroControler
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConection1 = new System.Windows.Forms.Button();
            this.buttonUpdatePorts = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonConection2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConection1
            // 
            this.buttonConection1.Location = new System.Drawing.Point(519, 12);
            this.buttonConection1.Name = "buttonConection1";
            this.buttonConection1.Size = new System.Drawing.Size(211, 41);
            this.buttonConection1.TabIndex = 0;
            this.buttonConection1.Text = "Подключиться";
            this.buttonConection1.UseVisualStyleBackColor = true;
            this.buttonConection1.Click += new System.EventHandler(this.buttonConection1_Click);
            // 
            // buttonUpdatePorts
            // 
            this.buttonUpdatePorts.Location = new System.Drawing.Point(519, 106);
            this.buttonUpdatePorts.Name = "buttonUpdatePorts";
            this.buttonUpdatePorts.Size = new System.Drawing.Size(211, 41);
            this.buttonUpdatePorts.TabIndex = 1;
            this.buttonUpdatePorts.Text = "Обновить список портов";
            this.buttonUpdatePorts.UseVisualStyleBackColor = true;
            this.buttonUpdatePorts.Click += new System.EventHandler(this.buttonUpdatePorts_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(318, 21);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(195, 24);
            this.comboBoxPorts.TabIndex = 2;
            // 
            // buttonConection2
            // 
            this.buttonConection2.Location = new System.Drawing.Point(519, 59);
            this.buttonConection2.Name = "buttonConection2";
            this.buttonConection2.Size = new System.Drawing.Size(211, 41);
            this.buttonConection2.TabIndex = 3;
            this.buttonConection2.Text = "Подключиться 2";
            this.buttonConection2.UseVisualStyleBackColor = true;
            this.buttonConection2.Click += new System.EventHandler(this.buttonConection2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(27, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 116);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 131);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConection2);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonUpdatePorts);
            this.Controls.Add(this.buttonConection1);
            this.Name = "Form1";
            this.Text = "MicrocontrolerApp";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonConection2;

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConection1;
        private System.Windows.Forms.Button buttonUpdatePorts;
        private System.Windows.Forms.ComboBox comboBoxPorts;

        #endregion
    }
}