namespace GerenciamentoCaminhao.WinForms
{
    partial class frmCadastrarCaminhao
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label descricaoPracaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            System.Windows.Forms.Label numeroMotorLabel;
            System.Windows.Forms.Label numeroRenavanLabel;
            System.Windows.Forms.Label quantidadeCargaLabel;
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.registrarComandoCaminhaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.descricaoPracaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.numeroMotorTextBox = new System.Windows.Forms.TextBox();
            this.numeroRenavanTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeCargaTextBox = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            anoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            descricaoPracaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            numeroMotorLabel = new System.Windows.Forms.Label();
            numeroRenavanLabel = new System.Windows.Forms.Label();
            quantidadeCargaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrarComandoCaminhaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLabel.Location = new System.Drawing.Point(28, 107);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(42, 20);
            anoLabel.TabIndex = 1;
            anoLabel.Text = "Ano:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            corLabel.Location = new System.Drawing.Point(28, 142);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(38, 20);
            corLabel.TabIndex = 3;
            corLabel.Text = "Cor:";
            // 
            // descricaoPracaLabel
            // 
            descricaoPracaLabel.AutoSize = true;
            descricaoPracaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoPracaLabel.Location = new System.Drawing.Point(28, 177);
            descricaoPracaLabel.Name = "descricaoPracaLabel";
            descricaoPracaLabel.Size = new System.Drawing.Size(129, 20);
            descricaoPracaLabel.TabIndex = 5;
            descricaoPracaLabel.Text = "Descricao Praca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(28, 212);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(65, 20);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroChassisLabel.Location = new System.Drawing.Point(28, 247);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(129, 20);
            numeroChassisLabel.TabIndex = 9;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // numeroMotorLabel
            // 
            numeroMotorLabel.AutoSize = true;
            numeroMotorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroMotorLabel.Location = new System.Drawing.Point(28, 282);
            numeroMotorLabel.Name = "numeroMotorLabel";
            numeroMotorLabel.Size = new System.Drawing.Size(114, 20);
            numeroMotorLabel.TabIndex = 11;
            numeroMotorLabel.Text = "Numero Motor:";
            // 
            // numeroRenavanLabel
            // 
            numeroRenavanLabel.AutoSize = true;
            numeroRenavanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroRenavanLabel.Location = new System.Drawing.Point(28, 317);
            numeroRenavanLabel.Name = "numeroRenavanLabel";
            numeroRenavanLabel.Size = new System.Drawing.Size(137, 20);
            numeroRenavanLabel.TabIndex = 13;
            numeroRenavanLabel.Text = "Numero Renavan:";
            // 
            // quantidadeCargaLabel
            // 
            quantidadeCargaLabel.AutoSize = true;
            quantidadeCargaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeCargaLabel.Location = new System.Drawing.Point(28, 352);
            quantidadeCargaLabel.Name = "quantidadeCargaLabel";
            quantidadeCargaLabel.Size = new System.Drawing.Size(143, 20);
            quantidadeCargaLabel.TabIndex = 15;
            quantidadeCargaLabel.Text = "Quantidade Carga:";
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "Ano", true));
            this.anoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoTextBox.Location = new System.Drawing.Point(221, 101);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(318, 29);
            this.anoTextBox.TabIndex = 2;
            // 
            // registrarComandoCaminhaoBindingSource
            // 
            this.registrarComandoCaminhaoBindingSource.DataSource = typeof(GerenciamentoCaminhao.Dominio.Comandos.Entrada.RegistrarComandoCaminhao);
            this.registrarComandoCaminhaoBindingSource.CurrentChanged += new System.EventHandler(this.registrarComandoCaminhaoBindingSource_CurrentChanged);
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "Cor", true));
            this.corTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corTextBox.Location = new System.Drawing.Point(221, 136);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(318, 29);
            this.corTextBox.TabIndex = 4;
            // 
            // descricaoPracaTextBox
            // 
            this.descricaoPracaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "DescricaoPraca", true));
            this.descricaoPracaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoPracaTextBox.Location = new System.Drawing.Point(221, 171);
            this.descricaoPracaTextBox.Name = "descricaoPracaTextBox";
            this.descricaoPracaTextBox.Size = new System.Drawing.Size(318, 29);
            this.descricaoPracaTextBox.TabIndex = 6;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(221, 206);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(318, 29);
            this.modeloTextBox.TabIndex = 8;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(221, 241);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(318, 29);
            this.numeroChassisTextBox.TabIndex = 10;
            // 
            // numeroMotorTextBox
            // 
            this.numeroMotorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "NumeroMotor", true));
            this.numeroMotorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroMotorTextBox.Location = new System.Drawing.Point(221, 276);
            this.numeroMotorTextBox.Name = "numeroMotorTextBox";
            this.numeroMotorTextBox.Size = new System.Drawing.Size(318, 29);
            this.numeroMotorTextBox.TabIndex = 12;
            // 
            // numeroRenavanTextBox
            // 
            this.numeroRenavanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "NumeroRenavan", true));
            this.numeroRenavanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroRenavanTextBox.Location = new System.Drawing.Point(221, 311);
            this.numeroRenavanTextBox.Name = "numeroRenavanTextBox";
            this.numeroRenavanTextBox.Size = new System.Drawing.Size(318, 29);
            this.numeroRenavanTextBox.TabIndex = 14;
            // 
            // quantidadeCargaTextBox
            // 
            this.quantidadeCargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarComandoCaminhaoBindingSource, "QuantidadeCarga", true));
            this.quantidadeCargaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeCargaTextBox.Location = new System.Drawing.Point(221, 346);
            this.quantidadeCargaTextBox.Name = "quantidadeCargaTextBox";
            this.quantidadeCargaTextBox.Size = new System.Drawing.Size(318, 29);
            this.quantidadeCargaTextBox.TabIndex = 16;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(597, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 81);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastrarCaminhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(descricaoPracaLabel);
            this.Controls.Add(this.descricaoPracaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(numeroChassisLabel);
            this.Controls.Add(this.numeroChassisTextBox);
            this.Controls.Add(numeroMotorLabel);
            this.Controls.Add(this.numeroMotorTextBox);
            this.Controls.Add(numeroRenavanLabel);
            this.Controls.Add(this.numeroRenavanTextBox);
            this.Controls.Add(quantidadeCargaLabel);
            this.Controls.Add(this.quantidadeCargaTextBox);
            this.Name = "frmCadastrarCaminhao";
            this.Text = "frmCadastrarCaminhao";
            this.Load += new System.EventHandler(this.frmCadastrarCaminhao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrarComandoCaminhaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource registrarComandoCaminhaoBindingSource;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox descricaoPracaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.TextBox numeroMotorTextBox;
        private System.Windows.Forms.TextBox numeroRenavanTextBox;
        private System.Windows.Forms.TextBox quantidadeCargaTextBox;
        private System.Windows.Forms.Button btnSalvar;
    }
}