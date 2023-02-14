namespace HRForms
{
    partial class AddForm
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
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtIDValue = new System.Windows.Forms.TextBox();
            this.txtIDName = new System.Windows.Forms.TextBox();
            this.txtFirsNameValue = new System.Windows.Forms.TextBox();
            this.txtFirstNameName = new System.Windows.Forms.TextBox();
            this.txtLastNameValue = new System.Windows.Forms.TextBox();
            this.txtLastNameName = new System.Windows.Forms.TextBox();
            this.txtDeparmentName = new System.Windows.Forms.TextBox();
            this.ddDepartmentValue = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(12, 12);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.ReadOnly = true;
            this.txtAddTitle.Size = new System.Drawing.Size(219, 23);
            this.txtAddTitle.TabIndex = 0;
            this.txtAddTitle.Text = "Նոր աշխատողի գրանցում ծրագրում";
            // 
            // txtIDValue
            // 
            this.txtIDValue.Location = new System.Drawing.Point(144, 57);
            this.txtIDValue.Name = "txtIDValue";
            this.txtIDValue.Size = new System.Drawing.Size(205, 23);
            this.txtIDValue.TabIndex = 1;
            // 
            // txtIDName
            // 
            this.txtIDName.Location = new System.Drawing.Point(12, 57);
            this.txtIDName.Name = "txtIDName";
            this.txtIDName.ReadOnly = true;
            this.txtIDName.Size = new System.Drawing.Size(116, 23);
            this.txtIDName.TabIndex = 2;
            this.txtIDName.Text = "ID";
            // 
            // txtFirsNameValue
            // 
            this.txtFirsNameValue.Location = new System.Drawing.Point(144, 98);
            this.txtFirsNameValue.Name = "txtFirsNameValue";
            this.txtFirsNameValue.Size = new System.Drawing.Size(205, 23);
            this.txtFirsNameValue.TabIndex = 1;
            // 
            // txtFirstNameName
            // 
            this.txtFirstNameName.Location = new System.Drawing.Point(12, 98);
            this.txtFirstNameName.Name = "txtFirstNameName";
            this.txtFirstNameName.ReadOnly = true;
            this.txtFirstNameName.Size = new System.Drawing.Size(116, 23);
            this.txtFirstNameName.TabIndex = 2;
            this.txtFirstNameName.Text = "Անուն";
            // 
            // txtLastNameValue
            // 
            this.txtLastNameValue.Location = new System.Drawing.Point(144, 142);
            this.txtLastNameValue.Name = "txtLastNameValue";
            this.txtLastNameValue.Size = new System.Drawing.Size(205, 23);
            this.txtLastNameValue.TabIndex = 1;
            // 
            // txtLastNameName
            // 
            this.txtLastNameName.Location = new System.Drawing.Point(12, 142);
            this.txtLastNameName.Name = "txtLastNameName";
            this.txtLastNameName.ReadOnly = true;
            this.txtLastNameName.Size = new System.Drawing.Size(116, 23);
            this.txtLastNameName.TabIndex = 2;
            this.txtLastNameName.Text = "Ազգանուն";
            // 
            // txtDeparmentName
            // 
            this.txtDeparmentName.Location = new System.Drawing.Point(12, 185);
            this.txtDeparmentName.Name = "txtDeparmentName";
            this.txtDeparmentName.ReadOnly = true;
            this.txtDeparmentName.Size = new System.Drawing.Size(116, 23);
            this.txtDeparmentName.TabIndex = 2;
            this.txtDeparmentName.Text = "Ստորաբաժանում";
            // 
            // ddDepartmentValue
            // 
            this.ddDepartmentValue.FormattingEnabled = true;
            this.ddDepartmentValue.Location = new System.Drawing.Point(144, 185);
            this.ddDepartmentValue.Name = "ddDepartmentValue";
            this.ddDepartmentValue.Size = new System.Drawing.Size(205, 23);
            this.ddDepartmentValue.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ավելացնել";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Չեղարկել";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.Location = new System.Drawing.Point(185, 230);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(109, 23);
            this.btnGoToMain.TabIndex = 5;
            this.btnGoToMain.Text = "Գլխավոր մենյու";
            this.btnGoToMain.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 285);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ddDepartmentValue);
            this.Controls.Add(this.txtDeparmentName);
            this.Controls.Add(this.txtLastNameName);
            this.Controls.Add(this.txtFirstNameName);
            this.Controls.Add(this.txtIDName);
            this.Controls.Add(this.txtLastNameValue);
            this.Controls.Add(this.txtFirsNameValue);
            this.Controls.Add(this.txtIDValue);
            this.Controls.Add(this.txtAddTitle);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAddTitle;
        private TextBox txtIDValue;
        private TextBox txtIDName;
        private TextBox txtFirsNameValue;
        private TextBox txtFirstNameName;
        private TextBox txtLastNameValue;
        private TextBox txtLastNameName;
        private TextBox txtDeparmentName;
        private ComboBox ddDepartmentValue;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnGoToMain;
    }
}