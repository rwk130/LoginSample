using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rwkraemer.Code
{
    public class AppConfig
    {
        #region Fields
        
            private const string CONTACT_CODE = "SESSION_CONTACTS_CODE";

        #endregion

        #region Properties

            public static Contact User
            {
                get
                {
                    if( HttpContext.Current.Session[ CONTACT_CODE ] == null )
                    {
                        return new Contact();
                    }
                    else
                    {
                        return (Contact)HttpContext.Current.Session[ CONTACT_CODE ];
                    }
                }
                set
                {
                    HttpContext.Current.Session[ CONTACT_CODE ] = value;
                }
            }

        #endregion
    }
}