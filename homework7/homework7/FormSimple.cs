using System;
using System.Drawing;
using System.Windows.Forms;
public class MyForm : Form
{
	public MyForm()
	{
		this.Size = new Size(200,100);
		this.Text = "Form1";
	}
	static void Main()
	{
		Application.Run(new MyForm());
	}

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "MyForm";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);

    }

    private void MyForm_Load(object sender, EventArgs e)
    {

    }
}

