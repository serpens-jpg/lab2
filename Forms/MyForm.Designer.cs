namespace _8xml.Forms
{
    partial class MyForm
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
            menuStrip1 = new MenuStrip();
            fileToolStrip = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            contentTextBox = new RichTextBox();
            linqButton = new RadioButton();
            domButton = new RadioButton();
            saxBtn = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            transformButton = new Button();
            teacherComboBox = new ComboBox();
            userComboBox = new ComboBox();
            classnameComboBox = new ComboBox();
            clearButton = new Button();
            groupByLabel = new Label();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(735, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            fileToolStrip.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, вихідToolStripMenuItem });
            fileToolStrip.Name = "fileToolStrip";
            fileToolStrip.Size = new Size(48, 20);
            fileToolStrip.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Читати XML";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Зберегти XML";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // contentTextBox
            // 
            contentTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contentTextBox.ForeColor = Color.Blue;
            contentTextBox.Location = new Point(18, 144);
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(693, 237);
            contentTextBox.TabIndex = 2;
            contentTextBox.Text = "";
            // 
            // linqButton
            // 
            linqButton.AutoSize = true;
            linqButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            linqButton.ForeColor = Color.DimGray;
            linqButton.Location = new Point(18, 97);
            linqButton.Name = "linqButton";
            linqButton.Size = new Size(419, 29);
            linqButton.TabIndex = 7;
            linqButton.TabStop = true;
            linqButton.Text = "Використовувати LINQ для читання XML файлу";
            linqButton.UseVisualStyleBackColor = true;
            // 
            // domButton
            // 
            domButton.AutoSize = true;
            domButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            domButton.ForeColor = Color.DimGray;
            domButton.Location = new Point(18, 62);
            domButton.Name = "domButton";
            domButton.Size = new Size(420, 29);
            domButton.TabIndex = 6;
            domButton.TabStop = true;
            domButton.Text = "Використовувати DOM для читання XML файлу";
            domButton.UseVisualStyleBackColor = true;
            // 
            // saxBtn
            // 
            saxBtn.AutoSize = true;
            saxBtn.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saxBtn.ForeColor = Color.DimGray;
            saxBtn.Location = new Point(18, 27);
            saxBtn.Name = "saxBtn";
            saxBtn.Size = new Size(413, 29);
            saxBtn.TabIndex = 5;
            saxBtn.TabStop = true;
            saxBtn.Text = "Використовувати SAX для читання XML файлу";
            saxBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(454, 105);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 19;
            label3.Text = "Вчитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(454, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "Користувач";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(454, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 17;
            label1.Text = "Назва класу";
            // 
            // transformButton
            // 
            transformButton.BackColor = Color.LightGreen;
            transformButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            transformButton.Location = new Point(463, 387);
            transformButton.Name = "transformButton";
            transformButton.Size = new Size(248, 47);
            transformButton.TabIndex = 16;
            transformButton.Text = "Перетворити до HTML";
            transformButton.UseVisualStyleBackColor = false;
            transformButton.Click += xsltButton_Click;
            // 
            // teacherComboBox
            // 
            teacherComboBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teacherComboBox.FormattingEnabled = true;
            teacherComboBox.Location = new Point(553, 100);
            teacherComboBox.Name = "teacherComboBox";
            teacherComboBox.Size = new Size(158, 28);
            teacherComboBox.TabIndex = 15;
            teacherComboBox.SelectedIndexChanged += teacherComboBox_SelectedIndexChanged;
            // 
            // userComboBox
            // 
            userComboBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(553, 67);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(158, 28);
            userComboBox.TabIndex = 14;
            userComboBox.SelectedIndexChanged += userComboBox_SelectedIndexChanged;
            // 
            // classnameComboBox
            // 
            classnameComboBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classnameComboBox.FormattingEnabled = true;
            classnameComboBox.Location = new Point(553, 34);
            classnameComboBox.Name = "classnameComboBox";
            classnameComboBox.Size = new Size(158, 28);
            classnameComboBox.TabIndex = 13;
            classnameComboBox.SelectedIndexChanged += classnameComboBox_SelectedIndexChanged;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(18, 387);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(188, 47);
            clearButton.TabIndex = 20;
            clearButton.Text = "Очистити";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // groupByLabel
            // 
            groupByLabel.AutoSize = true;
            groupByLabel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupByLabel.ForeColor = Color.Black;
            groupByLabel.Location = new Point(508, 4);
            groupByLabel.Name = "groupByLabel";
            groupByLabel.Size = new Size(123, 25);
            groupByLabel.TabIndex = 21;
            groupByLabel.Text = "Фільтрування";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(180, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(5F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 438);
            Controls.Add(groupByLabel);
            Controls.Add(clearButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(transformButton);
            Controls.Add(teacherComboBox);
            Controls.Add(userComboBox);
            Controls.Add(classnameComboBox);
            Controls.Add(linqButton);
            Controls.Add(domButton);
            Controls.Add(saxBtn);
            Controls.Add(contentTextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "MyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "8 варіант";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStrip;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private RichTextBox contentTextBox;
        private RadioButton linqButton;
        private RadioButton domButton;
        private RadioButton saxBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button transformButton;
        private ComboBox teacherComboBox;
        private ComboBox userComboBox;
        private ComboBox classnameComboBox;
        private Button clearButton;
        private Label groupByLabel;
        private ToolStripMenuItem вихідToolStripMenuItem;
    }
}