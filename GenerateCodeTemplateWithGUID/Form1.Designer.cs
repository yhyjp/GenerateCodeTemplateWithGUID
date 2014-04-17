namespace GenerateCodeTemplateWithGUID
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
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
      this.buttonRefresh = new System.Windows.Forms.Button();
      this.buttonCopy = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.richTextBoxSrc = new System.Windows.Forms.RichTextBox();
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.textBoxGUID = new System.Windows.Forms.TextBox();
      this.buttonLoadFile = new System.Windows.Forms.Button();
      this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
      this.richTextBoxVariable = new System.Windows.Forms.RichTextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonRefresh
      // 
      this.buttonRefresh.Location = new System.Drawing.Point(395, 18);
      this.buttonRefresh.Name = "buttonRefresh";
      this.buttonRefresh.Size = new System.Drawing.Size(46, 23);
      this.buttonRefresh.TabIndex = 0;
      this.buttonRefresh.Text = "更新";
      this.buttonRefresh.UseVisualStyleBackColor = true;
      this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
      // 
      // buttonCopy
      // 
      this.buttonCopy.Location = new System.Drawing.Point(320, 120);
      this.buttonCopy.Name = "buttonCopy";
      this.buttonCopy.Size = new System.Drawing.Size(130, 23);
      this.buttonCopy.TabIndex = 5;
      this.buttonCopy.Text = "クリップボードへコピー";
      this.buttonCopy.UseVisualStyleBackColor = true;
      this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 12);
      this.label3.TabIndex = 6;
      this.label3.Text = "$(GUID)";
      // 
      // richTextBoxSrc
      // 
      this.richTextBoxSrc.AcceptsTab = true;
      this.richTextBoxSrc.EnableAutoDragDrop = true;
      this.richTextBoxSrc.Location = new System.Drawing.Point(15, 18);
      this.richTextBoxSrc.Name = "richTextBoxSrc";
      this.richTextBoxSrc.Size = new System.Drawing.Size(426, 117);
      this.richTextBoxSrc.TabIndex = 8;
      this.richTextBoxSrc.Text = "\n";
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(363, 141);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
      this.buttonGenerate.TabIndex = 10;
      this.buttonGenerate.Text = "コード生成";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
      // 
      // textBoxGUID
      // 
      this.textBoxGUID.Location = new System.Drawing.Point(62, 23);
      this.textBoxGUID.Name = "textBoxGUID";
      this.textBoxGUID.ReadOnly = true;
      this.textBoxGUID.Size = new System.Drawing.Size(327, 19);
      this.textBoxGUID.TabIndex = 11;
      // 
      // buttonLoadFile
      // 
      this.buttonLoadFile.Location = new System.Drawing.Point(256, 141);
      this.buttonLoadFile.Name = "buttonLoadFile";
      this.buttonLoadFile.Size = new System.Drawing.Size(101, 23);
      this.buttonLoadFile.TabIndex = 12;
      this.buttonLoadFile.Text = "ファイル読み込み";
      this.buttonLoadFile.UseVisualStyleBackColor = true;
      this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
      // 
      // richTextBoxResult
      // 
      this.richTextBoxResult.Location = new System.Drawing.Point(15, 18);
      this.richTextBoxResult.Name = "richTextBoxResult";
      this.richTextBoxResult.ReadOnly = true;
      this.richTextBoxResult.Size = new System.Drawing.Size(435, 96);
      this.richTextBoxResult.TabIndex = 13;
      this.richTextBoxResult.Text = "";
      // 
      // richTextBoxVariable
      // 
      this.richTextBoxVariable.AcceptsTab = true;
      this.richTextBoxVariable.EnableAutoDragDrop = true;
      this.richTextBoxVariable.Location = new System.Drawing.Point(9, 48);
      this.richTextBoxVariable.Name = "richTextBoxVariable";
      this.richTextBoxVariable.Size = new System.Drawing.Size(428, 82);
      this.richTextBoxVariable.TabIndex = 14;
      this.richTextBoxVariable.Text = "$(EXAMPLE) example\n$(NS_1) XXX\n$(DEF) YYY\n";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.richTextBoxVariable);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBoxGUID);
      this.groupBox1.Controls.Add(this.buttonRefresh);
      this.groupBox1.Location = new System.Drawing.Point(22, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(447, 143);
      this.groupBox1.TabIndex = 16;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "変数リスト";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.richTextBoxSrc);
      this.groupBox2.Controls.Add(this.buttonGenerate);
      this.groupBox2.Controls.Add(this.buttonLoadFile);
      this.groupBox2.Location = new System.Drawing.Point(16, 174);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(451, 174);
      this.groupBox2.TabIndex = 17;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "入力";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.richTextBoxResult);
      this.groupBox3.Controls.Add(this.buttonCopy);
      this.groupBox3.Location = new System.Drawing.Point(16, 366);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(453, 156);
      this.groupBox3.TabIndex = 18;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "生成結果";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(494, 532);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "GUID Code Templater";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonRefresh;
    private System.Windows.Forms.Button buttonCopy;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox richTextBoxSrc;
    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.TextBox textBoxGUID;
    private System.Windows.Forms.Button buttonLoadFile;
    private System.Windows.Forms.RichTextBox richTextBoxResult;
    private System.Windows.Forms.RichTextBox richTextBoxVariable;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
  }
}

