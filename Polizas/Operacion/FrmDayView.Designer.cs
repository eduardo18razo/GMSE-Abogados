namespace Polizas.Operacion
{
    partial class FrmDayView
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
            Polizas.Controls.DrawTool drawTool1 = new Polizas.Controls.DrawTool();
            this.pnlAppoiment = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.avDay = new Polizas.Controls.DayView();
            this.pnlAppoiment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppoiment
            // 
            this.pnlAppoiment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAppoiment.Controls.Add(this.avDay);
            this.pnlAppoiment.Location = new System.Drawing.Point(12, 187);
            this.pnlAppoiment.Name = "pnlAppoiment";
            this.pnlAppoiment.Size = new System.Drawing.Size(919, 509);
            this.pnlAppoiment.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // avDay
            // 
            drawTool1.DayView = this.avDay;
            this.avDay.ActiveTool = drawTool1;
            this.avDay.DaysToShow = 5;
            this.avDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avDay.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.avDay.Location = new System.Drawing.Point(0, 0);
            this.avDay.Name = "avDay";
            this.avDay.SelectionEnd = new System.DateTime(((long)(0)));
            this.avDay.SelectionStart = new System.DateTime(((long)(0)));
            this.avDay.Size = new System.Drawing.Size(919, 509);
            this.avDay.StartDate = new System.DateTime(((long)(0)));
            this.avDay.TabIndex = 0;
            this.avDay.Text = "dayView1";
            this.avDay.SelectionChanged += new System.EventHandler(this.avDay_SelectionChanged);
            this.avDay.ResolveAppointments += new Polizas.Controls.ResolveAppointmentsEventHandler(this.avDay_ResolveAppointments);
            // 
            // FrmDayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 708);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pnlAppoiment);
            this.Name = "FrmDayView";
            this.Text = "FrmDayView";
            this.Load += new System.EventHandler(this.FrmDayView_Load);
            this.pnlAppoiment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppoiment;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Controls.DayView avDay;
    }
}