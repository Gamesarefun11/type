using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.IO;  
namespace Cioban_Mini_Text_Editor   
{  
    public partial class Form1: Form  
    {  
        public Form1()  
        {  
            InitializeComponent();  
        }  
        private void button1_Click(object sender, EventArgs e)   
        {  
            openFileDialog1.ShowDialog(); //Shows the dialog   
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Contains(".txt")) //Checks if it's all ok and if the file name contains .txt  
            {  
                string open = File.ReadAllText(openFileDialog1.FileName); //Reads the text from file  
                richTextBox1.Text = open; //Shows the reded text in the textbox  
            }   
            else //If something goes wrong...  
            {  
                MessageBox.Show("The file you've chosen is not a text file");  
            }  
        }  
  
        private void button2_Click(object sender, EventArgs e)   
        {  
            saveFileDialog1.ShowDialog(); //Opens the Show File Dialog  
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Check if it's all ok  
            {  
                string name = saveFileDialog1.FileName + ".txt"; //Just to make sure the extension is .txt  
                File.WriteAllText(name, richTextBox1.Text); //Writes the text to the file and saves it               
            }  
        }  
        private void button3_Click(object sender, EventArgs e)  
        {  
            fontDialog1.ShowDialog(); //Shows the font dialog   
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {  
                richTextBox1.Font = fontDialog1.Font; //Sets the font to the one selected in the dialog  
            }  
        }  
    }  
}
