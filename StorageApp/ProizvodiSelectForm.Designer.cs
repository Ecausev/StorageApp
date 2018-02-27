namespace StorageApp
{
    partial class ProizvodiSelectForm
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
            this.ucProizvodi1 = new StorageApp.ucProizvodi();
            this.SuspendLayout();
            // 
            // ucProizvodi1
            // 
            this.ucProizvodi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProizvodi1.Location = new System.Drawing.Point(0, 0);
            this.ucProizvodi1.Name = "ucProizvodi1";
            this.ucProizvodi1.Size = new System.Drawing.Size(822, 473);
            this.ucProizvodi1.TabIndex = 0;
            this.ucProizvodi1.OnSelectProduct += new System.EventHandler(this.ucProizvodi1_OnSelectProduct);
            this.ucProizvodi1.OnProductSelected += new System.EventHandler<StorageApp.ProductSelectedEventArgs>(this.ucProizvodi1_OnProductSelected);
            this.ucProizvodi1.Load += new System.EventHandler(this.ucProizvodi1_Load);
            // 
            // ProizvodiSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.ucProizvodi1);
            this.Name = "ProizvodiSelectForm";
            this.Text = "ProizvodiSelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ucProizvodi ucProizvodi1;
    }
}