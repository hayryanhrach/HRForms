namespace HRForms
{
    partial class AllEmpForm
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
            this.txtAllEmp = new System.Windows.Forms.TextBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.btnDelateAll = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAllEmp
            // 
            this.txtAllEmp.Location = new System.Drawing.Point(12, 45);
            this.txtAllEmp.Multiline = true;
            this.txtAllEmp.Name = "txtAllEmp";
            this.txtAllEmp.ReadOnly = true;
            this.txtAllEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllEmp.Size = new System.Drawing.Size(463, 357);
            this.txtAllEmp.TabIndex = 0;
            // 
            // txtFindName
            // 
            this.txtFindName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFindName.Location = new System.Drawing.Point(62, 12);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.ReadOnly = true;
            this.txtFindName.Size = new System.Drawing.Size(80, 23);
            this.txtFindName.TabIndex = 2;
            this.txtFindName.Text = "Փնտրել";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Location = new System.Drawing.Point(160, 12);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(315, 23);
            this.txtFindValue.TabIndex = 3;
            // 
            // btnDelateAll
            // 
            this.btnDelateAll.Location = new System.Drawing.Point(501, 123);
            this.btnDelateAll.Name = "btnDelateAll";
            this.btnDelateAll.Size = new System.Drawing.Size(117, 33);
            this.btnDelateAll.TabIndex = 1;
            this.btnDelateAll.Text = "Ջնջել բոլորը";
            this.btnDelateAll.UseVisualStyleBackColor = true;
            this.btnDelateAll.Click += new System.EventHandler(this.btnDelateAll_Click);
            // 
            // btnDelate
            // 
            this.btnDelate.Location = new System.Drawing.Point(501, 84);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(117, 33);
            this.btnDelate.TabIndex = 1;
            this.btnDelate.Text = "Ջնջել";
            this.btnDelate.UseVisualStyleBackColor = true;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ավելացնել";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.Location = new System.Drawing.Point(501, 162);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(117, 33);
            this.btnGoToMain.TabIndex = 1;
            this.btnGoToMain.Text = "Գլխավոր մենյու";
            this.btnGoToMain.UseVisualStyleBackColor = true;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // AllEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.ControlBox = false;
            this.Controls.Add(this.txtFindValue);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.btnDelateAll);
            this.Controls.Add(this.txtAllEmp);
            this.Name = "AllEmpForm";
            this.Text = "AllEmpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAllEmp;
        private TextBox txtFindName;
        private TextBox txtFindValue;
        private Button btnDelateAll;
        private Button btnDelate;
        private Button btnAdd;
        private Button btnGoToMain;
    }
}