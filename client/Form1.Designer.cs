
namespace client
{
    partial class Form__chat
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
            this.button_send_messages = new System.Windows.Forms.Button();
            this.button_will_connect = new System.Windows.Forms.Button();
            this.textBox_nick = new System.Windows.Forms.TextBox();
            this.label_nick = new System.Windows.Forms.Label();
            this.label_chat = new System.Windows.Forms.Label();
            this.label_enter_message = new System.Windows.Forms.Label();
            this.richTextBox_chat_output = new System.Windows.Forms.RichTextBox();
            this.richTextBox_entering_message = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_server_info = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_send_messages
            // 
            this.button_send_messages.Location = new System.Drawing.Point(243, 407);
            this.button_send_messages.Name = "button_send_messages";
            this.button_send_messages.Size = new System.Drawing.Size(96, 44);
            this.button_send_messages.TabIndex = 0;
            this.button_send_messages.Text = "Отправить";
            this.button_send_messages.UseVisualStyleBackColor = true;
            this.button_send_messages.Click += new System.EventHandler(this.button_send_messages_Click);
            // 
            // button_will_connect
            // 
            this.button_will_connect.Location = new System.Drawing.Point(243, 67);
            this.button_will_connect.Name = "button_will_connect";
            this.button_will_connect.Size = new System.Drawing.Size(127, 23);
            this.button_will_connect.TabIndex = 1;
            this.button_will_connect.Text = "Подключится ";
            this.button_will_connect.UseVisualStyleBackColor = true;
            this.button_will_connect.Click += new System.EventHandler(this.button_will_connect_Click);
            // 
            // textBox_nick
            // 
            this.textBox_nick.Location = new System.Drawing.Point(12, 67);
            this.textBox_nick.Name = "textBox_nick";
            this.textBox_nick.Size = new System.Drawing.Size(198, 23);
            this.textBox_nick.TabIndex = 2;
            // 
            // label_nick
            // 
            this.label_nick.AutoSize = true;
            this.label_nick.Location = new System.Drawing.Point(9, 49);
            this.label_nick.Name = "label_nick";
            this.label_nick.Size = new System.Drawing.Size(29, 15);
            this.label_nick.TabIndex = 3;
            this.label_nick.Text = "Ник";
            // 
            // label_chat
            // 
            this.label_chat.AutoSize = true;
            this.label_chat.Location = new System.Drawing.Point(12, 102);
            this.label_chat.Name = "label_chat";
            this.label_chat.Size = new System.Drawing.Size(26, 15);
            this.label_chat.TabIndex = 4;
            this.label_chat.Text = "Чат";
            // 
            // label_enter_message
            // 
            this.label_enter_message.AutoSize = true;
            this.label_enter_message.Location = new System.Drawing.Point(12, 304);
            this.label_enter_message.Name = "label_enter_message";
            this.label_enter_message.Size = new System.Drawing.Size(100, 15);
            this.label_enter_message.TabIndex = 5;
            this.label_enter_message.Text = "Ввод сообщения";
            // 
            // richTextBox_chat_output
            // 
            this.richTextBox_chat_output.Enabled = false;
            this.richTextBox_chat_output.Location = new System.Drawing.Point(12, 134);
            this.richTextBox_chat_output.Name = "richTextBox_chat_output";
            this.richTextBox_chat_output.Size = new System.Drawing.Size(628, 156);
            this.richTextBox_chat_output.TabIndex = 6;
            this.richTextBox_chat_output.Text = "";
            // 
            // richTextBox_entering_message
            // 
            this.richTextBox_entering_message.Location = new System.Drawing.Point(12, 332);
            this.richTextBox_entering_message.Name = "richTextBox_entering_message";
            this.richTextBox_entering_message.Size = new System.Drawing.Size(628, 69);
            this.richTextBox_entering_message.TabIndex = 7;
            this.richTextBox_entering_message.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label_server_info
            // 
            this.label_server_info.AutoSize = true;
            this.label_server_info.Location = new System.Drawing.Point(472, 49);
            this.label_server_info.Name = "label_server_info";
            this.label_server_info.Size = new System.Drawing.Size(0, 15);
            this.label_server_info.TabIndex = 9;
            // 
            // Form__chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 463);
            this.Controls.Add(this.label_server_info);
            this.Controls.Add(this.richTextBox_entering_message);
            this.Controls.Add(this.richTextBox_chat_output);
            this.Controls.Add(this.label_enter_message);
            this.Controls.Add(this.label_chat);
            this.Controls.Add(this.label_nick);
            this.Controls.Add(this.textBox_nick);
            this.Controls.Add(this.button_will_connect);
            this.Controls.Add(this.button_send_messages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form__chat";
            this.Text = "Чат";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send_messages;
        private System.Windows.Forms.Button button_will_connect;
        private System.Windows.Forms.TextBox textBox_nick;
        private System.Windows.Forms.Label label_nick;
        private System.Windows.Forms.Label label_chat;
        private System.Windows.Forms.Label label_enter_message;
        private System.Windows.Forms.RichTextBox richTextBox_chat_output;
        private System.Windows.Forms.RichTextBox richTextBox_entering_message;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label_server_info;
    }
}

