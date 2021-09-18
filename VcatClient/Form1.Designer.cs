namespace VcatClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOrderPhase = new System.Windows.Forms.ComboBox();
            this.cbAfterSendOrder = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtStartBuyTimestamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbExecutePhase = new System.Windows.Forms.ComboBox();
            this.cbExecuteMain = new System.Windows.Forms.ComboBox();
            this.cbMakeNewOrder = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPatchContext = new System.Windows.Forms.Button();
            this.btnNowStartBuyTimestamp = new System.Windows.Forms.Button();
            this.txtPatchContextResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(216, 362);
            this.textBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPatchContextResult);
            this.splitContainer1.Panel2.Controls.Add(this.btnNowStartBuyTimestamp);
            this.splitContainer1.Panel2.Controls.Add(this.btnPatchContext);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.cbMakeNewOrder);
            this.splitContainer1.Panel2.Controls.Add(this.cbExecuteMain);
            this.splitContainer1.Panel2.Controls.Add(this.cbExecutePhase);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtStartBuyTimestamp);
            this.splitContainer1.Panel2.Controls.Add(this.txtOrderId);
            this.splitContainer1.Panel2.Controls.Add(this.cbAfterSendOrder);
            this.splitContainer1.Panel2.Controls.Add(this.cbOrderPhase);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(501, 401);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "orderPhase";
            // 
            // cbOrderPhase
            // 
            this.cbOrderPhase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrderPhase.FormattingEnabled = true;
            this.cbOrderPhase.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "StopLoss",
            "Wait",
            "undefined"});
            this.cbOrderPhase.Location = new System.Drawing.Point(136, 10);
            this.cbOrderPhase.Name = "cbOrderPhase";
            this.cbOrderPhase.Size = new System.Drawing.Size(121, 20);
            this.cbOrderPhase.TabIndex = 1;
            // 
            // cbAfterSendOrder
            // 
            this.cbAfterSendOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAfterSendOrder.FormattingEnabled = true;
            this.cbAfterSendOrder.Items.AddRange(new object[] {
            "true",
            "false",
            "undefined"});
            this.cbAfterSendOrder.Location = new System.Drawing.Point(136, 36);
            this.cbAfterSendOrder.Name = "cbAfterSendOrder";
            this.cbAfterSendOrder.Size = new System.Drawing.Size(121, 20);
            this.cbAfterSendOrder.TabIndex = 2;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderId.Location = new System.Drawing.Point(136, 62);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(121, 19);
            this.txtOrderId.TabIndex = 3;
            // 
            // txtStartBuyTimestamp
            // 
            this.txtStartBuyTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartBuyTimestamp.Location = new System.Drawing.Point(136, 87);
            this.txtStartBuyTimestamp.Name = "txtStartBuyTimestamp";
            this.txtStartBuyTimestamp.Size = new System.Drawing.Size(121, 19);
            this.txtStartBuyTimestamp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "afterSendOrder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "orderId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "startBuyTimestamp";
            // 
            // cbExecutePhase
            // 
            this.cbExecutePhase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExecutePhase.FormattingEnabled = true;
            this.cbExecutePhase.Items.AddRange(new object[] {
            "true",
            "false",
            "undefined"});
            this.cbExecutePhase.Location = new System.Drawing.Point(136, 141);
            this.cbExecutePhase.Name = "cbExecutePhase";
            this.cbExecutePhase.Size = new System.Drawing.Size(121, 20);
            this.cbExecutePhase.TabIndex = 8;
            // 
            // cbExecuteMain
            // 
            this.cbExecuteMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExecuteMain.FormattingEnabled = true;
            this.cbExecuteMain.Items.AddRange(new object[] {
            "true",
            "false",
            "undefined"});
            this.cbExecuteMain.Location = new System.Drawing.Point(136, 167);
            this.cbExecuteMain.Name = "cbExecuteMain";
            this.cbExecuteMain.Size = new System.Drawing.Size(121, 20);
            this.cbExecuteMain.TabIndex = 9;
            // 
            // cbMakeNewOrder
            // 
            this.cbMakeNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMakeNewOrder.FormattingEnabled = true;
            this.cbMakeNewOrder.Items.AddRange(new object[] {
            "true",
            "false",
            "undefined"});
            this.cbMakeNewOrder.Location = new System.Drawing.Point(136, 193);
            this.cbMakeNewOrder.Name = "cbMakeNewOrder";
            this.cbMakeNewOrder.Size = new System.Drawing.Size(121, 20);
            this.cbMakeNewOrder.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "executePhase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "executeMain";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "makeNewOrder";
            // 
            // btnPatchContext
            // 
            this.btnPatchContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatchContext.Location = new System.Drawing.Point(189, 371);
            this.btnPatchContext.Name = "btnPatchContext";
            this.btnPatchContext.Size = new System.Drawing.Size(75, 23);
            this.btnPatchContext.TabIndex = 14;
            this.btnPatchContext.Text = "変更";
            this.btnPatchContext.UseVisualStyleBackColor = true;
            this.btnPatchContext.Click += new System.EventHandler(this.btnPatchContext_Click);
            // 
            // btnNowStartBuyTimestamp
            // 
            this.btnNowStartBuyTimestamp.Location = new System.Drawing.Point(210, 112);
            this.btnNowStartBuyTimestamp.Name = "btnNowStartBuyTimestamp";
            this.btnNowStartBuyTimestamp.Size = new System.Drawing.Size(47, 23);
            this.btnNowStartBuyTimestamp.TabIndex = 15;
            this.btnNowStartBuyTimestamp.Text = "now";
            this.btnNowStartBuyTimestamp.UseVisualStyleBackColor = true;
            this.btnNowStartBuyTimestamp.Click += new System.EventHandler(this.btnNowStartBuyTimestamp_Click);
            // 
            // txtPatchContextResult
            // 
            this.txtPatchContextResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatchContextResult.Location = new System.Drawing.Point(5, 258);
            this.txtPatchContextResult.Multiline = true;
            this.txtPatchContextResult.Name = "txtPatchContextResult";
            this.txtPatchContextResult.ReadOnly = true;
            this.txtPatchContextResult.Size = new System.Drawing.Size(252, 107);
            this.txtPatchContextResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 401);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartBuyTimestamp;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.ComboBox cbAfterSendOrder;
        private System.Windows.Forms.ComboBox cbOrderPhase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMakeNewOrder;
        private System.Windows.Forms.ComboBox cbExecuteMain;
        private System.Windows.Forms.ComboBox cbExecutePhase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPatchContext;
        private System.Windows.Forms.Button btnNowStartBuyTimestamp;
        private System.Windows.Forms.TextBox txtPatchContextResult;
    }
}

