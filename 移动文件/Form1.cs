using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 移动文件
{
    public partial class Form1 : Form
    {
        public static List<string> Counts = new List<string>();
        public static List<string> typeList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox1.Text = path.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            string sourceFilePath = textBox1.Text;
            string toFilePath = textBox2.Text;
            if (!Directory.Exists(toFilePath)){
                Directory.CreateDirectory(toFilePath);
            }
            GetFiles(sourceFilePath,toFilePath);
            ClearDir(sourceFilePath);
            MessageBox.Show("结束");
            button3.Enabled = true;
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="toFilePath"></param>
        private void GetFiles(string path,string toFilePath)
        {
            string fileType = string.Empty;
            string fileName = string.Empty;
            string dirFileType = string.Empty;
            string[] files = Directory.GetFiles(path);
            if (files.Length > 0)
            {
                foreach (var item in files)
                {
                    fileType = Path.GetExtension(item);
                    fileName = Path.GetFileName(item);
                    dirFileType = $"{toFilePath}\\{fileType.Replace(',', '_') }";
                    try
                    {
                        if (!Directory.Exists(dirFileType))
                        {
                            Directory.CreateDirectory(dirFileType);
                        }
                        if (!File.Exists($"{dirFileType}\\{fileName}"))
                        {
                            File.Move(item, $"{dirFileType}\\{fileName}");
                            // File.Move(item, $"{dirFileType}\\{fileName}");
                        }
                    }
                    catch (Exception e){
                    }
                }
            }
            string[] paths = Directory.GetDirectories(path);
            foreach (var item in paths)
            {
                GetFiles(item,toFilePath);
            }
           
            
        }

        /// <summary>
        /// 清除空文件夹
        /// </summary>
        /// <param name="path"></param>
        private void ClearDir(string path)
        {
            string[] paths = Directory.GetDirectories(path);
            string[] files =  Directory.GetFiles(path);
            if (paths.Length == 0)
            {
                if (files.Length == 0)
                {
                    try
                    {
                        Directory.Delete(path);
                    }
                    catch(Exception e)
                    {

                    }
                   
                }
            }else
            {
                foreach (var item in paths)
                {
                    ClearDir(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox2.Text = path.SelectedPath;
        }
    }
}
