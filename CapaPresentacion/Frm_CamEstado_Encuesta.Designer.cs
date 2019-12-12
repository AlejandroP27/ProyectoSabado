namespace CapaPresentacion
{
    partial class Frm_CamEstado_Encuesta
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
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaini = new System.Windows.Forms.DateTimePicker();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdEncues = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(164, 57);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(219, 20);
            this.txtcliente.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Id Cliente";
            // 
            // dtpFechafin
            // 
            this.dtpFechafin.Location = new System.Drawing.Point(164, 225);
            this.dtpFechafin.Name = "dtpFechafin";
            this.dtpFechafin.Size = new System.Drawing.Size(219, 20);
            this.dtpFechafin.TabIndex = 44;
            // 
            // dtpFechaini
            // 
            this.dtpFechaini.Location = new System.Drawing.Point(164, 183);
            this.dtpFechaini.Name = "dtpFechaini";
            this.dtpFechaini.Size = new System.Drawing.Size(219, 20);
            this.dtpFechaini.TabIndex = 43;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(164, 135);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(219, 20);
            this.txtDescrip.TabIndex = 42;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 41;
            // 
            // txtIdEncues
            // 
            this.txtIdEncues.Location = new System.Drawing.Point(164, 23);
            this.txtIdEncues.Name = "txtIdEncues";
            this.txtIdEncues.Size = new System.Drawing.Size(219, 20);
            this.txtIdEncues.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Fecha Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id Encuesta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "Modificar Estado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_CamEstado_Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 335);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechafin);
            this.Controls.Add(this.dtpFechaini);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdEncues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_CamEstado_Encuesta";
            this.Text = "Frm_CamEstado_Encuesta";
            this.Load += new System.EventHandler(this.Frm_CamEstado_Encuesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.DateTimePicker dtpFechafin;
        public System.Windows.Forms.DateTimePicker dtpFechaini;
        public System.Windows.Forms.TextBox txtDescrip;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIdEncues;
    }
}