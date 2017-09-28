using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Security;

namespace rwkraemer.Code
{
    public class Contact
    {
        #region Fields
        
            private string _FirstName;
            private string _MiddleName;
            private string _LastName;
            private string _Address;
            private string _Email;
            private string _Password;

        #endregion

        #region Properties

            public string FirstName
            {
                get
                {
                    if( _FirstName == null )
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return _FirstName;
                    }
                }
                set
                {
                    _FirstName = value;
                }
            }

            public string MiddleName
            {
                get
                {
                    if( _MiddleName == null )
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return _MiddleName;
                    }
                }
                set
                {
                    _MiddleName = value;
                }
            }

            public string LastName
            {
                get
                {
                    if( _LastName == null )
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return _LastName;
                    }
                }
                set
                {
                    _LastName = value;
                }
            }

            public string Address
            {
                get
                {
                    if( _Address == null )
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return _Address;
                    }
                }
                set
                {
                    _Address = value;
                }
            }

            public string Email
            {
                get
                {
                    if( _Email == null )
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return _Email;
                    }
                }
                set
                {
                    _Email = value;
                }
            }

            public string Password
            {
                get
                {
                    if( _Password == null )
                    {
                        return String.Empty;
                    }
                    else
                    {
                        return _Password;
                    }
                }
                set
                {
                    _Password = value;
                }
            }

        #endregion

        #region Constructors

            public Contact()
            {
                //
                // TODO: Add constructor logic here
                //
            }

            public string DisplayName()
            {
                string aName = _FirstName + " ";
                if( !String.IsNullOrEmpty( _MiddleName ) )
                {
                    aName += _MiddleName.Substring( 0, 1 ) + " ";
                }
                aName += _LastName;
                return aName;
            }

            public string CreatePassword()
            {
                string[] mAlpha = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z" };

                int mLength = PageUtility.GetRandom( 7, 10 );
                int mSmall;
                if( mLength < 9 )
                {
                    mSmall = 4;
                }
                else
                {
                    mSmall = 5;
                }
                int mNumbers = PageUtility.GetRandom( mSmall, 5 );

                string[] mNewPass = new string[mLength];
                for( int x = 0; x < mLength; x++ )
                {
                    if( x == 0 )
                    {
                        mNewPass[x] = mAlpha[PageUtility.GetRandom( 0, 24 )].ToUpper();
                    }
                    else if( x < mNumbers )
                    {
                        mNewPass[x] = PageUtility.GetRandom( 0, 9 ).ToString();
                    }
                    else
                    {
                        mNewPass[x] = mAlpha[PageUtility.GetRandom( 0, 24 )];
                    }
                }

                for( int y = 1; y < mLength; y++ )
                {
                    int position = PageUtility.GetRandom( 1, y );
                    string temp = mNewPass[y];
                    mNewPass[y] = mNewPass[position];
                    mNewPass[position] = temp;
                }

                _Password = String.Empty;
                for( int z = 0; z < mLength; z++ )
                {
                    _Password += mNewPass[z];
                }

                string mReturn = _Password;
                _Password = PageUtility.EncryptPassword( _Password );
                return mReturn;
            }

        #endregion

        #region Methods

        public static Comparison<Contact> SortFirstName =
                delegate( Contact a1, Contact a2 )
                {
                    return a1.FirstName.CompareTo( a2.FirstName );
                };

        public static Comparison<Contact> SortName =
                delegate( Contact a1, Contact a2 )
                {
                    if( a1.LastName.CompareTo( a2.LastName ) == 0 )
                    {
                        return a1.FirstName.CompareTo( a2.FirstName );
                    }
                    else
                    {
                        return ( a1.LastName.CompareTo( a2.LastName ) );
                    }
                };

        #endregion
    }
}
