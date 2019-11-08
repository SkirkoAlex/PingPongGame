namespace Ping_pong_2
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
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.Res = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.loseLibel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.game_boll = new System.Windows.Forms.PictureBox();
            this.game_panel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Info = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_boll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.Info);
            this.background.Controls.Add(this.Res);
            this.background.Controls.Add(this.Pause);
            this.background.Controls.Add(this.loseLibel);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.game_boll);
            this.background.Controls.Add(this.game_panel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.ForeColor = System.Drawing.Color.Green;
            this.Res.Location = new System.Drawing.Point(388, 83);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(638, 91);
            this.Res.TabIndex = 5;
            this.Res.Text = "Ваш результат: ";
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause.ForeColor = System.Drawing.Color.Red;
            this.Pause.Location = new System.Drawing.Point(229, 121);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(868, 54);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Пауза... Нажмите G для продолжения!";
            // 
            // loseLibel
            // 
            this.loseLibel.AutoSize = true;
            this.loseLibel.Font = new System.Drawing.Font("Comic Sans MS", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLibel.ForeColor = System.Drawing.Color.Coral;
            this.loseLibel.Location = new System.Drawing.Point(188, 184);
            this.loseLibel.Name = "loseLibel";
            this.loseLibel.Size = new System.Drawing.Size(915, 58);
            this.loseLibel.TabIndex = 3;
            this.loseLibel.Text = "Игра окончена! Нажмите R для новой игры";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.SystemColors.Info;
            this.result.Location = new System.Drawing.Point(36, 13);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(143, 33);
            this.result.TabIndex = 2;
            this.result.Text = "Результат: 0";
            // 
            // game_boll
            // 
            this.game_boll.BackColor = System.Drawing.Color.Blue;
            this.game_boll.Location = new System.Drawing.Point(196, 300);
            this.game_boll.Name = "game_boll";
            this.game_boll.Size = new System.Drawing.Size(50, 50);
            this.game_boll.TabIndex = 1;
            this.game_boll.TabStop = false;
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Red;
            this.game_panel.Location = new System.Drawing.Point(247, 420);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(299, 18);
            this.game_panel.TabIndex = 0;
            this.game_panel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Info.Location = new System.Drawing.Point(416, 13);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(215, 25);
            this.Info.TabIndex = 6;
            this.Info.Text = "Пауза - P, Выход - Esc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_boll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox game_boll;
        private System.Windows.Forms.PictureBox game_panel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loseLibel;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label Info;
    }
}

