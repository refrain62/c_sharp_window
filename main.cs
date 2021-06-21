
# 単純なWindowsフォームアプリケーションを作る（C#）
# http://blog.livedoor.jp/morituri/archives/54010486.html


using System;
using System.Windows.Forms;

namespace MyForm1 {
  public class Form1 : Form {
    // ボタンクリック
    private void btn1_Click(object sender, EventArgs e) {
      MessageBox.Show("Clicked");
    }
    
    // コンストラクタ
    public Form1() {
      // ボタン（btn1）
      Button btn1 = new Button();
      btn1.Text = "OK";
      this.Controls.Add(btn1);
      btn1.Click += new EventHandler(this.btn1_Click);
    }

    [STAThread]
    public static void Main() {
      Application.Run(new Form1());
    }
  }
}
