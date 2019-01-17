namespace Controlador_de_Asistencia.Formularios.Control_Administrativo.Personal
{
    partial class ActualizaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizaPersonal));
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.comboBoxDep = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareDatabaseDataSet = new Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodigoAux = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.departamentosTableAdapter = new Controlador_de_Asistencia.Base_de_Datos.SoftwareDatabaseDataSetTableAdapters.DepartamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.buttonX1.Location = new System.Drawing.Point(52, 165);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(248, 68);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 30F;
            this.buttonX1.TabIndex = 25;
            this.buttonX1.Text = "Actualizar Datos";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(367, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarX1
            // 
            this.progressBarX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(324, 251);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(289, 23);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX1.TabIndex = 23;
            this.progressBarX1.Text = "progressBarX1";
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
            this.comboBoxDep.Location = new System.Drawing.Point(102, 125);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(210, 22);
            this.comboBoxDep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxDep.TabIndex = 22;
            this.comboBoxDep.ValueMember = "idDepartamento";
            this.comboBoxDep.SelectedIndexChanged += new System.EventHandler(this.comboBoxDep_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Departamento:";
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
            this.textBoxCodigoAux.Location = new System.Drawing.Point(107, 97);
            this.textBoxCodigoAux.MaxLength = 5;
            this.textBoxCodigoAux.Name = "textBoxCodigoAux";
            this.textBoxCodigoAux.Size = new System.Drawing.Size(205, 22);
            this.textBoxCodigoAux.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Código Auxiliar:";
            // 
            // textBoxTelefono
            // 
            // 
            // 
            // 
            this.textBoxTelefono.BackgroundStyle.Class = "TextBoxBorder";
            this.textBoxTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTelefono.ButtonClear.Visible = true;
            this.textBoxTelefono.Location = new System.Drawing.Point(74, 68);
            this.textBoxTelefono.Mask = "000-000-0000";
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(108, 21);
            this.textBoxTelefono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.textBoxTelefono.TabIndex = 18;
            this.textBoxTelefono.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Teléfono:";
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
            this.textBoxApellidos.Location = new System.Drawing.Point(74, 40);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(238, 22);
            this.textBoxApellidos.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellidos:";
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
            this.textBoxName.Location = new System.Drawing.Point(74, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 22);
            this.textBoxName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombres:";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.buttonX2.Location = new System.Drawing.Point(340, 280);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX2.Size = new System.Drawing.Size(248, 68);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 30F;
            this.buttonX2.TabIndex = 26;
            this.buttonX2.Text = "Actualizar Huella Biométrica";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // ActualizaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 363);
            this.Controls.Add(this.buttonX2);
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
            this.Name = "ActualizaPersonal";
            this.Text = "Actualizar Información del Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizaPersonal_FormClosing);
            this.Load += new System.EventHandler(this.ActualizaPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxDep;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCodigoAux;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv textBoxTelefono;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxApellidos;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxName;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private Base_de_Datos.SoftwareDatabaseDataSet softwareDatabaseDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Base_de_Datos.SoftwareDatabaseDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
    }
}