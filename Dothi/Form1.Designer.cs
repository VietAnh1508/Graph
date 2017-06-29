namespace Dothi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePictrureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSoDinh = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lsvThongTinDoThi = new System.Windows.Forms.ListView();
            this.Dinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BanBacVao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BanBacRa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDisplayMatrix = new System.Windows.Forms.TextBox();
            this.lblDinhBacMin = new System.Windows.Forms.Label();
            this.lblDinhBacMax = new System.Windows.Forms.Label();
            this.lblGraphType = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbVeTrucTiep = new System.Windows.Forms.RadioButton();
            this.rdbNhapTrucTiep = new System.Windows.Forms.RadioButton();
            this.rdbDocTuFile = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSoCanh = new System.Windows.Forms.Label();
            this.lblSoBac = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCanhCung = new System.Windows.Forms.DataGridView();
            this.Dau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Ve = new System.Windows.Forms.GroupBox();
            this.rdbDiChuyen = new System.Windows.Forms.RadioButton();
            this.rdbVeCanh = new System.Windows.Forms.RadioButton();
            this.rdbVeNode = new System.Windows.Forms.RadioButton();
            this.cmbHuong = new System.Windows.Forms.ComboBox();
            this.cmbTrongSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tìmCâyKhungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhCung)).BeginInit();
            this.Ve.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.tìmCâyKhungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablePictrureToolStripMenuItem,
            this.editGraphToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // tablePictrureToolStripMenuItem
            // 
            this.tablePictrureToolStripMenuItem.Name = "tablePictrureToolStripMenuItem";
            this.tablePictrureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tablePictrureToolStripMenuItem.Text = "Output";
            this.tablePictrureToolStripMenuItem.Click += new System.EventHandler(this.tablePictrureToolStripMenuItem_Click);
            // 
            // editGraphToolStripMenuItem
            // 
            this.editGraphToolStripMenuItem.Name = "editGraphToolStripMenuItem";
            this.editGraphToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editGraphToolStripMenuItem.Text = "Take picture";
            this.editGraphToolStripMenuItem.Click += new System.EventHandler(this.editGraphToolStripMenuItem_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1139, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 26);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(892, 33);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(241, 26);
            this.txtPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // lblSoDinh
            // 
            this.lblSoDinh.AutoSize = true;
            this.lblSoDinh.Location = new System.Drawing.Point(15, 34);
            this.lblSoDinh.Name = "lblSoDinh";
            this.lblSoDinh.Size = new System.Drawing.Size(66, 18);
            this.lblSoDinh.TabIndex = 10;
            this.lblSoDinh.Text = "Số đỉnh: ";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(315, 331);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 30);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "Hiển thị";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lsvThongTinDoThi
            // 
            this.lsvThongTinDoThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dinh,
            this.Bac,
            this.BanBacVao,
            this.BanBacRa});
            this.lsvThongTinDoThi.Enabled = false;
            this.lsvThongTinDoThi.GridLines = true;
            this.lsvThongTinDoThi.Location = new System.Drawing.Point(12, 290);
            this.lsvThongTinDoThi.Name = "lsvThongTinDoThi";
            this.lsvThongTinDoThi.Size = new System.Drawing.Size(293, 246);
            this.lsvThongTinDoThi.TabIndex = 14;
            this.lsvThongTinDoThi.UseCompatibleStateImageBehavior = false;
            this.lsvThongTinDoThi.View = System.Windows.Forms.View.Details;
            // 
            // Dinh
            // 
            this.Dinh.Text = "Đỉnh";
            this.Dinh.Width = 65;
            // 
            // Bac
            // 
            this.Bac.Text = "Bậc";
            this.Bac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BanBacVao
            // 
            this.BanBacVao.Text = "Bán bậc vào";
            this.BanBacVao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BanBacVao.Width = 85;
            // 
            // BanBacRa
            // 
            this.BanBacRa.Text = "Bán bậc ra";
            this.BanBacRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BanBacRa.Width = 85;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(666, 65);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(536, 471);
            this.pnlGraph.TabIndex = 15;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseDown);
            this.pnlGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
            this.pnlGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDisplayMatrix);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ma trận";
            // 
            // txtDisplayMatrix
            // 
            this.txtDisplayMatrix.Location = new System.Drawing.Point(6, 26);
            this.txtDisplayMatrix.Multiline = true;
            this.txtDisplayMatrix.Name = "txtDisplayMatrix";
            this.txtDisplayMatrix.Size = new System.Drawing.Size(123, 152);
            this.txtDisplayMatrix.TabIndex = 0;
            // 
            // lblDinhBacMin
            // 
            this.lblDinhBacMin.AutoSize = true;
            this.lblDinhBacMin.Location = new System.Drawing.Point(15, 182);
            this.lblDinhBacMin.Name = "lblDinhBacMin";
            this.lblDinhBacMin.Size = new System.Drawing.Size(156, 18);
            this.lblDinhBacMin.TabIndex = 12;
            this.lblDinhBacMin.Text = "Đỉnh có bậc nhỏ nhất: ";
            // 
            // lblDinhBacMax
            // 
            this.lblDinhBacMax.AutoSize = true;
            this.lblDinhBacMax.Location = new System.Drawing.Point(15, 141);
            this.lblDinhBacMax.Name = "lblDinhBacMax";
            this.lblDinhBacMax.Size = new System.Drawing.Size(151, 18);
            this.lblDinhBacMax.TabIndex = 11;
            this.lblDinhBacMax.Text = "Đỉnh có bậc lớn nhất: ";
            // 
            // lblGraphType
            // 
            this.lblGraphType.AutoSize = true;
            this.lblGraphType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphType.Location = new System.Drawing.Point(414, 33);
            this.lblGraphType.Name = "lblGraphType";
            this.lblGraphType.Size = new System.Drawing.Size(84, 18);
            this.lblGraphType.TabIndex = 17;
            this.lblGraphType.Text = "Loại đồ thị: ";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(315, 424);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 29);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawGraph.Location = new System.Drawing.Point(315, 377);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(97, 30);
            this.btnDrawGraph.TabIndex = 19;
            this.btnDrawGraph.Text = "Vẽ đồ thị";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbVeTrucTiep);
            this.groupBox2.Controls.Add(this.rdbNhapTrucTiep);
            this.groupBox2.Controls.Add(this.rdbDocTuFile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 165);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // rdbVeTrucTiep
            // 
            this.rdbVeTrucTiep.AutoSize = true;
            this.rdbVeTrucTiep.Location = new System.Drawing.Point(19, 125);
            this.rdbVeTrucTiep.Name = "rdbVeTrucTiep";
            this.rdbVeTrucTiep.Size = new System.Drawing.Size(139, 22);
            this.rdbVeTrucTiep.TabIndex = 2;
            this.rdbVeTrucTiep.TabStop = true;
            this.rdbVeTrucTiep.Text = "Vẽ đồ thị trực tiếp";
            this.rdbVeTrucTiep.UseVisualStyleBackColor = true;
            this.rdbVeTrucTiep.CheckedChanged += new System.EventHandler(this.rdbVeTrucTiep_CheckedChanged);
            // 
            // rdbNhapTrucTiep
            // 
            this.rdbNhapTrucTiep.AutoSize = true;
            this.rdbNhapTrucTiep.Location = new System.Drawing.Point(19, 78);
            this.rdbNhapTrucTiep.Name = "rdbNhapTrucTiep";
            this.rdbNhapTrucTiep.Size = new System.Drawing.Size(163, 22);
            this.rdbNhapTrucTiep.TabIndex = 1;
            this.rdbNhapTrucTiep.TabStop = true;
            this.rdbNhapTrucTiep.Text = "Nhập dữ liệu trực tiếp";
            this.rdbNhapTrucTiep.UseVisualStyleBackColor = true;
            this.rdbNhapTrucTiep.CheckedChanged += new System.EventHandler(this.rdbNhapTrucTiep_CheckedChanged);
            // 
            // rdbDocTuFile
            // 
            this.rdbDocTuFile.AutoSize = true;
            this.rdbDocTuFile.Location = new System.Drawing.Point(19, 36);
            this.rdbDocTuFile.Name = "rdbDocTuFile";
            this.rdbDocTuFile.Size = new System.Drawing.Size(146, 22);
            this.rdbDocTuFile.TabIndex = 0;
            this.rdbDocTuFile.TabStop = true;
            this.rdbDocTuFile.Text = "Đọc ma trận từ file";
            this.rdbDocTuFile.UseVisualStyleBackColor = true;
            this.rdbDocTuFile.CheckedChanged += new System.EventHandler(this.rdbDocTuFile_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSoCanh);
            this.groupBox3.Controls.Add(this.lblSoBac);
            this.groupBox3.Controls.Add(this.lblDinhBacMin);
            this.groupBox3.Controls.Add(this.lblSoDinh);
            this.groupBox3.Controls.Add(this.lblDinhBacMax);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(420, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 222);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // lblSoCanh
            // 
            this.lblSoCanh.AutoSize = true;
            this.lblSoCanh.Location = new System.Drawing.Point(15, 105);
            this.lblSoCanh.Name = "lblSoCanh";
            this.lblSoCanh.Size = new System.Drawing.Size(71, 18);
            this.lblSoCanh.TabIndex = 14;
            this.lblSoCanh.Text = "Số cạnh: ";
            // 
            // lblSoBac
            // 
            this.lblSoBac.AutoSize = true;
            this.lblSoBac.Location = new System.Drawing.Point(15, 67);
            this.lblSoBac.Name = "lblSoBac";
            this.lblSoBac.Size = new System.Drawing.Size(63, 18);
            this.lblSoBac.TabIndex = 13;
            this.lblSoBac.Text = "Số bậc: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCanhCung);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(154, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 190);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách cạnh - cung";
            // 
            // dgvCanhCung
            // 
            this.dgvCanhCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanhCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dau,
            this.Cuoi,
            this.TrongSo});
            this.dgvCanhCung.Location = new System.Drawing.Point(6, 27);
            this.dgvCanhCung.Name = "dgvCanhCung";
            this.dgvCanhCung.Size = new System.Drawing.Size(232, 153);
            this.dgvCanhCung.TabIndex = 0;
            // 
            // Dau
            // 
            this.Dau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Dau.HeaderText = "Đầu";
            this.Dau.Name = "Dau";
            this.Dau.Width = 60;
            // 
            // Cuoi
            // 
            this.Cuoi.HeaderText = "Cuối";
            this.Cuoi.Name = "Cuoi";
            this.Cuoi.Width = 50;
            // 
            // TrongSo
            // 
            this.TrongSo.HeaderText = "Trọng số";
            this.TrongSo.Name = "TrongSo";
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDoi.Location = new System.Drawing.Point(206, 241);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(99, 30);
            this.btnChuyenDoi.TabIndex = 27;
            this.btnChuyenDoi.Text = "Chuyển đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.Location = new System.Drawing.Point(63, 241);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(99, 30);
            this.btnHoanThanh.TabIndex = 28;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // Ve
            // 
            this.Ve.Controls.Add(this.rdbDiChuyen);
            this.Ve.Controls.Add(this.rdbVeCanh);
            this.Ve.Controls.Add(this.rdbVeNode);
            this.Ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ve.Location = new System.Drawing.Point(326, 470);
            this.Ve.Name = "Ve";
            this.Ve.Size = new System.Drawing.Size(320, 66);
            this.Ve.TabIndex = 29;
            this.Ve.TabStop = false;
            this.Ve.Text = "Vẽ";
            // 
            // rdbDiChuyen
            // 
            this.rdbDiChuyen.AutoSize = true;
            this.rdbDiChuyen.Location = new System.Drawing.Point(206, 23);
            this.rdbDiChuyen.Name = "rdbDiChuyen";
            this.rdbDiChuyen.Size = new System.Drawing.Size(91, 22);
            this.rdbDiChuyen.TabIndex = 29;
            this.rdbDiChuyen.TabStop = true;
            this.rdbDiChuyen.Text = "Di chuyển";
            this.rdbDiChuyen.UseVisualStyleBackColor = true;
            this.rdbDiChuyen.CheckedChanged += new System.EventHandler(this.rdbDiChuyen_CheckedChanged);
            // 
            // rdbVeCanh
            // 
            this.rdbVeCanh.AutoSize = true;
            this.rdbVeCanh.Location = new System.Drawing.Point(109, 23);
            this.rdbVeCanh.Name = "rdbVeCanh";
            this.rdbVeCanh.Size = new System.Drawing.Size(79, 22);
            this.rdbVeCanh.TabIndex = 28;
            this.rdbVeCanh.TabStop = true;
            this.rdbVeCanh.Text = "Vẽ cạnh";
            this.rdbVeCanh.UseVisualStyleBackColor = true;
            this.rdbVeCanh.CheckedChanged += new System.EventHandler(this.rdbVeCanh_CheckedChanged);
            // 
            // rdbVeNode
            // 
            this.rdbVeNode.AutoSize = true;
            this.rdbVeNode.Location = new System.Drawing.Point(15, 23);
            this.rdbVeNode.Name = "rdbVeNode";
            this.rdbVeNode.Size = new System.Drawing.Size(74, 22);
            this.rdbVeNode.TabIndex = 27;
            this.rdbVeNode.TabStop = true;
            this.rdbVeNode.Text = "Vẽ đỉnh";
            this.rdbVeNode.UseVisualStyleBackColor = true;
            this.rdbVeNode.CheckedChanged += new System.EventHandler(this.rdbVeNode_CheckedChanged);
            // 
            // cmbHuong
            // 
            this.cmbHuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHuong.FormattingEnabled = true;
            this.cmbHuong.Location = new System.Drawing.Point(504, 30);
            this.cmbHuong.Name = "cmbHuong";
            this.cmbHuong.Size = new System.Drawing.Size(121, 26);
            this.cmbHuong.TabIndex = 30;
            // 
            // cmbTrongSo
            // 
            this.cmbTrongSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrongSo.FormattingEnabled = true;
            this.cmbTrongSo.Location = new System.Drawing.Point(631, 30);
            this.cmbTrongSo.Name = "cmbTrongSo";
            this.cmbTrongSo.Size = new System.Drawing.Size(157, 26);
            this.cmbTrongSo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(794, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Đường dẫn:";
            // 
            // tìmCâyKhungToolStripMenuItem
            // 
            this.tìmCâyKhungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primToolStripMenuItem,
            this.kruskalToolStripMenuItem});
            this.tìmCâyKhungToolStripMenuItem.Name = "tìmCâyKhungToolStripMenuItem";
            this.tìmCâyKhungToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.tìmCâyKhungToolStripMenuItem.Text = "Tìm cây khung";
            // 
            // primToolStripMenuItem
            // 
            this.primToolStripMenuItem.Name = "primToolStripMenuItem";
            this.primToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.primToolStripMenuItem.Text = "Prim";
            this.primToolStripMenuItem.Click += new System.EventHandler(this.primToolStripMenuItem_Click);
            // 
            // kruskalToolStripMenuItem
            // 
            this.kruskalToolStripMenuItem.Name = "kruskalToolStripMenuItem";
            this.kruskalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kruskalToolStripMenuItem.Text = "Kruskal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTrongSo);
            this.Controls.Add(this.cmbHuong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Ve);
            this.Controls.Add(this.lsvThongTinDoThi);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.btnChuyenDoi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblGraphType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Đồ thị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhCung)).EndInit();
            this.Ve.ResumeLayout(false);
            this.Ve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablePictrureToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSoDinh;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListView lsvThongTinDoThi;
        private System.Windows.Forms.ColumnHeader Dinh;
        private System.Windows.Forms.ColumnHeader Bac;
        private System.Windows.Forms.ColumnHeader BanBacVao;
        private System.Windows.Forms.ColumnHeader BanBacRa;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDisplayMatrix;
        private System.Windows.Forms.Label lblDinhBacMin;
        private System.Windows.Forms.Label lblDinhBacMax;
        private System.Windows.Forms.Label lblGraphType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbVeTrucTiep;
        private System.Windows.Forms.RadioButton rdbNhapTrucTiep;
        private System.Windows.Forms.RadioButton rdbDocTuFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.DataGridView dgvCanhCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSo;
        private System.Windows.Forms.Label lblSoBac;
        private System.Windows.Forms.Label lblSoCanh;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox Ve;
        private System.Windows.Forms.RadioButton rdbVeNode;
        private System.Windows.Forms.RadioButton rdbDiChuyen;
        private System.Windows.Forms.RadioButton rdbVeCanh;
        private System.Windows.Forms.ComboBox cmbHuong;
        private System.Windows.Forms.ComboBox cmbTrongSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tìmCâyKhungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalToolStripMenuItem;
    }
}

