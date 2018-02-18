namespace Encuestas
{
    partial class frmGeneradorEncuestas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgEncuestas = new System.Windows.Forms.DataGridView();
            this.dgBloque = new System.Windows.Forms.DataGridView();
            this.dgPregunta = new System.Windows.Forms.DataGridView();
            this.txtNuevaEncuesta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEliminarEncuesta = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgEncuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBloque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encuestas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bloque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preguntas del Bloque";
            // 
            // dgEncuestas
            // 
            this.dgEncuestas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEncuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEncuestas.Location = new System.Drawing.Point(47, 210);
            this.dgEncuestas.Name = "dgEncuestas";
            this.dgEncuestas.Size = new System.Drawing.Size(353, 109);
            this.dgEncuestas.TabIndex = 5;
            // 
            // dgBloque
            // 
            this.dgBloque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBloque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBloque.Location = new System.Drawing.Point(465, 40);
            this.dgBloque.Name = "dgBloque";
            this.dgBloque.Size = new System.Drawing.Size(413, 188);
            this.dgBloque.TabIndex = 6;
            // 
            // dgPregunta
            // 
            this.dgPregunta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPregunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPregunta.Location = new System.Drawing.Point(465, 244);
            this.dgPregunta.Name = "dgPregunta";
            this.dgPregunta.Size = new System.Drawing.Size(413, 174);
            this.dgPregunta.TabIndex = 7;
            // 
            // txtNuevaEncuesta
            // 
            this.txtNuevaEncuesta.Location = new System.Drawing.Point(110, 12);
            this.txtNuevaEncuesta.Name = "txtNuevaEncuesta";
            this.txtNuevaEncuesta.Size = new System.Drawing.Size(26, 22);
            this.txtNuevaEncuesta.TabIndex = 8;
            this.txtNuevaEncuesta.Text = "+";
            this.txtNuevaEncuesta.UseVisualStyleBackColor = true;
            this.txtNuevaEncuesta.Click += new System.EventHandler(this.txtNuevaEncuesta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 22);
            this.button3.TabIndex = 10;
            this.button3.Text = "Nueva";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 22);
            this.button4.TabIndex = 11;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtEliminarEncuesta
            // 
            this.txtEliminarEncuesta.Location = new System.Drawing.Point(149, 12);
            this.txtEliminarEncuesta.Name = "txtEliminarEncuesta";
            this.txtEliminarEncuesta.Size = new System.Drawing.Size(26, 22);
            this.txtEliminarEncuesta.TabIndex = 12;
            this.txtEliminarEncuesta.Text = "-";
            this.txtEliminarEncuesta.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(361, 144);
            this.treeView1.TabIndex = 13;
            // 
            // frmGeneradorEncuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 477);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtEliminarEncuesta);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNuevaEncuesta);
            this.Controls.Add(this.dgPregunta);
            this.Controls.Add(this.dgBloque);
            this.Controls.Add(this.dgEncuestas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGeneradorEncuestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Encuestas ECOSUR 2018";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGeneradorEncuestas_FormClosed);
            this.Load += new System.EventHandler(this.frmGeneradorEncuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEncuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBloque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgEncuestas;
        private System.Windows.Forms.DataGridView dgBloque;
        private System.Windows.Forms.DataGridView dgPregunta;
        private System.Windows.Forms.Button txtNuevaEncuesta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button txtEliminarEncuesta;
        private System.Windows.Forms.TreeView treeView1;
    }
}

