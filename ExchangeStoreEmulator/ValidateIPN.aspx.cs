﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExchangeStoreEmulator
{
    public partial class ValidateIPN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is just a simplest emulator of Exchange store notication validation

            //Autodesk Exchange store will validate IPNListener's notifiation, if it is a valid notifiation which 
            //is sent from Exchange store before, then return "Verified"
            
            if (Request["item_number"] != null && Request["buyer_adsk_account"] != null)
            {
                Response.Write("Verified");
                Response.End();
            }
            else
            {
                Response.Write("not valid IPN notification.");
                Response.End();
            }
        }
    }
}