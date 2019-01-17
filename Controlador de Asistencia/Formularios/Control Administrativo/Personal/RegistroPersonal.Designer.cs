namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Personal
{
    partial class RegistroPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPersonal));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxApellidos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodigoAux = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDep = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareDatabaseDataSet = new Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSet();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.departamentosTableAdapter = new Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSetTableAdapters.DepartamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxName.Border.Class = "TextBoxBorder";
            this.textBoxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(74, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxApellidos.Border.Class = "TextBoxBorder";
            this.textBoxApellidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxApellidos.ForeColor = System.Drawing.Color.Black;
            this.textBoxApellidos.Location = new System.Drawing.Point(74, 39);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(238, 22);
            this.textBoxApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            // 
            // 
            // 
            this.textBoxTelefono.BackgroundStyle.Class = "TextBoxBorder";
            this.textBoxTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTelefono.ButtonClear.Visible = true;
            this.textBoxTelefono.Location = new System.Drawing.Point(74, 67);
            this.textBoxTelefono.Mask = "000-000-0000";
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(108, 21);
            this.textBoxTelefono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.textBoxTelefono.TabIndex = 5;
            this.textBoxTelefono.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código Auxiliar:";
            // 
            // textBoxCodigoAux
            // 
            this.textBoxCodigoAux.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxCodigoAux.Border.Class = "TextBoxBorder";
            this.textBoxCodigoAux.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCodigoAux.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCodigoAux.ForeColor = System.Drawing.Color.Black;
            this.textBoxCodigoAux.Location = new System.Drawing.Point(107, 96);
            this.textBoxCodigoAux.MaxLength = 5;
            this.textBoxCodigoAux.Name = "textBoxCodigoAux";
            this.textBoxCodigoAux.Size = new System.Drawing.Size(205, 22);
            this.textBoxCodigoAux.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamento:";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDep.DataSource = this.departamentosBindingSource;
            this.comboBoxDep.DisplayMember = "Nombre";
            this.comboBoxDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.ItemHeight = 16;
            this.comboBoxDep.Location = new System.Drawing.Point(102, 124);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(210, 22);
            this.comboBoxDep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxDep.TabIndex = 9;
            this.comboBoxDep.ValueMember = "idDepartamento";
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.softwareDatabaseDataSet;
            // 
            // softwareDatabaseDataSet
            // 
            this.softwareDatabaseDataSet.DataSetName = "SoftwareDatabaseDataSet";
            this.softwareDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // progressBarX1
            // 
            this.progressBarX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(324, 250);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(289, 23);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX1.TabIndex = 10;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(367, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.buttonX1.Location = new System.Drawing.Point(15, 316);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(598, 68);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 30F;
            this.buttonX1.TabIndex = 12;
            this.buttonX1.Text = "Registrar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCodigoAux);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroPersonal_FormClosing);
            this.Load += new System.EventHandler(this.RegistroPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv textBoxTelefono;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCodigoAux;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxDep;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private Base_de_Datos.SoftwareDatabaseDataSet softwareDatabaseDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Base_de_Datos.SoftwareDatabaseDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
    }
}