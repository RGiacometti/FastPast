namespace FastPast
{
    partial class MainForm
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
            textPast = new TextBox();
            label1 = new Label();
            displayButton = new Button();
            convertCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // textPast
            // 
            textPast.Location = new Point(23, 45);
            textPast.Name = "textPast";
            textPast.Size = new Size(287, 23);
            textPast.TabIndex = 0;
            textPast.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eras Medium ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 1;
            label1.Text = "FastPast";
            // 
            // displayButton
            // 
            displayButton.Location = new Point(23, 87);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(114, 23);
            displayButton.TabIndex = 2;
            displayButton.Text = "Show";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // convertCheckBox
            // 
            convertCheckBox.AutoSize = true;
            convertCheckBox.Location = new Point(157, 91);
            convertCheckBox.Name = "convertCheckBox";
            convertCheckBox.Size = new Size(115, 19);
            convertCheckBox.TabIndex = 3;
            convertCheckBox.Text = "Convert FR to US";
            convertCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 139);
            Controls.Add(convertCheckBox);
            Controls.Add(displayButton);
            Controls.Add(label1);
            Controls.Add(textPast);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Form ";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPast;
        private Label label1;
        private Button displayButton;
        private CheckBox convertCheckBox;
    }
}