namespace Project_Word_PDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            label1 = new Label();
            tbOriginPath = new TextBox();
            textError = new Label();
            label2 = new Label();
            tbDestinyPath = new TextBox();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(317, 322);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(155, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "TRANSFORMAR EM PDF";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 105);
            label1.Name = "label1";
            label1.Size = new Size(391, 15);
            label1.TabIndex = 1;
            label1.Text = "INSIRA ABAIXO O CAMINHO DO ARQUIVO QUE DESEJA TRANSFORMAR:";
            // 
            // tbOriginPath
            // 
            tbOriginPath.Location = new Point(197, 151);
            tbOriginPath.Name = "tbOriginPath";
            tbOriginPath.Size = new Size(391, 23);
            tbOriginPath.TabIndex = 2;
            // 
            // textError
            // 
            textError.AutoSize = true;
            textError.Location = new Point(379, 237);
            textError.Name = "textError";
            textError.Size = new Size(0, 15);
            textError.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 206);
            label2.Name = "label2";
            label2.Size = new Size(353, 15);
            label2.TabIndex = 4;
            label2.Text = "AGORA INSIRA A PASTA PARA ONDE DESEJA SALVAR O ARQUIVO:";
            // 
            // tbDestinyPath
            // 
            tbDestinyPath.Location = new Point(197, 255);
            tbDestinyPath.Name = "tbDestinyPath";
            tbDestinyPath.Size = new Size(391, 23);
            tbDestinyPath.TabIndex = 5;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.DarkBlue;
            lbTitle.Location = new Point(143, 26);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(513, 51);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "CONVERSOR DE ARQUIVOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTitle);
            Controls.Add(tbDestinyPath);
            Controls.Add(label2);
            Controls.Add(textError);
            Controls.Add(tbOriginPath);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label label1;
        private TextBox tbOriginPath;
        private Label textError;
        private Label label2;
        private TextBox tbDestinyPath;
        private Label lbTitle;
    }
}