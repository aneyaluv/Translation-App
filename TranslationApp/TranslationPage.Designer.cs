namespace TranslationApp

{
    partial class TranslationPage
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
            this.CmbTargetLang = new System.Windows.Forms.ComboBox();
            this.TranslationTimer = new System.Windows.Forms.Timer(this.components);
            this.circularBtnBack = new TranslationApp.CircularButton();
            this.BtnSpeakOutput = new TranslationApp.CircularButton();
            this.BtnSpeakInput = new TranslationApp.CircularButton();
            this.TxtOutput = new TranslationApp.CenteredTextBox();
            this.roundedPanel2 = new TranslationApp.RoundedPanel();
            this.roundedPanel1 = new TranslationApp.RoundedPanel();
            this.CmbSourceLang = new System.Windows.Forms.ComboBox();
            this.TxtInput = new TranslationApp.CenteredTextBox();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbTargetLang
            // 
            this.CmbTargetLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.CmbTargetLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTargetLang.DropDownHeight = 200;
            this.CmbTargetLang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbTargetLang.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.CmbTargetLang.ForeColor = System.Drawing.SystemColors.Window;
            this.CmbTargetLang.FormattingEnabled = true;
            this.CmbTargetLang.IntegralHeight = false;
            this.CmbTargetLang.Location = new System.Drawing.Point(596, 85);
            this.CmbTargetLang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CmbTargetLang.MaxDropDownItems = 5;
            this.CmbTargetLang.Name = "CmbTargetLang";
            this.CmbTargetLang.Size = new System.Drawing.Size(236, 33);
            this.CmbTargetLang.TabIndex = 2;
            // 
            // TranslationTimer
            // 
            this.TranslationTimer.Interval = 3000;
            this.TranslationTimer.Tick += new System.EventHandler(this.TranslationTimer_Tick);
            // 
            // circularBtnBack
            // 
            this.circularBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.circularBtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.circularBtnBack.FlatAppearance.BorderSize = 0;
            this.circularBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularBtnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.circularBtnBack.Image = global::TranslationApp.Properties.Resources.icons8_back_30;
            this.circularBtnBack.Location = new System.Drawing.Point(26, 6);
            this.circularBtnBack.Name = "circularBtnBack";
            this.circularBtnBack.Size = new System.Drawing.Size(38, 47);
            this.circularBtnBack.TabIndex = 7;
            this.circularBtnBack.UseVisualStyleBackColor = false;
            this.circularBtnBack.Click += new System.EventHandler(this.circularBtnBack_Click);
            // 
            // BtnSpeakOutput
            // 
            this.BtnSpeakOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.BtnSpeakOutput.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSpeakOutput.FlatAppearance.BorderSize = 0;
            this.BtnSpeakOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpeakOutput.Image = global::TranslationApp.Properties.Resources.icons8_mic_30aa;
            this.BtnSpeakOutput.Location = new System.Drawing.Point(997, 372);
            this.BtnSpeakOutput.Name = "BtnSpeakOutput";
            this.BtnSpeakOutput.Size = new System.Drawing.Size(60, 60);
            this.BtnSpeakOutput.TabIndex = 1;
            this.BtnSpeakOutput.UseVisualStyleBackColor = false;
            this.BtnSpeakOutput.Click += new System.EventHandler(this.BtnSpeakOutput_Click);
            // 
            // BtnSpeakInput
            // 
            this.BtnSpeakInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.BtnSpeakInput.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSpeakInput.FlatAppearance.BorderSize = 0;
            this.BtnSpeakInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpeakInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSpeakInput.Image = global::TranslationApp.Properties.Resources.icons8_mic_30aa;
            this.BtnSpeakInput.Location = new System.Drawing.Point(444, 372);
            this.BtnSpeakInput.Name = "BtnSpeakInput";
            this.BtnSpeakInput.Size = new System.Drawing.Size(60, 60);
            this.BtnSpeakInput.TabIndex = 0;
            this.BtnSpeakInput.UseVisualStyleBackColor = false;
            this.BtnSpeakInput.Click += new System.EventHandler(this.BtnSpeakInput_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.TxtOutput.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.TxtOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtOutput.Location = new System.Drawing.Point(596, 103);
            this.TxtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(482, 340);
            this.TxtOutput.TabIndex = 3;
            this.TxtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.roundedPanel2.Location = new System.Drawing.Point(576, 58);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(520, 401);
            this.roundedPanel2.TabIndex = 6;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.roundedPanel1.Controls.Add(this.CmbSourceLang);
            this.roundedPanel1.Controls.Add(this.TxtInput);
            this.roundedPanel1.Location = new System.Drawing.Point(26, 58);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(520, 401);
            this.roundedPanel1.TabIndex = 5;
            // 
            // CmbSourceLang
            // 
            this.CmbSourceLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.CmbSourceLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbSourceLang.DropDownHeight = 200;
            this.CmbSourceLang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbSourceLang.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.CmbSourceLang.ForeColor = System.Drawing.SystemColors.Window;
            this.CmbSourceLang.FormattingEnabled = true;
            this.CmbSourceLang.IntegralHeight = false;
            this.CmbSourceLang.Location = new System.Drawing.Point(18, 27);
            this.CmbSourceLang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CmbSourceLang.MaxDropDownItems = 5;
            this.CmbSourceLang.Name = "CmbSourceLang";
            this.CmbSourceLang.Size = new System.Drawing.Size(236, 33);
            this.CmbSourceLang.TabIndex = 7;
            // 
            // TxtInput
            // 
            this.TxtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.TxtInput.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.TxtInput.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtInput.Location = new System.Drawing.Point(18, 45);
            this.TxtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(482, 340);
            this.TxtInput.TabIndex = 7;
            this.TxtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TranslationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1124, 481);
            this.Controls.Add(this.circularBtnBack);
            this.Controls.Add(this.CmbTargetLang);
            this.Controls.Add(this.BtnSpeakOutput);
            this.Controls.Add(this.BtnSpeakInput);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "TranslationPage";
            this.Text = "Form1";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TranslationTimer;
        private System.Windows.Forms.ComboBox CmbSourceLang;
        private System.Windows.Forms.ComboBox CmbTargetLang;
        private CircularButton BtnSpeakOutput;
        private CenteredTextBox TxtOutput;
        private CircularButton BtnSpeakInput;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private CenteredTextBox TxtInput;
        private CircularButton circularBtnBack;
    }
}

