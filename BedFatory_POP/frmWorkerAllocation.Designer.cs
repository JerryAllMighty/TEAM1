
namespace BedFatory_POP
{
    partial class frmWorkerAllocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboWorkPlace = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnAllocateWorker = new FontAwesome.Sharp.IconButton();
            this.btnDeallocateWorker = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.lblWorkPlace = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblWorkerAvailable = new System.Windows.Forms.Label();
            this.dgvWorkerAvailable = new BedFactory.DatagridviewControl();
            this.dgvWorker = new BedFactory.DatagridviewControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // cboWorkPlace
            // 
            this.cboWorkPlace.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboWorkPlace.FormattingEnabled = true;
            this.cboWorkPlace.Location = new System.Drawing.Point(167, 6);
            this.cboWorkPlace.Name = "cboWorkPlace";
            this.cboWorkPlace.Size = new System.Drawing.Size(466, 67);
            this.cboWorkPlace.TabIndex = 1;
            this.cboWorkPlace.SelectedIndexChanged += new System.EventHandler(this.cboWorkPlace_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboWorkPlace);
            this.panel1.Controls.Add(this.lblWorkPlace);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvWorker);
            this.panel3.Location = new System.Drawing.Point(654, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 444);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvWorkerAvailable);
            this.panel4.Location = new System.Drawing.Point(12, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 444);
            this.panel4.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(848, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 75);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "닫기";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMinimize.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(654, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(188, 75);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "최소화";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAllocateWorker
            // 
            this.btnAllocateWorker.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAllocateWorker.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllocateWorker.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnAllocateWorker.IconColor = System.Drawing.Color.Black;
            this.btnAllocateWorker.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllocateWorker.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAllocateWorker.Location = new System.Drawing.Point(362, 240);
            this.btnAllocateWorker.Name = "btnAllocateWorker";
            this.btnAllocateWorker.Size = new System.Drawing.Size(283, 138);
            this.btnAllocateWorker.TabIndex = 7;
            this.btnAllocateWorker.Text = "작업자 할당";
            this.btnAllocateWorker.UseVisualStyleBackColor = false;
            this.btnAllocateWorker.Click += new System.EventHandler(this.btnAllocateWorker_Click);
            // 
            // btnDeallocateWorker
            // 
            this.btnDeallocateWorker.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeallocateWorker.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeallocateWorker.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnDeallocateWorker.IconColor = System.Drawing.Color.Black;
            this.btnDeallocateWorker.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeallocateWorker.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeallocateWorker.Location = new System.Drawing.Point(362, 393);
            this.btnDeallocateWorker.Name = "btnDeallocateWorker";
            this.btnDeallocateWorker.Size = new System.Drawing.Size(283, 138);
            this.btnDeallocateWorker.TabIndex = 8;
            this.btnDeallocateWorker.Text = "작업자 해제";
            this.btnDeallocateWorker.UseVisualStyleBackColor = false;
            this.btnDeallocateWorker.Click += new System.EventHandler(this.btnDeallocateWorker_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(362, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(283, 138);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWorkPlace
            // 
            this.lblWorkPlace.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkPlace.Location = new System.Drawing.Point(3, 6);
            this.lblWorkPlace.Name = "lblWorkPlace";
            this.lblWorkPlace.Size = new System.Drawing.Size(158, 64);
            this.lblWorkPlace.TabIndex = 0;
            this.lblWorkPlace.Text = "작업장";
            // 
            // lblWorker
            // 
            this.lblWorker.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorker.Location = new System.Drawing.Point(644, 154);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(286, 62);
            this.lblWorker.TabIndex = 2;
            this.lblWorker.Text = "대상 작업자";
            // 
            // lblWorkerAvailable
            // 
            this.lblWorkerAvailable.Font = new System.Drawing.Font("맑은 고딕", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkerAvailable.Location = new System.Drawing.Point(12, 154);
            this.lblWorkerAvailable.Name = "lblWorkerAvailable";
            this.lblWorkerAvailable.Size = new System.Drawing.Size(367, 62);
            this.lblWorkerAvailable.TabIndex = 6;
            this.lblWorkerAvailable.Text = "할당 가능 작업자";
            // 
            // dgvWorkerAvailable
            // 
            this.dgvWorkerAvailable.AllowUserToAddRows = false;
            this.dgvWorkerAvailable.AllowUserToResizeRows = false;
            this.dgvWorkerAvailable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWorkerAvailable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWorkerAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkerAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkerAvailable.Location = new System.Drawing.Point(0, 0);
            this.dgvWorkerAvailable.Name = "dgvWorkerAvailable";
            this.dgvWorkerAvailable.RowHeadersVisible = false;
            this.dgvWorkerAvailable.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWorkerAvailable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvWorkerAvailable.RowTemplate.Height = 27;
            this.dgvWorkerAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkerAvailable.Size = new System.Drawing.Size(344, 444);
            this.dgvWorkerAvailable.TabIndex = 0;
            // 
            // dgvWorker
            // 
            this.dgvWorker.AllowUserToAddRows = false;
            this.dgvWorker.AllowUserToResizeRows = false;
            this.dgvWorker.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.dgvWorker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorker.Location = new System.Drawing.Point(0, 0);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersVisible = false;
            this.dgvWorker.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWorker.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvWorker.RowTemplate.Height = 27;
            this.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorker.Size = new System.Drawing.Size(373, 444);
            this.dgvWorker.TabIndex = 0;
            // 
            // frmWorkerAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1039, 702);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeallocateWorker);
            this.Controls.Add(this.btnAllocateWorker);
            this.Controls.Add(this.lblWorkerAvailable);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmWorkerAllocation";
            this.Load += new System.EventHandler(this.frmWorkerAllocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboWorkPlace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private BedFactory.DatagridviewControl dgvWorkerAvailable;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Label lblWorkPlace;
        private FontAwesome.Sharp.IconButton btnAllocateWorker;
        private FontAwesome.Sharp.IconButton btnDeallocateWorker;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblWorkerAvailable;
        private BedFactory.DatagridviewControl dgvWorker;
    }
}