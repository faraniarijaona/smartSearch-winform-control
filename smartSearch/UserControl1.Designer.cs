namespace smartSearch
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearcBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearcBox
            // 
            this.SearcBox.Location = new System.Drawing.Point(1, 0);
            this.SearcBox.Multiline = true;
            this.SearcBox.Name = "SearcBox";
            this.SearcBox.Size = new System.Drawing.Size(185, 22);
            this.SearcBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_ok);
            this.panel1.Controls.Add(this.bt_create);
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 201);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::smartSearch.Properties.Resources.pencil;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(75, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Image = global::smartSearch.Properties.Resources.delete;
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(140, 173);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(66, 25);
            this.bt_delete.TabIndex = 6;
            this.bt_delete.Text = "Delete";
            this.bt_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Image = global::smartSearch.Properties.Resources.accept;
            this.bt_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ok.Location = new System.Drawing.Point(413, 173);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(52, 25);
            this.bt_ok.TabIndex = 5;
            this.bt_ok.Text = "OK";
            this.bt_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_create
            // 
            this.bt_create.Image = global::smartSearch.Properties.Resources.add;
            this.bt_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_create.Location = new System.Drawing.Point(3, 173);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(66, 25);
            this.bt_create.TabIndex = 4;
            this.bt_create.Text = "Create";
            this.bt_create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_create.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Image = global::smartSearch.Properties.Resources.back;
            this.bt_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancel.Location = new System.Drawing.Point(471, 173);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(67, 25);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_search
            // 
            this.bt_search.Image = global::smartSearch.Properties.Resources.magnifier;
            this.bt_search.Location = new System.Drawing.Point(188, -1);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(65, 23);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "search";
            this.bt_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearcBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(541, 227);
            this.Leave += new System.EventHandler(this.UserControl1_Leave);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearcBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_create;

    }
}
