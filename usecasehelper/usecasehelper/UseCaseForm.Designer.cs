namespace usecasehelper
{
    partial class UseCaseForm
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbSamenvatting = new System.Windows.Forms.TextBox();
            this.tbAanamen = new System.Windows.Forms.TextBox();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.tbUitzondering = new System.Windows.Forms.TextBox();
            this.tbResultaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.clbActors = new System.Windows.Forms.CheckedListBox();
            this.lblInUse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(142, 12);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(349, 22);
            this.tbNaam.TabIndex = 1;
            // 
            // tbSamenvatting
            // 
            this.tbSamenvatting.Location = new System.Drawing.Point(142, 40);
            this.tbSamenvatting.Name = "tbSamenvatting";
            this.tbSamenvatting.Size = new System.Drawing.Size(349, 22);
            this.tbSamenvatting.TabIndex = 2;
            // 
            // tbAanamen
            // 
            this.tbAanamen.Location = new System.Drawing.Point(142, 187);
            this.tbAanamen.Name = "tbAanamen";
            this.tbAanamen.Size = new System.Drawing.Size(349, 22);
            this.tbAanamen.TabIndex = 4;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(142, 215);
            this.tbBeschrijving.Multiline = true;
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(349, 155);
            this.tbBeschrijving.TabIndex = 5;
            // 
            // tbUitzondering
            // 
            this.tbUitzondering.Location = new System.Drawing.Point(142, 376);
            this.tbUitzondering.Multiline = true;
            this.tbUitzondering.Name = "tbUitzondering";
            this.tbUitzondering.Size = new System.Drawing.Size(349, 155);
            this.tbUitzondering.TabIndex = 6;
            // 
            // tbResultaat
            // 
            this.tbResultaat.Location = new System.Drawing.Point(142, 537);
            this.tbResultaat.Name = "tbResultaat";
            this.tbResultaat.Size = new System.Drawing.Size(349, 22);
            this.tbResultaat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Samenvatting:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Actoren:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aanamen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Beschrijving:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uitzondering:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resultaat:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(415, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // clbActors
            // 
            this.clbActors.FormattingEnabled = true;
            this.clbActors.Location = new System.Drawing.Point(142, 68);
            this.clbActors.Name = "clbActors";
            this.clbActors.Size = new System.Drawing.Size(349, 106);
            this.clbActors.TabIndex = 15;
            // 
            // lblInUse
            // 
            this.lblInUse.AutoSize = true;
            this.lblInUse.BackColor = System.Drawing.SystemColors.Window;
            this.lblInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInUse.ForeColor = System.Drawing.Color.Red;
            this.lblInUse.Location = new System.Drawing.Point(338, 15);
            this.lblInUse.Name = "lblInUse";
            this.lblInUse.Size = new System.Drawing.Size(141, 17);
            this.lblInUse.TabIndex = 16;
            this.lblInUse.Text = "NAAM ONMOGELIJK";
            this.lblInUse.Visible = false;
            // 
            // UseCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 596);
            this.Controls.Add(this.lblInUse);
            this.Controls.Add(this.clbActors);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResultaat);
            this.Controls.Add(this.tbUitzondering);
            this.Controls.Add(this.tbBeschrijving);
            this.Controls.Add(this.tbAanamen);
            this.Controls.Add(this.tbSamenvatting);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblNaam);
            this.MinimumSize = new System.Drawing.Size(521, 527);
            this.Name = "UseCaseForm";
            this.Text = "UserCaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UseCaseForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbSamenvatting;
        private System.Windows.Forms.TextBox tbAanamen;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.TextBox tbUitzondering;
        private System.Windows.Forms.TextBox tbResultaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox clbActors;
        private System.Windows.Forms.Label lblInUse;
    }
}