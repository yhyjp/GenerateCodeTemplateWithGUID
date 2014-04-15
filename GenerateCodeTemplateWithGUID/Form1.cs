using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GenerateCodeTemplateWithGUID
{
  public partial class Form1 : Form
  {
    String currentGUID_;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      refreshGUID();
    }

    private void loadTemplateFile()
    {
      OpenFileDialog ofd = new OpenFileDialog();

      ofd.Filter = "すべてのファイル(*.*)|*.*";
      ofd.Title = "開くテンプレートファイルを選択してください";
      ofd.RestoreDirectory = true;
      ofd.CheckFileExists = true;
      ofd.CheckPathExists = true;

      if (ofd.ShowDialog() != DialogResult.OK)
      {
        return;
      }

      String fileName = ofd.FileName;
      StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("Shift_JIS"));
      richTextBoxSrc.Text = sr.ReadToEnd();
      sr.Close();
    }

    private String genGUID()
    {
      Guid guid = Guid.NewGuid();
      String t = guid.ToString().Replace("-", "").ToUpper();
      currentGUID_ = t;
      return t.ToString();
    }

    private void refreshGUID()
    {
      textBoxGUID.Text = genGUID();
      generateResult();
    }

    private void generateResult()
    {
      String res = richTextBoxSrc.Text;
      res = res.Replace("$(GUID)", currentGUID_);

      List<String> variable = new List<string>();
      String[] vars = richTextBoxVariable.Text.Split('\n');
      foreach (String v in vars)
      {
        String[] vr = v.Split(' ');
        if (vr.Length != 2) continue;
        res = res.Replace(vr[0], vr[1]);
      }

      richTextBoxResult.Text = res;
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
      refreshGUID();
    }

    private void buttonGenerate_Click(object sender, EventArgs e)
    {
      generateResult();
    }

    private void buttonCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetDataObject(richTextBoxResult.Text, true);
    }

    private void buttonLoadFile_Click(object sender, EventArgs e)
    {
      loadTemplateFile();
    }
  }
}
