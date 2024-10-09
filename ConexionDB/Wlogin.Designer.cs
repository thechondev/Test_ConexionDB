namespace ConexionDB
{
    partial class Wlogin
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
            this.components = new System.ComponentModel.Container();
            this.lblusuario = new System.Windows.Forms.Label();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCrearcuenta = new System.Windows.Forms.Button();
            this.dB_usersDataSet = new ConexionDB.DB_usersDataSet();
            this.usuarios_y_ContraseñasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios_y_ContraseñasTableAdapter = new ConexionDB.DB_usersDataSetTableAdapters.Usuarios_y_ContraseñasTableAdapter();
            this.tableAdapterManager = new ConexionDB.DB_usersDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dB_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_y_ContraseñasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(12, 11);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(64, 20);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario";
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(102, 174);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(83, 33);
            this.cmdLogin.TabIndex = 5;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(12, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(12, 109);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(262, 26);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // cmdCrearcuenta
            // 
            this.cmdCrearcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrearcuenta.Location = new System.Drawing.Point(102, 280);
            this.cmdCrearcuenta.Name = "cmdCrearcuenta";
            this.cmdCrearcuenta.Size = new System.Drawing.Size(83, 54);
            this.cmdCrearcuenta.TabIndex = 6;
            this.cmdCrearcuenta.Text = "Crear cuenta";
            this.cmdCrearcuenta.UseVisualStyleBackColor = true;
            this.cmdCrearcuenta.Click += new System.EventHandler(this.cmdCrearcuenta_Click);
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
            // Wlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 401);
            this.Controls.Add(this.cmdCrearcuenta);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.lblusuario);
            this.Name = "Wlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Wlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_y_ContraseñasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCrearcuenta;
        private DB_usersDataSet dB_usersDataSet;
        private System.Windows.Forms.BindingSource usuarios_y_ContraseñasBindingSource;
        private DB_usersDataSetTableAdapters.Usuarios_y_ContraseñasTableAdapter usuarios_y_ContraseñasTableAdapter;
        private DB_usersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

