namespace WindowsFormsInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeKB = new System.Windows.Forms.ComboBox();
            this.FolderPathTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConnectionStateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.Port_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.IP_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SynchronizeCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.UploadFileButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(178, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Период синхронизации";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 56);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(150, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Путь к общей папке";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.TimeKB);
            this.groupBox1.Controls.Add(this.FolderPathTB);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // TimeKB
            // 
            this.TimeKB.FormattingEnabled = true;
            this.TimeKB.Items.AddRange(new object[] {
            "1 минута",
            "3 минуты",
            "5 минут",
            "10 минут",
            "15 минут",
            "30 минут",
            "1 час",
            "2 часа",
            "3 часа",
            "5 часов",
            "7 часов",
            "12 часов",
            "24 часа"});
            this.TimeKB.Location = new System.Drawing.Point(189, 18);
            this.TimeKB.Name = "TimeKB";
            this.TimeKB.Size = new System.Drawing.Size(264, 28);
            this.TimeKB.TabIndex = 3;
            this.TimeKB.SelectedIndexChanged += new System.EventHandler(this.TimeKB_SelectedIndexChanged);
            // 
            // FolderPathTB
            // 
            this.FolderPathTB.Location = new System.Drawing.Point(189, 52);
            this.FolderPathTB.Name = "FolderPathTB";
            this.FolderPathTB.Size = new System.Drawing.Size(264, 26);
            this.FolderPathTB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.ConnectButton);
            this.groupBox2.Controls.Add(this.ConnectionStateLabel);
            this.groupBox2.Controls.Add(this.Port_TB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IP_TB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сервер";
            // 
            // ConnectButton
            // 
            this.ConnectButton.AutoSize = true;
            this.ConnectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectButton.Depth = 0;
            this.ConnectButton.Location = new System.Drawing.Point(189, 23);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConnectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Primary = false;
            this.ConnectButton.Size = new System.Drawing.Size(109, 36);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Подключить";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionStateLabel
            // 
            this.ConnectionStateLabel.AutoSize = true;
            this.ConnectionStateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ConnectionStateLabel.Depth = 0;
            this.ConnectionStateLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ConnectionStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConnectionStateLabel.Location = new System.Drawing.Point(6, 76);
            this.ConnectionStateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConnectionStateLabel.Name = "ConnectionStateLabel";
            this.ConnectionStateLabel.Size = new System.Drawing.Size(85, 19);
            this.ConnectionStateLabel.TabIndex = 6;
            this.ConnectionStateLabel.Text = "                   ";
            // 
            // Port_TB
            // 
            this.Port_TB.Depth = 0;
            this.Port_TB.Hint = "";
            this.Port_TB.Location = new System.Drawing.Point(128, 36);
            this.Port_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Port_TB.Name = "Port_TB";
            this.Port_TB.PasswordChar = '\0';
            this.Port_TB.SelectedText = "";
            this.Port_TB.SelectionLength = 0;
            this.Port_TB.SelectionStart = 0;
            this.Port_TB.Size = new System.Drawing.Size(45, 23);
            this.Port_TB.TabIndex = 2;
            this.Port_TB.UseSystemPasswordChar = false;
            this.Port_TB.TextChanged += new System.EventHandler(this.Port_TB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // IP_TB
            // 
            this.IP_TB.Depth = 0;
            this.IP_TB.Hint = "";
            this.IP_TB.Location = new System.Drawing.Point(6, 36);
            this.IP_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.IP_TB.Name = "IP_TB";
            this.IP_TB.PasswordChar = '\0';
            this.IP_TB.SelectedText = "";
            this.IP_TB.SelectionLength = 0;
            this.IP_TB.SelectionStart = 0;
            this.IP_TB.Size = new System.Drawing.Size(110, 23);
            this.IP_TB.TabIndex = 0;
            this.IP_TB.UseSystemPasswordChar = false;
            this.IP_TB.TextChanged += new System.EventHandler(this.IP_TB_TextChanged);
            // 
            // SynchronizeCB
            // 
            this.SynchronizeCB.AutoSize = true;
            this.SynchronizeCB.BackColor = System.Drawing.SystemColors.Control;
            this.SynchronizeCB.Depth = 0;
            this.SynchronizeCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.SynchronizeCB.Location = new System.Drawing.Point(12, 78);
            this.SynchronizeCB.Margin = new System.Windows.Forms.Padding(0);
            this.SynchronizeCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SynchronizeCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SynchronizeCB.Name = "SynchronizeCB";
            this.SynchronizeCB.Ripple = true;
            this.SynchronizeCB.Size = new System.Drawing.Size(116, 30);
            this.SynchronizeCB.TabIndex = 5;
            this.SynchronizeCB.Text = "Общая папка";
            this.SynchronizeCB.UseVisualStyleBackColor = false;
            this.SynchronizeCB.CheckedChanged += new System.EventHandler(this.SynchronizeCB_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Location = new System.Drawing.Point(14, 347);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.Size = new System.Drawing.Size(180, 36);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить настройки";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.AutoSize = true;
            this.UploadFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UploadFileButton.Depth = 0;
            this.UploadFileButton.Location = new System.Drawing.Point(333, 347);
            this.UploadFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UploadFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Primary = false;
            this.UploadFileButton.Size = new System.Drawing.Size(132, 36);
            this.UploadFileButton.TabIndex = 8;
            this.UploadFileButton.Text = "Загрузить файл";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 399);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SynchronizeCB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Синхронизация файлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField IP_TB;
        private MaterialSkin.Controls.MaterialSingleLineTextField Port_TB;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton ConnectButton;
        private System.Windows.Forms.ComboBox TimeKB;
        private System.Windows.Forms.TextBox FolderPathTB;
        private MaterialSkin.Controls.MaterialCheckBox SynchronizeCB;
        private MaterialSkin.Controls.MaterialLabel ConnectionStateLabel;
        private MaterialSkin.Controls.MaterialFlatButton SaveButton;
        private MaterialSkin.Controls.MaterialFlatButton UploadFileButton;
    }
}

