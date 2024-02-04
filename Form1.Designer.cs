
namespace _3_Reinbursment_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartingMileAge = new System.Windows.Forms.NumericUpDown();
            this.EndingMileAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayMiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartingMileAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingMileAge)).BeginInit();
            this.SuspendLayout();
            // 
            // StartingMileAge
            // 
            this.StartingMileAge.Location = new System.Drawing.Point(113, 29);
            this.StartingMileAge.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StartingMileAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingMileAge.Name = "StartingMileAge";
            this.StartingMileAge.Size = new System.Drawing.Size(120, 20);
            this.StartingMileAge.TabIndex = 0;
            this.StartingMileAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndingMileAge
            // 
            this.EndingMileAge.Location = new System.Drawing.Point(113, 72);
            this.EndingMileAge.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EndingMileAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndingMileAge.Name = "EndingMileAge";
            this.EndingMileAge.Size = new System.Drawing.Size(120, 20);
            this.EndingMileAge.TabIndex = 1;
            this.EndingMileAge.TabStop = false;
            this.EndingMileAge.Tag = "";
            this.EndingMileAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Mileage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Owed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayMiles
            // 
            this.DisplayMiles.Location = new System.Drawing.Point(135, 169);
            this.DisplayMiles.Name = "DisplayMiles";
            this.DisplayMiles.Size = new System.Drawing.Size(102, 23);
            this.DisplayMiles.TabIndex = 7;
            this.DisplayMiles.Text = "Display Miles";
            this.DisplayMiles.UseVisualStyleBackColor = true;
            this.DisplayMiles.Click += new System.EventHandler(this.DisplayMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 250);
            this.Controls.Add(this.DisplayMiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndingMileAge);
            this.Controls.Add(this.StartingMileAge);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartingMileAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingMileAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown StartingMileAge;
        private System.Windows.Forms.NumericUpDown EndingMileAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisplayMiles;
    }
}

