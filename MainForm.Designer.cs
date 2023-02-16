namespace HRForms
{
    partial class MainForm
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
            this.btbAdd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbAdd
            // 
            this.btbAdd.Location = new System.Drawing.Point(58, 283);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(125, 29);
            this.btbAdd.TabIndex = 0;
            this.btbAdd.Text = "Ավելացնել";
            this.btbAdd.UseVisualStyleBackColor = true;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(198, 283);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(125, 29);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Դիտել բոլորը";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Աշխատանքի ավարտ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btbAdd);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btbAdd;
        private Button btnAll;
        private Button btnExit;
    }
}