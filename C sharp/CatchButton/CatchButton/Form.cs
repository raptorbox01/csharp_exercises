﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


//-----------------------------------------------------------------------------
//Небольшая программа пдля тренировки с WinForm
//Цель - нажать на убегающую от пользователя кнопку на форме
//Решение было создано в MSVS 2015 Web express, кторая не имела шаблона winForm
//из-за этого и код дизайнера и логики а одном файле
//-----------------------------------------------------------------------------

namespace CatchButton
{
    public class Form1 : Form
    {
        //Кнопка и генератор 
        private Button button1;
        private Random rnd = new Random();
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public Form1()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            // TODO: Add any constructor code after 
            // InitializeComponent call
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Кликни!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(419, 408);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Кнопка";
            this.Text = "Кнопка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// Показываем при загрузке формы подсказку для программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Попробуй нажать на кнопку мышкой.","Цель");
        }

        /// <summary>
        /// Если мышь навелась на конопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //случайным образом меняем координату конопки на форме. без заезда за границы кнопки
            button1.Location =new Point(rnd.Next(0,ClientSize.Width - button1.Size.Width), rnd.Next(0, ClientSize.Height - button1.Size.Height));
        }

        /// <summary>
        /// Если нажать получилось
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //поздравляем пользователя
            MessageBox.Show("Поздравляем!", "Победа");
        }
    }
}
