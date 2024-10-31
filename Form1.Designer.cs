namespace giao_diện_bán_hàng
{
    partial class Form1
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
            dataGridViewsanpham = new DataGridView();
            buttonthem = new Button();
            buttonxoa = new Button();
            buttonthanhtoan = new Button();
            dataGridViewgiohang = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtthanhtien = new TextBox();
            label2 = new Label();
            txtsoluong = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsanpham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewgiohang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewsanpham
            // 
            dataGridViewsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsanpham.Location = new Point(6, 39);
            dataGridViewsanpham.Name = "dataGridViewsanpham";
            dataGridViewsanpham.RowHeadersWidth = 51;
            dataGridViewsanpham.Size = new Size(657, 569);
            dataGridViewsanpham.TabIndex = 0;
            // 
            // buttonthem
            // 
            buttonthem.Location = new Point(500, 636);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(163, 29);
            buttonthem.TabIndex = 1;
            buttonthem.Text = "Thêm vào giỏ hàng";
            buttonthem.UseVisualStyleBackColor = true;
            buttonthem.Click += buttonthem_Click;
            // 
            // buttonxoa
            // 
            buttonxoa.Location = new Point(370, 510);
            buttonxoa.Name = "buttonxoa";
            buttonxoa.Size = new Size(174, 29);
            buttonxoa.TabIndex = 2;
            buttonxoa.Text = "Xóa khỏi giỏ hàng ";
            buttonxoa.UseVisualStyleBackColor = true;
            buttonxoa.Click += button2_Click;
            // 
            // buttonthanhtoan
            // 
            buttonthanhtoan.Location = new Point(1093, 688);
            buttonthanhtoan.Name = "buttonthanhtoan";
            buttonthanhtoan.Size = new Size(142, 29);
            buttonthanhtoan.TabIndex = 3;
            buttonthanhtoan.Text = "Thanh toán ";
            buttonthanhtoan.UseVisualStyleBackColor = true;
            buttonthanhtoan.Click += buttonthanhtoan_Click;
            // 
            // dataGridViewgiohang
            // 
            dataGridViewgiohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewgiohang.Location = new Point(22, 39);
            dataGridViewgiohang.Name = "dataGridViewgiohang";
            dataGridViewgiohang.RowHeadersWidth = 51;
            dataGridViewgiohang.Size = new Size(522, 452);
            dataGridViewgiohang.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewsanpham);
            groupBox1.Controls.Add(buttonthem);
            groupBox1.Location = new Point(16, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 682);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtthanhtien);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtsoluong);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGridViewgiohang);
            groupBox2.Controls.Add(buttonxoa);
            groupBox2.Location = new Point(691, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 665);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtthanhtien
            // 
            txtthanhtien.Location = new Point(122, 600);
            txtthanhtien.Name = "txtthanhtien";
            txtthanhtien.Size = new Size(245, 27);
            txtthanhtien.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 607);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 9;
            label2.Text = "Thành tiền ";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(122, 559);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(245, 27);
            txtsoluong.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 559);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 7;
            label1.Text = "Số lượng ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 729);
            Controls.Add(groupBox2);
            Controls.Add(buttonthanhtoan);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewsanpham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewgiohang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewsanpham;
        private Button buttonthem;
        private Button buttonxoa;
        private Button buttonthanhtoan;
        private DataGridView dataGridViewgiohang;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtsoluong;
        private Label label1;
        private TextBox txtthanhtien;
    }
}
