namespace Anket_2
{
    partial class Anket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAnket = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.GroupBox();
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.groupBoxAnket.SuspendLayout();
            this.List.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnket
            // 
            this.groupBoxAnket.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxAnket.Controls.Add(this.buttonClear);
            this.groupBoxAnket.Controls.Add(this.buttonSave);
            this.groupBoxAnket.Controls.Add(this.textBoxPhone);
            this.groupBoxAnket.Controls.Add(this.textBoxEmail);
            this.groupBoxAnket.Controls.Add(this.textBoxSurname);
            this.groupBoxAnket.Controls.Add(this.textBoxName);
            this.groupBoxAnket.Controls.Add(this.dateTimePickerBirthday);
            this.groupBoxAnket.Controls.Add(this.labelSurname);
            this.groupBoxAnket.Controls.Add(this.labelEmail);
            this.groupBoxAnket.Controls.Add(this.labelPhone);
            this.groupBoxAnket.Controls.Add(this.labelBirthday);
            this.groupBoxAnket.Controls.Add(this.labelName);
            this.groupBoxAnket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAnket.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAnket.Name = "groupBoxAnket";
            this.groupBoxAnket.Size = new System.Drawing.Size(521, 498);
            this.groupBoxAnket.TabIndex = 0;
            this.groupBoxAnket.TabStop = false;
            this.groupBoxAnket.Text = "Anket 2";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(126, 415);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 45);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToClear);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(308, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 45);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickToSave);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(187, 266);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PlaceholderText = "Ex : 050-665-06-55";
            this.textBoxPhone.Size = new System.Drawing.Size(308, 33);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(187, 193);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Ex : kerimzzade@gmail.com";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 33);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(187, 118);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PlaceholderText = "Ex : Kerimzade";
            this.textBoxSurname.Size = new System.Drawing.Size(308, 33);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(187, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Ex : Ismayil";
            this.textBoxName.Size = new System.Drawing.Size(308, 33);
            this.textBoxName.TabIndex = 6;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(187, 349);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(308, 33);
            this.dateTimePickerBirthday.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(36, 114);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(126, 37);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Surname";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(36, 189);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 37);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(36, 262);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(95, 37);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirthday.Location = new System.Drawing.Point(36, 345);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(121, 37);
            this.labelBirthday.TabIndex = 1;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(36, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 37);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(102, 415);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(99, 45);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClikToLoad);
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.SystemColors.MenuBar;
            this.List.Controls.Add(this.buttonLoad);
            this.List.Controls.Add(this.listBoxPeople);
            this.List.Location = new System.Drawing.Point(527, 0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(303, 498);
            this.List.TabIndex = 10;
            this.List.TabStop = false;
            this.List.Text = "List";
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.ItemHeight = 21;
            this.listBoxPeople.Location = new System.Drawing.Point(6, 36);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(291, 340);
            this.listBoxPeople.TabIndex = 0;
            this.listBoxPeople.SelectedIndexChanged += new System.EventHandler(this.ChangeIndexOfPeople);
            // 
            // Anket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.List);
            this.Controls.Add(this.groupBoxAnket);
            this.Name = "Anket";
            this.Text = "Anket";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAnket.ResumeLayout(false);
            this.groupBoxAnket.PerformLayout();
            this.List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxAnket;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerBirthday;
        private Label labelSurname;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelBirthday;
        private Label labelName;
        private GroupBox List;
        private ListBox listBoxPeople;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonClear;
    }
}