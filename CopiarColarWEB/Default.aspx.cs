﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   // private string var1; 

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // var1 = TextBox1.Text;
        Session["var1"] = TextBox1.Text; 
        TextBox1.Text = ""; 
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //TextBox2.Text = var1; 
        TextBox2.Text = Session["var1"].ToString(); 
    }
}