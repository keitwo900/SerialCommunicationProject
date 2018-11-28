namespace SerialCommunicationTest
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.button_PortUpdate = new System.Windows.Forms.Button();
			this.button_Connect = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_RxMsg = new System.Windows.Forms.TextBox();
			this.comboBox_ComName = new System.Windows.Forms.ComboBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.button_RxMsgClear = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button_TxMsgClear = new System.Windows.Forms.Button();
			this.button_Tx = new System.Windows.Forms.Button();
			this.textBox_TxMsg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Port番号を選択してください";
			// 
			// button_PortUpdate
			// 
			this.button_PortUpdate.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_PortUpdate.Location = new System.Drawing.Point(264, 56);
			this.button_PortUpdate.Name = "button_PortUpdate";
			this.button_PortUpdate.Size = new System.Drawing.Size(75, 32);
			this.button_PortUpdate.TabIndex = 2;
			this.button_PortUpdate.Text = "更新";
			this.button_PortUpdate.UseVisualStyleBackColor = true;
			this.button_PortUpdate.Click += new System.EventHandler(this.button_PortUpdate_Click);
			// 
			// button_Connect
			// 
			this.button_Connect.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_Connect.Location = new System.Drawing.Point(352, 56);
			this.button_Connect.Name = "button_Connect";
			this.button_Connect.Size = new System.Drawing.Size(75, 32);
			this.button_Connect.TabIndex = 3;
			this.button_Connect.Text = "接続";
			this.button_Connect.UseVisualStyleBackColor = true;
			this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(416, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "受信メッセージ";
			// 
			// textBox_RxMsg
			// 
			this.textBox_RxMsg.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_RxMsg.Location = new System.Drawing.Point(408, 152);
			this.textBox_RxMsg.Multiline = true;
			this.textBox_RxMsg.Name = "textBox_RxMsg";
			this.textBox_RxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_RxMsg.Size = new System.Drawing.Size(384, 288);
			this.textBox_RxMsg.TabIndex = 5;
			// 
			// comboBox_ComName
			// 
			this.comboBox_ComName.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.comboBox_ComName.FormattingEnabled = true;
			this.comboBox_ComName.Location = new System.Drawing.Point(112, 56);
			this.comboBox_ComName.Name = "comboBox_ComName";
			this.comboBox_ComName.Size = new System.Drawing.Size(121, 27);
			this.comboBox_ComName.TabIndex = 6;
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// button_RxMsgClear
			// 
			this.button_RxMsgClear.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_RxMsgClear.Location = new System.Drawing.Point(552, 120);
			this.button_RxMsgClear.Name = "button_RxMsgClear";
			this.button_RxMsgClear.Size = new System.Drawing.Size(75, 32);
			this.button_RxMsgClear.TabIndex = 7;
			this.button_RxMsgClear.Text = "クリア";
			this.button_RxMsgClear.UseVisualStyleBackColor = true;
			this.button_RxMsgClear.Click += new System.EventHandler(this.button_RxMsgClear_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(8, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "送信メッセージ";
			// 
			// button_TxMsgClear
			// 
			this.button_TxMsgClear.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_TxMsgClear.Location = new System.Drawing.Point(216, 120);
			this.button_TxMsgClear.Name = "button_TxMsgClear";
			this.button_TxMsgClear.Size = new System.Drawing.Size(75, 31);
			this.button_TxMsgClear.TabIndex = 8;
			this.button_TxMsgClear.Text = "クリア";
			this.button_TxMsgClear.UseVisualStyleBackColor = true;
			this.button_TxMsgClear.Click += new System.EventHandler(this.button_TxMsgClear_Click);
			// 
			// button_Tx
			// 
			this.button_Tx.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_Tx.Location = new System.Drawing.Point(136, 120);
			this.button_Tx.Name = "button_Tx";
			this.button_Tx.Size = new System.Drawing.Size(75, 31);
			this.button_Tx.TabIndex = 8;
			this.button_Tx.Text = "送信";
			this.button_Tx.UseVisualStyleBackColor = true;
			this.button_Tx.Click += new System.EventHandler(this.button_Tx_Click);
			// 
			// textBox_TxMsg
			// 
			this.textBox_TxMsg.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_TxMsg.Location = new System.Drawing.Point(8, 152);
			this.textBox_TxMsg.Multiline = true;
			this.textBox_TxMsg.Name = "textBox_TxMsg";
			this.textBox_TxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_TxMsg.Size = new System.Drawing.Size(384, 288);
			this.textBox_TxMsg.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox_TxMsg);
			this.Controls.Add(this.button_Tx);
			this.Controls.Add(this.button_TxMsgClear);
			this.Controls.Add(this.button_RxMsgClear);
			this.Controls.Add(this.comboBox_ComName);
			this.Controls.Add(this.textBox_RxMsg);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_Connect);
			this.Controls.Add(this.button_PortUpdate);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_PortUpdate;
		private System.Windows.Forms.Button button_Connect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_RxMsg;
		private System.Windows.Forms.ComboBox comboBox_ComName;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button button_RxMsgClear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_TxMsgClear;
		private System.Windows.Forms.Button button_Tx;
		private System.Windows.Forms.TextBox textBox_TxMsg;
	}
}

