namespace Accounting_for__retail_goods
{
    partial class Form_Osnova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Osnova));
            this.tab_control_spicok = new System.Windows.Forms.TabControl();
            this.tabPage_tablica1 = new System.Windows.Forms.TabPage();
            this.dataGridView1_tablica_1 = new System.Windows.Forms.DataGridView();
            this.panel_zapici_table1 = new System.Windows.Forms.Panel();
            this.button4_save = new System.Windows.Forms.Button();
            this.button3_izmenit = new System.Windows.Forms.Button();
            this.button2_delete = new System.Windows.Forms.Button();
            this.button1_new_zapic = new System.Windows.Forms.Button();
            this.label5_cena_tovara = new System.Windows.Forms.Label();
            this.label4_kolichestvo_tovara = new System.Windows.Forms.Label();
            this.label3_nazvanie_tovara = new System.Windows.Forms.Label();
            this.label2_id_magazina = new System.Windows.Forms.Label();
            this.label1_id_zakupki = new System.Windows.Forms.Label();
            this.textBox5_cena_tovara = new System.Windows.Forms.TextBox();
            this.textBox4_kolichestvo_tovara = new System.Windows.Forms.TextBox();
            this.textBox3_nazvanie_tovara = new System.Windows.Forms.TextBox();
            this.textBox2_id_magazina = new System.Windows.Forms.TextBox();
            this.textBox1_id_zakupki = new System.Windows.Forms.TextBox();
            this.panel_info_o_tablica1 = new System.Windows.Forms.Panel();
            this.pictureBox3_lastik_tablica1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2_reset_tablica1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1_research_tablica1 = new System.Windows.Forms.PictureBox();
            this.textBox_research_tablica1 = new System.Windows.Forms.TextBox();
            this.label_tablica1 = new System.Windows.Forms.Label();
            this.tabPage_tablica2 = new System.Windows.Forms.TabPage();
            this.tab_control_spicok.SuspendLayout();
            this.tabPage_tablica1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_tablica_1)).BeginInit();
            this.panel_zapici_table1.SuspendLayout();
            this.panel_info_o_tablica1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_lastik_tablica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_reset_tablica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_research_tablica1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control_spicok
            // 
            this.tab_control_spicok.Controls.Add(this.tabPage_tablica1);
            this.tab_control_spicok.Controls.Add(this.tabPage_tablica2);
            this.tab_control_spicok.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_control_spicok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_control_spicok.Location = new System.Drawing.Point(0, 0);
            this.tab_control_spicok.Name = "tab_control_spicok";
            this.tab_control_spicok.SelectedIndex = 0;
            this.tab_control_spicok.Size = new System.Drawing.Size(992, 701);
            this.tab_control_spicok.TabIndex = 0;
            // 
            // tabPage_tablica1
            // 
            this.tabPage_tablica1.Controls.Add(this.dataGridView1_tablica_1);
            this.tabPage_tablica1.Controls.Add(this.panel_zapici_table1);
            this.tabPage_tablica1.Controls.Add(this.panel_info_o_tablica1);
            this.tabPage_tablica1.Location = new System.Drawing.Point(4, 29);
            this.tabPage_tablica1.Name = "tabPage_tablica1";
            this.tabPage_tablica1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tablica1.Size = new System.Drawing.Size(984, 668);
            this.tabPage_tablica1.TabIndex = 0;
            this.tabPage_tablica1.Text = "Таблица_1";
            this.tabPage_tablica1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1_tablica_1
            // 
            this.dataGridView1_tablica_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_tablica_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1_tablica_1.Location = new System.Drawing.Point(3, 93);
            this.dataGridView1_tablica_1.Name = "dataGridView1_tablica_1";
            this.dataGridView1_tablica_1.RowHeadersWidth = 51;
            this.dataGridView1_tablica_1.RowTemplate.Height = 24;
            this.dataGridView1_tablica_1.Size = new System.Drawing.Size(978, 357);
            this.dataGridView1_tablica_1.TabIndex = 2;
            // 
            // panel_zapici_table1
            // 
            this.panel_zapici_table1.BackColor = System.Drawing.Color.Silver;
            this.panel_zapici_table1.Controls.Add(this.button4_save);
            this.panel_zapici_table1.Controls.Add(this.button3_izmenit);
            this.panel_zapici_table1.Controls.Add(this.button2_delete);
            this.panel_zapici_table1.Controls.Add(this.button1_new_zapic);
            this.panel_zapici_table1.Controls.Add(this.label5_cena_tovara);
            this.panel_zapici_table1.Controls.Add(this.label4_kolichestvo_tovara);
            this.panel_zapici_table1.Controls.Add(this.label3_nazvanie_tovara);
            this.panel_zapici_table1.Controls.Add(this.label2_id_magazina);
            this.panel_zapici_table1.Controls.Add(this.label1_id_zakupki);
            this.panel_zapici_table1.Controls.Add(this.textBox5_cena_tovara);
            this.panel_zapici_table1.Controls.Add(this.textBox4_kolichestvo_tovara);
            this.panel_zapici_table1.Controls.Add(this.textBox3_nazvanie_tovara);
            this.panel_zapici_table1.Controls.Add(this.textBox2_id_magazina);
            this.panel_zapici_table1.Controls.Add(this.textBox1_id_zakupki);
            this.panel_zapici_table1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_zapici_table1.Location = new System.Drawing.Point(3, 450);
            this.panel_zapici_table1.Name = "panel_zapici_table1";
            this.panel_zapici_table1.Size = new System.Drawing.Size(978, 215);
            this.panel_zapici_table1.TabIndex = 1;
            // 
            // button4_save
            // 
            this.button4_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4_save.Location = new System.Drawing.Point(591, 167);
            this.button4_save.Name = "button4_save";
            this.button4_save.Size = new System.Drawing.Size(145, 45);
            this.button4_save.TabIndex = 13;
            this.button4_save.Text = "Сохранить";
            this.button4_save.UseVisualStyleBackColor = true;
            // 
            // button3_izmenit
            // 
            this.button3_izmenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_izmenit.Location = new System.Drawing.Point(591, 116);
            this.button3_izmenit.Name = "button3_izmenit";
            this.button3_izmenit.Size = new System.Drawing.Size(145, 45);
            this.button3_izmenit.TabIndex = 12;
            this.button3_izmenit.Text = "Изменить";
            this.button3_izmenit.UseVisualStyleBackColor = true;
            // 
            // button2_delete
            // 
            this.button2_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_delete.Location = new System.Drawing.Point(591, 65);
            this.button2_delete.Name = "button2_delete";
            this.button2_delete.Size = new System.Drawing.Size(145, 45);
            this.button2_delete.TabIndex = 11;
            this.button2_delete.Text = "Удалить";
            this.button2_delete.UseVisualStyleBackColor = true;
            // 
            // button1_new_zapic
            // 
            this.button1_new_zapic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_new_zapic.Location = new System.Drawing.Point(591, 14);
            this.button1_new_zapic.Name = "button1_new_zapic";
            this.button1_new_zapic.Size = new System.Drawing.Size(145, 45);
            this.button1_new_zapic.TabIndex = 10;
            this.button1_new_zapic.Text = "Новая запись";
            this.button1_new_zapic.UseVisualStyleBackColor = true;
            // 
            // label5_cena_tovara
            // 
            this.label5_cena_tovara.AutoSize = true;
            this.label5_cena_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_cena_tovara.Location = new System.Drawing.Point(60, 176);
            this.label5_cena_tovara.Name = "label5_cena_tovara";
            this.label5_cena_tovara.Size = new System.Drawing.Size(117, 20);
            this.label5_cena_tovara.TabIndex = 9;
            this.label5_cena_tovara.Text = "Цена товара";
            // 
            // label4_kolichestvo_tovara
            // 
            this.label4_kolichestvo_tovara.AutoSize = true;
            this.label4_kolichestvo_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_kolichestvo_tovara.Location = new System.Drawing.Point(3, 138);
            this.label4_kolichestvo_tovara.Name = "label4_kolichestvo_tovara";
            this.label4_kolichestvo_tovara.Size = new System.Drawing.Size(174, 20);
            this.label4_kolichestvo_tovara.TabIndex = 8;
            this.label4_kolichestvo_tovara.Text = "Количество товара";
            // 
            // label3_nazvanie_tovara
            // 
            this.label3_nazvanie_tovara.AutoSize = true;
            this.label3_nazvanie_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_nazvanie_tovara.Location = new System.Drawing.Point(21, 102);
            this.label3_nazvanie_tovara.Name = "label3_nazvanie_tovara";
            this.label3_nazvanie_tovara.Size = new System.Drawing.Size(156, 20);
            this.label3_nazvanie_tovara.TabIndex = 7;
            this.label3_nazvanie_tovara.Text = "Название товара";
            // 
            // label2_id_magazina
            // 
            this.label2_id_magazina.AutoSize = true;
            this.label2_id_magazina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_id_magazina.Location = new System.Drawing.Point(61, 66);
            this.label2_id_magazina.Name = "label2_id_magazina";
            this.label2_id_magazina.Size = new System.Drawing.Size(116, 20);
            this.label2_id_magazina.TabIndex = 6;
            this.label2_id_magazina.Text = "ID_Магазина";
            // 
            // label1_id_zakupki
            // 
            this.label1_id_zakupki.AutoSize = true;
            this.label1_id_zakupki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_id_zakupki.Location = new System.Drawing.Point(74, 30);
            this.label1_id_zakupki.Name = "label1_id_zakupki";
            this.label1_id_zakupki.Size = new System.Drawing.Size(103, 20);
            this.label1_id_zakupki.TabIndex = 5;
            this.label1_id_zakupki.Text = "ID_Закупки";
            // 
            // textBox5_cena_tovara
            // 
            this.textBox5_cena_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5_cena_tovara.Location = new System.Drawing.Point(190, 169);
            this.textBox5_cena_tovara.Name = "textBox5_cena_tovara";
            this.textBox5_cena_tovara.Size = new System.Drawing.Size(350, 30);
            this.textBox5_cena_tovara.TabIndex = 4;
            // 
            // textBox4_kolichestvo_tovara
            // 
            this.textBox4_kolichestvo_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4_kolichestvo_tovara.Location = new System.Drawing.Point(190, 131);
            this.textBox4_kolichestvo_tovara.Name = "textBox4_kolichestvo_tovara";
            this.textBox4_kolichestvo_tovara.Size = new System.Drawing.Size(350, 30);
            this.textBox4_kolichestvo_tovara.TabIndex = 3;
            // 
            // textBox3_nazvanie_tovara
            // 
            this.textBox3_nazvanie_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3_nazvanie_tovara.Location = new System.Drawing.Point(190, 95);
            this.textBox3_nazvanie_tovara.Name = "textBox3_nazvanie_tovara";
            this.textBox3_nazvanie_tovara.Size = new System.Drawing.Size(350, 30);
            this.textBox3_nazvanie_tovara.TabIndex = 2;
            // 
            // textBox2_id_magazina
            // 
            this.textBox2_id_magazina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2_id_magazina.Location = new System.Drawing.Point(190, 59);
            this.textBox2_id_magazina.Name = "textBox2_id_magazina";
            this.textBox2_id_magazina.Size = new System.Drawing.Size(350, 30);
            this.textBox2_id_magazina.TabIndex = 1;
            // 
            // textBox1_id_zakupki
            // 
            this.textBox1_id_zakupki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_id_zakupki.Location = new System.Drawing.Point(190, 23);
            this.textBox1_id_zakupki.Name = "textBox1_id_zakupki";
            this.textBox1_id_zakupki.Size = new System.Drawing.Size(350, 30);
            this.textBox1_id_zakupki.TabIndex = 0;
            // 
            // panel_info_o_tablica1
            // 
            this.panel_info_o_tablica1.BackColor = System.Drawing.Color.Silver;
            this.panel_info_o_tablica1.Controls.Add(this.pictureBox3_lastik_tablica1);
            this.panel_info_o_tablica1.Controls.Add(this.pictureBox2_reset_tablica1);
            this.panel_info_o_tablica1.Controls.Add(this.pictureBox1_research_tablica1);
            this.panel_info_o_tablica1.Controls.Add(this.textBox_research_tablica1);
            this.panel_info_o_tablica1.Controls.Add(this.label_tablica1);
            this.panel_info_o_tablica1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info_o_tablica1.Location = new System.Drawing.Point(3, 3);
            this.panel_info_o_tablica1.Name = "panel_info_o_tablica1";
            this.panel_info_o_tablica1.Size = new System.Drawing.Size(978, 90);
            this.panel_info_o_tablica1.TabIndex = 0;
            // 
            // pictureBox3_lastik_tablica1
            // 
            this.pictureBox3_lastik_tablica1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_lastik_tablica1.Image")));
            this.pictureBox3_lastik_tablica1.Location = new System.Drawing.Point(574, 31);
            this.pictureBox3_lastik_tablica1.Name = "pictureBox3_lastik_tablica1";
            this.pictureBox3_lastik_tablica1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3_lastik_tablica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3_lastik_tablica1.TabIndex = 4;
            this.pictureBox3_lastik_tablica1.TabStop = false;
            // 
            // pictureBox2_reset_tablica1
            // 
            this.pictureBox2_reset_tablica1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2_reset_tablica1.Image")));
            this.pictureBox2_reset_tablica1.Location = new System.Drawing.Point(612, 31);
            this.pictureBox2_reset_tablica1.Name = "pictureBox2_reset_tablica1";
            this.pictureBox2_reset_tablica1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2_reset_tablica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2_reset_tablica1.TabIndex = 3;
            this.pictureBox2_reset_tablica1.TabStop = false;
            // 
            // pictureBox1_research_tablica1
            // 
            this.pictureBox1_research_tablica1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_research_tablica1.Image")));
            this.pictureBox1_research_tablica1.Location = new System.Drawing.Point(650, 31);
            this.pictureBox1_research_tablica1.Name = "pictureBox1_research_tablica1";
            this.pictureBox1_research_tablica1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1_research_tablica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_research_tablica1.TabIndex = 2;
            this.pictureBox1_research_tablica1.TabStop = false;
            // 
            // textBox_research_tablica1
            // 
            this.textBox_research_tablica1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_research_tablica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_research_tablica1.Location = new System.Drawing.Point(697, 23);
            this.textBox_research_tablica1.Name = "textBox_research_tablica1";
            this.textBox_research_tablica1.Size = new System.Drawing.Size(276, 45);
            this.textBox_research_tablica1.TabIndex = 1;
            // 
            // label_tablica1
            // 
            this.label_tablica1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_tablica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tablica1.Location = new System.Drawing.Point(0, 0);
            this.label_tablica1.Name = "label_tablica1";
            this.label_tablica1.Size = new System.Drawing.Size(221, 90);
            this.label_tablica1.TabIndex = 0;
            this.label_tablica1.Text = "Таблица_1";
            this.label_tablica1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_tablica2
            // 
            this.tabPage_tablica2.Location = new System.Drawing.Point(4, 29);
            this.tabPage_tablica2.Name = "tabPage_tablica2";
            this.tabPage_tablica2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tablica2.Size = new System.Drawing.Size(974, 668);
            this.tabPage_tablica2.TabIndex = 1;
            this.tabPage_tablica2.Text = "Таблица_2";
            this.tabPage_tablica2.UseVisualStyleBackColor = true;
            // 
            // Form_Osnova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 703);
            this.Controls.Add(this.tab_control_spicok);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1010, 750);
            this.Name = "Form_Osnova";
            this.Text = "Form1";
            this.tab_control_spicok.ResumeLayout(false);
            this.tabPage_tablica1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_tablica_1)).EndInit();
            this.panel_zapici_table1.ResumeLayout(false);
            this.panel_zapici_table1.PerformLayout();
            this.panel_info_o_tablica1.ResumeLayout(false);
            this.panel_info_o_tablica1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_lastik_tablica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_reset_tablica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_research_tablica1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control_spicok;
        private System.Windows.Forms.TabPage tabPage_tablica1;
        private System.Windows.Forms.TabPage tabPage_tablica2;
        private System.Windows.Forms.Panel panel_info_o_tablica1;
        private System.Windows.Forms.Label label_tablica1;
        private System.Windows.Forms.TextBox textBox_research_tablica1;
        private System.Windows.Forms.DataGridView dataGridView1_tablica_1;
        private System.Windows.Forms.Panel panel_zapici_table1;
        private System.Windows.Forms.Label label3_nazvanie_tovara;
        private System.Windows.Forms.Label label2_id_magazina;
        private System.Windows.Forms.Label label1_id_zakupki;
        private System.Windows.Forms.TextBox textBox5_cena_tovara;
        private System.Windows.Forms.TextBox textBox4_kolichestvo_tovara;
        private System.Windows.Forms.TextBox textBox3_nazvanie_tovara;
        private System.Windows.Forms.TextBox textBox2_id_magazina;
        private System.Windows.Forms.TextBox textBox1_id_zakupki;
        private System.Windows.Forms.Button button4_save;
        private System.Windows.Forms.Button button3_izmenit;
        private System.Windows.Forms.Button button2_delete;
        private System.Windows.Forms.Button button1_new_zapic;
        private System.Windows.Forms.Label label5_cena_tovara;
        private System.Windows.Forms.Label label4_kolichestvo_tovara;
        private System.Windows.Forms.PictureBox pictureBox3_lastik_tablica1;
        private System.Windows.Forms.PictureBox pictureBox2_reset_tablica1;
        private System.Windows.Forms.PictureBox pictureBox1_research_tablica1;
    }
}

