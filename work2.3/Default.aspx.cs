using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace work2._3
{
    public partial class Default : System.Web.UI.Page
    {
        CalculatorLogic cl;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label8.Text = "Здравствуйте :-)";
            
            if (IsPostBack)
            {
                cl = new CalculatorLogic();
                
                Label8.Text = "";
                
                Button6.Click += Button6_Click;
                Button7.Click += Button7_Click;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = (Button1.Text == "-") ? (Button1.Text = "+") : (Button1.Text = "-");
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Button5.Text = (Button5.Text == "-") ? (Button5.Text = "+") : (Button5.Text = "-");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button4.Text = (Button4.Text == "-") ? (Button4.Text = "+") : (Button4.Text = "-");
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label8.Text = "";                                              // Delete ?
            Label5.Text = "";
            Label7.Text = "";
            
            cl.ast = Button1.Text + TextBox1.Text;
            cl.bst = Button5.Text + TextBox3.Text;
            cl.cst = Button4.Text + TextBox4.Text;

            cl.Validator();

            cl.DiscriminantCalculations();

            cl.CalculationsX();

            if (cl.ErrorMessage == null)
            {
                Label5.Text = Convert.ToString(cl.X1);
                Label7.Text = Convert.ToString(cl.X2);
                Label8.Text = "Получите свои корни!";
            }
            else
            {
                Label8.Text = cl.ErrorMessage;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            
            Label5.Text = "";
            Label7.Text = "";


        }

        

        
    }
}