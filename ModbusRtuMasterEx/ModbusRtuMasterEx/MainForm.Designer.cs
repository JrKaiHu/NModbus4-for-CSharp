namespace ModbusRtuMasterEx
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnReadCoils = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWriteCoil = new System.Windows.Forms.Button();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.btnReadInputs = new System.Windows.Forms.Button();
            this.btnReadHoldingRegs = new System.Windows.Forms.Button();
            this.btnReadInputRegs = new System.Windows.Forms.Button();
            this.btnWriteHoldingReg = new System.Windows.Forms.Button();
            this.btnWriteCoils = new System.Windows.Forms.Button();
            this.btnWriteHoldingRegs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(432, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(164, 67);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnReadCoils
            // 
            this.btnReadCoils.Location = new System.Drawing.Point(32, 27);
            this.btnReadCoils.Name = "btnReadCoils";
            this.btnReadCoils.Size = new System.Drawing.Size(164, 67);
            this.btnReadCoils.TabIndex = 1;
            this.btnReadCoils.Text = "ReadCoils";
            this.btnReadCoils.UseVisualStyleBackColor = true;
            this.btnReadCoils.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(432, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 67);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // btnWriteCoil
            // 
            this.btnWriteCoil.Location = new System.Drawing.Point(219, 27);
            this.btnWriteCoil.Name = "btnWriteCoil";
            this.btnWriteCoil.Size = new System.Drawing.Size(164, 67);
            this.btnWriteCoil.TabIndex = 3;
            this.btnWriteCoil.Text = "WriteCoil";
            this.btnWriteCoil.UseVisualStyleBackColor = true;
            this.btnWriteCoil.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // sp
            // 
            this.sp.PortName = "COM5";
            // 
            // btnReadInputs
            // 
            this.btnReadInputs.Location = new System.Drawing.Point(32, 127);
            this.btnReadInputs.Name = "btnReadInputs";
            this.btnReadInputs.Size = new System.Drawing.Size(164, 67);
            this.btnReadInputs.TabIndex = 4;
            this.btnReadInputs.Text = "ReadInputs";
            this.btnReadInputs.UseVisualStyleBackColor = true;
            this.btnReadInputs.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // btnReadHoldingRegs
            // 
            this.btnReadHoldingRegs.Location = new System.Drawing.Point(32, 227);
            this.btnReadHoldingRegs.Name = "btnReadHoldingRegs";
            this.btnReadHoldingRegs.Size = new System.Drawing.Size(164, 67);
            this.btnReadHoldingRegs.TabIndex = 5;
            this.btnReadHoldingRegs.Text = "ReadHoldingRegs";
            this.btnReadHoldingRegs.UseVisualStyleBackColor = true;
            this.btnReadHoldingRegs.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // btnReadInputRegs
            // 
            this.btnReadInputRegs.Location = new System.Drawing.Point(32, 327);
            this.btnReadInputRegs.Name = "btnReadInputRegs";
            this.btnReadInputRegs.Size = new System.Drawing.Size(164, 67);
            this.btnReadInputRegs.TabIndex = 6;
            this.btnReadInputRegs.Text = "ReadInputRegs";
            this.btnReadInputRegs.UseVisualStyleBackColor = true;
            this.btnReadInputRegs.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // btnWriteHoldingReg
            // 
            this.btnWriteHoldingReg.Location = new System.Drawing.Point(219, 127);
            this.btnWriteHoldingReg.Name = "btnWriteHoldingReg";
            this.btnWriteHoldingReg.Size = new System.Drawing.Size(164, 67);
            this.btnWriteHoldingReg.TabIndex = 7;
            this.btnWriteHoldingReg.Text = "WriteHoldingReg";
            this.btnWriteHoldingReg.UseVisualStyleBackColor = true;
            this.btnWriteHoldingReg.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // btnWriteCoils
            // 
            this.btnWriteCoils.Location = new System.Drawing.Point(219, 227);
            this.btnWriteCoils.Name = "btnWriteCoils";
            this.btnWriteCoils.Size = new System.Drawing.Size(164, 67);
            this.btnWriteCoils.TabIndex = 8;
            this.btnWriteCoils.Text = "WriteCoils";
            this.btnWriteCoils.UseVisualStyleBackColor = true;
            this.btnWriteCoils.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // btnWriteHoldingRegs
            // 
            this.btnWriteHoldingRegs.Location = new System.Drawing.Point(219, 327);
            this.btnWriteHoldingRegs.Name = "btnWriteHoldingRegs";
            this.btnWriteHoldingRegs.Size = new System.Drawing.Size(164, 67);
            this.btnWriteHoldingRegs.TabIndex = 9;
            this.btnWriteHoldingRegs.Text = "WriteHoldingRegs";
            this.btnWriteHoldingRegs.UseVisualStyleBackColor = true;
            this.btnWriteHoldingRegs.Click += new System.EventHandler(this.OnRWButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnWriteHoldingRegs);
            this.Controls.Add(this.btnWriteCoils);
            this.Controls.Add(this.btnWriteHoldingReg);
            this.Controls.Add(this.btnReadInputRegs);
            this.Controls.Add(this.btnReadHoldingRegs);
            this.Controls.Add(this.btnReadInputs);
            this.Controls.Add(this.btnWriteCoil);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReadCoils);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "ModbusRtuMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnReadCoils;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWriteCoil;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Button btnReadInputs;
        private System.Windows.Forms.Button btnReadHoldingRegs;
        private System.Windows.Forms.Button btnReadInputRegs;
        private System.Windows.Forms.Button btnWriteHoldingReg;
        private System.Windows.Forms.Button btnWriteCoils;
        private System.Windows.Forms.Button btnWriteHoldingRegs;
    }
}

