﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen
{
    public partial class MENU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EJERCICIO/Index");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Numeros/Index");
        }
    }
}