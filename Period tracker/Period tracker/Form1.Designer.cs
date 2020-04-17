namespace Period_tracker
{
    partial class PeriodTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodTracker));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOfLastPeriod = new System.Windows.Forms.DateTimePicker();
            this.cyleLenght = new System.Windows.Forms.TextBox();
            this.periodLenght = new System.Windows.Forms.TextBox();
            this.lblNextPeriod = new System.Windows.Forms.Label();
            this.lblFirstFertile = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblLastFertile = new System.Windows.Forms.Label();
            this.lblNextPeriodEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "On average, how long is your period?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(170, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(42, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "On average, how long is your cycle?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(170, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(54, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "When did your last period start?";
            // 
            // dateOfLastPeriod
            // 
            this.dateOfLastPeriod.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfLastPeriod.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dateOfLastPeriod.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dateOfLastPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfLastPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfLastPeriod.Location = new System.Drawing.Point(57, 310);
            this.dateOfLastPeriod.MaxDate = new System.DateTime(9919, 12, 29, 0, 0, 0, 0);
            this.dateOfLastPeriod.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateOfLastPeriod.Name = "dateOfLastPeriod";
            this.dateOfLastPeriod.Size = new System.Drawing.Size(224, 21);
            this.dateOfLastPeriod.TabIndex = 5;
            // 
            // cyleLenght
            // 
            this.cyleLenght.Location = new System.Drawing.Point(72, 208);
            this.cyleLenght.Name = "cyleLenght";
            this.cyleLenght.Size = new System.Drawing.Size(92, 20);
            this.cyleLenght.TabIndex = 6;
            // 
            // periodLenght
            // 
            this.periodLenght.Location = new System.Drawing.Point(67, 99);
            this.periodLenght.Name = "periodLenght";
            this.periodLenght.Size = new System.Drawing.Size(97, 20);
            this.periodLenght.TabIndex = 7;
            // 
            // lblNextPeriod
            // 
            this.lblNextPeriod.AutoSize = true;
            this.lblNextPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblNextPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPeriod.ForeColor = System.Drawing.Color.Purple;
            this.lblNextPeriod.Location = new System.Drawing.Point(42, 444);
            this.lblNextPeriod.Name = "lblNextPeriod";
            this.lblNextPeriod.Size = new System.Drawing.Size(217, 16);
            this.lblNextPeriod.TabIndex = 9;
            this.lblNextPeriod.Text = "Beginning of your next period :";
            // 
            // lblFirstFertile
            // 
            this.lblFirstFertile.AutoSize = true;
            this.lblFirstFertile.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstFertile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstFertile.ForeColor = System.Drawing.Color.Purple;
            this.lblFirstFertile.Location = new System.Drawing.Point(42, 516);
            this.lblFirstFertile.Name = "lblFirstFertile";
            this.lblFirstFertile.Size = new System.Drawing.Size(150, 16);
            this.lblFirstFertile.TabIndex = 10;
            this.lblFirstFertile.Text = "Your first fertile day :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Indigo;
            this.btnCalculate.Location = new System.Drawing.Point(121, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 28);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblLastFertile
            // 
            this.lblLastFertile.AutoSize = true;
            this.lblLastFertile.BackColor = System.Drawing.Color.Transparent;
            this.lblLastFertile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFertile.ForeColor = System.Drawing.Color.Purple;
            this.lblLastFertile.Location = new System.Drawing.Point(42, 542);
            this.lblLastFertile.Name = "lblLastFertile";
            this.lblLastFertile.Size = new System.Drawing.Size(150, 16);
            this.lblLastFertile.TabIndex = 12;
            this.lblLastFertile.Text = "Your last fertile day :";
            // 
            // lblNextPeriodEnd
            // 
            this.lblNextPeriodEnd.AutoSize = true;
            this.lblNextPeriodEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblNextPeriodEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPeriodEnd.ForeColor = System.Drawing.Color.Purple;
            this.lblNextPeriodEnd.Location = new System.Drawing.Point(42, 469);
            this.lblNextPeriodEnd.Name = "lblNextPeriodEnd";
            this.lblNextPeriodEnd.Size = new System.Drawing.Size(175, 16);
            this.lblNextPeriodEnd.TabIndex = 13;
            this.lblNextPeriodEnd.Text = "End of your next period :";
            // 
            // PeriodTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 596);
            this.Controls.Add(this.lblNextPeriodEnd);
            this.Controls.Add(this.lblLastFertile);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFirstFertile);
            this.Controls.Add(this.lblNextPeriod);
            this.Controls.Add(this.periodLenght);
            this.Controls.Add(this.cyleLenght);
            this.Controls.Add(this.dateOfLastPeriod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeriodTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Period and Ovulation Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateOfLastPeriod;
        private System.Windows.Forms.TextBox cyleLenght;
        private System.Windows.Forms.TextBox periodLenght;
        private System.Windows.Forms.Label lblNextPeriod;
        private System.Windows.Forms.Label lblFirstFertile;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblLastFertile;
        private System.Windows.Forms.Label lblNextPeriodEnd;
    }
}

