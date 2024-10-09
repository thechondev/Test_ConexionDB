namespace ConexionDB
{
    partial class WCrearcuenta
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
            this.cmdCrearcuenta = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.cmdinicio = new System.Windows.Forms.Button();
            this.dB_usersDataSet = new ConexionDB.DB_usersDataSet();
            this.usuarios_y_ContraseñasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios_y_ContraseñasTableAdapter = new ConexionDB.DB_usersDataSetTableAdapters.Usuarios_y_ContraseñasTableAdapter();
            this.tableAdapterManager = new ConexionDB.DB_usersDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dB_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_y_ContraseñasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCrearcuenta
            // 
            this.cmdCrearcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrearcuenta.Location = new System.Drawing.Point(103, 195);
            this.cmdCrearcuenta.Name = "cmdCrearcuenta";
            this.cmdCrearcuenta.Size = new System.Drawing.Size(83, 54);
            this.cmdCrearcuenta.TabIndex = 5;
            this.cmdCrearcuenta.Text = "Crear cuenta";
            this.cmdCrearcuenta.UseVisualStyleBackColor = true;
            this.cmdCrearcuenta.Click += new System.EventHandler(this.cmdCrearcuenta_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(12, 117);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(262, 26);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(12, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 26);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(12, 19);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(64, 20);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario";
            // 
            // cmdinicio
            // 
            this.cmdinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinicio.Location = new System.Drawing.Point(16, 335);
            this.cmdinicio.Name = "cmdinicio";
            this.cmdinicio.Size = new System.Drawing.Size(83, 54);
            this.cmdinicio.TabIndex = 6;
            this.cmdinicio.Text = "Volver a inicio";
            this.cmdinicio.UseVisualStyleBackColor = true;
            this.cmdinicio.Click += new System.EventHandler(this.cmdinicio_Click);
            // 
            // dB_usersDataSet
            // 
            this.dB_usersDataSet.DataSetName = "DB_usersDataSet";
            this.dB_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarios_y_ContraseñasBindingSource
            // 
            this.usuarios_y_ContraseñasBindingSource.DataMember = "Usuarios y Contraseñas";
            this.usuarios_y_ContraseñasBindingSource.DataSource = this.dB_usersDataSet;
            // 
            // usuarios_y_ContraseñasTableAdapter
            // 
            this.usuarios_y_ContraseñasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ConexionDB.DB_usersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usuarios_y_ContraseñasTableAdapter = this.usuarios_y_ContraseñasTableAdapter;
            // 
            // WCrearcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 401);
            this.Controls.Add(this.cmdinicio);
            this.Controls.Add(this.cmdCrearcuenta);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblusuario);
            this.Name = "WCrearcuenta";
            this.Text = "WCrearcuenta";
            this.Load += new System.EventHandler(this.WCrearcuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_y_ContraseñasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCrearcuenta;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button cmdinicio;
        private DB_usersDataSet dB_usersDataSet;
        private System.Windows.Forms.BindingSource usuarios_y_ContraseñasBindingSource;
        private DB_usersDataSetTableAdapters.Usuarios_y_ContraseñasTableAdapter usuarios_y_ContraseñasTableAdapter;
        private DB_usersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}