using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stackoverflow_Post_Via_Stack_LIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = post.Titile;
            label5.Text = post.Discription;
            label8.Text = post.VoteStatus.ToString();
            label7.Text = post.DateTime.ToString();
        }

        public static class post
        {
            public static string Discription { get; private set; }
            public static string Titile { get; private set; }
            public static DateTime DateTime { get; private set; }
            public static int VoteStatus { get; private set; }


            public static void SavePost(string DiscInput, string TitleInput)
            {
                Discription = DiscInput;
                Titile = TitleInput;
                DateTime = System.DateTime.Now;
                VoteStatus = 0;


            }

            public static void upvote()
            {
                VoteStatus++;
                
            }

            public static void downvote()
            {
                VoteStatus--;

            }

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = post.Titile;
            label5.Text = post.Discription;
            label8.Text = post.VoteStatus.ToString();
            label7.Text = post.DateTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            post.upvote();
            label8.Text = post.VoteStatus.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            post.downvote();
            label8.Text = post.VoteStatus.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();

            // Display form 2
            secondForm.ShowDialog();

            // Call a method on form1 to update information on form 1. Any code listed after 
            // the show dialog call will process after Form2 is closed.

            label1.Text = post.Titile;
            label5.Text = post.Discription;
            label8.Text = post.VoteStatus.ToString();
            label7.Text = post.DateTime.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
