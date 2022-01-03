
namespace RunnerGame
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
            this.Sky = new System.Windows.Forms.Panel();
            this.GoStop = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.FpsShower = new System.Windows.Forms.Label();
            this.MinusBut = new System.Windows.Forms.Button();
            this.PlusBut = new System.Windows.Forms.Button();
            this.Field1 = new System.Windows.Forms.PictureBox();
            this.Field2 = new System.Windows.Forms.PictureBox();
            this.Fps = new System.Windows.Forms.Timer(this.components);
            this.GameField = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.StartBut = new System.Windows.Forms.Button();
            this.Sky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Field2)).BeginInit();
            this.GameField.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sky
            // 
            this.Sky.BackColor = System.Drawing.Color.SkyBlue;
            this.Sky.Controls.Add(this.GoStop);
            this.Sky.Controls.Add(this.Exit);
            this.Sky.Controls.Add(this.FpsShower);
            this.Sky.Controls.Add(this.MinusBut);
            this.Sky.Controls.Add(this.PlusBut);
            this.Sky.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sky.Location = new System.Drawing.Point(0, 0);
            this.Sky.Name = "Sky";
            this.Sky.Size = new System.Drawing.Size(1032, 180);
            this.Sky.TabIndex = 0;
            // 
            // GoStop
            // 
            this.GoStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoStop.Location = new System.Drawing.Point(428, 47);
            this.GoStop.Name = "GoStop";
            this.GoStop.Size = new System.Drawing.Size(95, 78);
            this.GoStop.TabIndex = 4;
            this.GoStop.Text = "Пуск";
            this.GoStop.UseVisualStyleBackColor = true;
            this.GoStop.Click += new System.EventHandler(this.GoStop_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(52, 13);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 61);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FpsShower
            // 
            this.FpsShower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FpsShower.Location = new System.Drawing.Point(779, 128);
            this.FpsShower.Name = "FpsShower";
            this.FpsShower.Size = new System.Drawing.Size(160, 42);
            this.FpsShower.TabIndex = 2;
            this.FpsShower.Text = "2";
            // 
            // MinusBut
            // 
            this.MinusBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusBut.Location = new System.Drawing.Point(779, 47);
            this.MinusBut.Name = "MinusBut";
            this.MinusBut.Size = new System.Drawing.Size(77, 78);
            this.MinusBut.TabIndex = 1;
            this.MinusBut.Text = "-";
            this.MinusBut.UseVisualStyleBackColor = true;
            this.MinusBut.Click += new System.EventHandler(this.MinusBut_Click);
            // 
            // PlusBut
            // 
            this.PlusBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusBut.Location = new System.Drawing.Point(862, 47);
            this.PlusBut.Name = "PlusBut";
            this.PlusBut.Size = new System.Drawing.Size(77, 78);
            this.PlusBut.TabIndex = 0;
            this.PlusBut.Text = "+";
            this.PlusBut.UseVisualStyleBackColor = true;
            this.PlusBut.Click += new System.EventHandler(this.PlusBut_Click);
            // 
            // Field1
            // 
            this.Field1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Field1.Location = new System.Drawing.Point(1032, 180);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(1032, 519);
            this.Field1.TabIndex = 1;
            this.Field1.TabStop = false;
            // 
            // Field2
            // 
            this.Field2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Field2.Location = new System.Drawing.Point(0, 180);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(1032, 519);
            this.Field2.TabIndex = 2;
            this.Field2.TabStop = false;
            // 
            // Fps
            // 
            this.Fps.Interval = 500;
            this.Fps.Tick += new System.EventHandler(this.Fps_Tick);
            // 
            // GameField
            // 
            this.GameField.Controls.Add(this.Field1);
            this.GameField.Controls.Add(this.Sky);
            this.GameField.Controls.Add(this.Field2);
            this.GameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameField.Location = new System.Drawing.Point(0, 0);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(1032, 699);
            this.GameField.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.StartBut);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1032, 699);
            this.Menu.TabIndex = 0;
            // 
            // StartBut
            // 
            this.StartBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBut.Location = new System.Drawing.Point(312, 225);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(481, 281);
            this.StartBut.TabIndex = 0;
            this.StartBut.Text = "Начать";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 699);
            this.Controls.Add(this.Menu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Sky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Field1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Field2)).EndInit();
            this.GameField.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sky;
        private System.Windows.Forms.PictureBox Field2;
        private System.Windows.Forms.Label FpsShower;
        private System.Windows.Forms.Button MinusBut;
        private System.Windows.Forms.Button PlusBut;
        private System.Windows.Forms.PictureBox Field1;
        private System.Windows.Forms.Timer Fps;
        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button GoStop;
    }
}

