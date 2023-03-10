namespace UPI_Restoran.Forms
{
    partial class TimeSelectionForm
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPocH = new System.Windows.Forms.NumericUpDown();
            this.numStartMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numEndMin = new System.Windows.Forms.NumericUpDown();
            this.numEndH = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPocH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndH)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePicker.Location = new System.Drawing.Point(237, 53);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 27);
            this.datePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite početak";
            // 
            // numPocH
            // 
            this.numPocH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numPocH.Location = new System.Drawing.Point(254, 144);
            this.numPocH.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numPocH.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPocH.Name = "numPocH";
            this.numPocH.Size = new System.Drawing.Size(51, 27);
            this.numPocH.TabIndex = 3;
            this.numPocH.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numStartMin
            // 
            this.numStartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numStartMin.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numStartMin.Location = new System.Drawing.Point(348, 144);
            this.numStartMin.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numStartMin.Name = "numStartMin";
            this.numStartMin.Size = new System.Drawing.Size(51, 27);
            this.numStartMin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(311, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(405, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(405, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(311, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "h";
            // 
            // numEndMin
            // 
            this.numEndMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numEndMin.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numEndMin.Location = new System.Drawing.Point(348, 196);
            this.numEndMin.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numEndMin.Name = "numEndMin";
            this.numEndMin.Size = new System.Drawing.Size(51, 27);
            this.numEndMin.TabIndex = 9;
            // 
            // numEndH
            // 
            this.numEndH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numEndH.Location = new System.Drawing.Point(254, 196);
            this.numEndH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numEndH.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEndH.Name = "numEndH";
            this.numEndH.Size = new System.Drawing.Size(51, 27);
            this.numEndH.TabIndex = 8;
            this.numEndH.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(78, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Odaberite kraj";
            // 
            // btnDalje
            // 
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalje.Location = new System.Drawing.Point(164, 280);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(106, 35);
            this.btnDalje.TabIndex = 12;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(276, 280);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(106, 35);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // TimeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 355);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numEndMin);
            this.Controls.Add(this.numEndH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numStartMin);
            this.Controls.Add(this.numPocH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Name = "TimeSelectionForm";
            this.Text = "Odaberi vrijeme";
            ((System.ComponentModel.ISupportInitialize)(this.numPocH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPocH;
        private System.Windows.Forms.NumericUpDown numStartMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numEndMin;
        private System.Windows.Forms.NumericUpDown numEndH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Button btnOdustani;
    }
}