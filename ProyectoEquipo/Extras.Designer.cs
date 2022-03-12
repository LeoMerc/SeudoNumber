
namespace ProyectoEquipo
{
    partial class Extras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extras));
            this.btnv = new System.Windows.Forms.Button();
            this.btni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnv
            // 
            this.btnv.Location = new System.Drawing.Point(64, 43);
            this.btnv.Name = "btnv";
            this.btnv.Size = new System.Drawing.Size(116, 59);
            this.btnv.TabIndex = 2;
            this.btnv.Text = "Datos Volados";
            this.btnv.UseVisualStyleBackColor = true;
            this.btnv.Click += new System.EventHandler(this.btnv_Click);
            // 
            // btni
            // 
            this.btni.Location = new System.Drawing.Point(64, 123);
            this.btni.Name = "btni";
            this.btni.Size = new System.Drawing.Size(116, 59);
            this.btni.TabIndex = 3;
            this.btni.Text = "Datos Inventarios";
            this.btni.UseVisualStyleBackColor = true;
            this.btni.Click += new System.EventHandler(this.btni_Click);
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(242, 226);
            this.Controls.Add(this.btni);
            this.Controls.Add(this.btnv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extras";
            this.Load += new System.EventHandler(this.Extras_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnv;
        private System.Windows.Forms.Button btni;
    }
}