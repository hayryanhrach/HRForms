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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEmpForm));
            this.txtAllEmp = new System.Windows.Forms.TextBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.btnDelateAll = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.picAllAll = new System.Windows.Forms.PictureBox();
            this.picAllSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAllAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAllSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAllEmp
            // 
            this.txtAllEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.txtAllEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(49)))), ((int)(((byte)(85)))));
            this.txtAllEmp.Location = new System.Drawing.Point(12, 45);
            this.txtAllEmp.Multiline = true;
            this.txtAllEmp.Name = "txtAllEmp";
            this.txtAllEmp.ReadOnly = true;
            this.txtAllEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllEmp.Size = new System.Drawing.Size(563, 334);
            this.txtAllEmp.TabIndex = 0;
            // 
            // txtFindName
            // 
            this.txtFindName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.txtFindName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindName.Font = new System.Drawing.Font("Courgette", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtFindName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(49)))), ((int)(((byte)(85)))));
            this.txtFindName.Location = new System.Drawing.Point(37, 11);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.ReadOnly = true;
            this.txtFindName.Size = new System.Drawing.Size(61, 24);
            this.txtFindName.TabIndex = 2;
            this.txtFindName.Text = "Փնտրել";
            // 
            // txtFindValue
            // 
            this.txtFindValue.BackColor = System.Drawing.Color.White;
            this.txtFindValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindValue.Location = new System.Drawing.Point(104, 11);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(471, 23);
            this.txtFindValue.TabIndex = 3;
            // 
            // btnDelateAll
            // 
            this.btnDelateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnDelateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelateAll.Location = new System.Drawing.Point(592, 227);
            this.btnDelateAll.Name = "btnDelateAll";
            this.btnDelateAll.Size = new System.Drawing.Size(117, 33);
            this.btnDelateAll.TabIndex = 1;
            this.btnDelateAll.Text = "Ջնջել բոլորը";
            this.btnDelateAll.UseVisualStyleBackColor = false;
            this.btnDelateAll.Click += new System.EventHandler(this.btnDelateAll_Click);
            // 
            // btnDelate
            // 
            this.btnDelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnDelate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelate.Location = new System.Drawing.Point(592, 188);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(117, 33);
            this.btnDelate.TabIndex = 1;
            this.btnDelate.Text = "Ջնջել";
            this.btnDelate.UseVisualStyleBackColor = false;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(590, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ավելացնել";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnGoToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToMain.Location = new System.Drawing.Point(592, 266);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(117, 33);
            this.btnGoToMain.TabIndex = 1;
            this.btnGoToMain.Text = "Գլխավոր մենյու";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // picAllAll
            // 
            this.picAllAll.Image = ((System.Drawing.Image)(resources.GetObject("picAllAll.Image")));
            this.picAllAll.Location = new System.Drawing.Point(590, 12);
            this.picAllAll.Name = "picAllAll";
            this.picAllAll.Size = new System.Drawing.Size(117, 117);
            this.picAllAll.TabIndex = 4;
            this.picAllAll.TabStop = false;
            // 
            // picAllSearch
            // 
            this.picAllSearch.Image = ((System.Drawing.Image)(resources.GetObject("picAllSearch.Image")));
            this.picAllSearch.Location = new System.Drawing.Point(12, 11);
            this.picAllSearch.Name = "picAllSearch";
            this.picAllSearch.Size = new System.Drawing.Size(24, 24);
            this.picAllSearch.TabIndex = 5;
            this.picAllSearch.TabStop = false;
            // 
            // AllEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(719, 388);
            this.ControlBox = false;
            this.Controls.Add(this.picAllSearch);
            this.Controls.Add(this.picAllAll);
            this.Controls.Add(this.txtFindValue);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.btnDelateAll);
            this.Controls.Add(this.txtAllEmp);
            this.Name = "AllEmpForm";
            this.Text = "AllEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.picAllAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAllSearch)).EndInit();
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
        private PictureBox picAllAll;
        private PictureBox picAllSearch;
    }
}