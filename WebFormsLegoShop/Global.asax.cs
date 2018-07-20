using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using WebFormsLegoShop.Models;
using WebFormsLegoShop.Logic;

namespace WebFormsLegoShop
{
    public class Global : HttpApplication
    {
        //stores the current online users sessionIds 
        public static List<string> OnlineSessionIds { get; } = new List<string>();

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize the product database.
            Database.SetInitializer(new LegoDBInitializer());
        }

        void Application_End(object sender, EventArgs e)
        {
            //Removes the unused cartItems from the database
            string[] sessionIdsArray = OnlineSessionIds.ToArray();

            using (ShoppingCartActions shoppingCartLogic = new ShoppingCartActions())
            {
                shoppingCartLogic.RemoveCartItems(sessionIdsArray);
            }
        }


        protected void Session_Start(object sender, EventArgs e)
        {
            //Adds the current users session id to the
            OnlineSessionIds.Add(Session.SessionID);
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Removes the unused cartItems from the database
            using (ShoppingCartActions shoppingCartLogic = new ShoppingCartActions())
            {
                shoppingCartLogic.RemoveCartItems(Session.SessionID);
            }

            //Removes the users Id from the OnlineSessionIds list
            OnlineSessionIds.Remove(Session.SessionID);
        }
    }
}