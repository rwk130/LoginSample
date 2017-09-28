using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace rwkraemer.Code
{
    public class PageUtility
    {
        public static bool Alpha_Capitalized_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            string mTemp = aTextBox.Text.Trim();
            mTemp = mTemp.ToLower();
            mTemp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase( mTemp );
            Match MyRegMatch = Regex.Match( mTemp, @"^[a-zA-Z- ]*$" );
            if( MyRegMatch.Success )
            {
                mValid = true;
                aTextBox.Text = mTemp;
            }

            return mValid;
        }

        public static bool Alpha_Capitalized_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                mTemp = mTemp.ToLower();
                mTemp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase( mTemp );
                Match mMyRegMatch = Regex.Match( mTemp, @"^[a-zA-Z ]*$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static bool Alpha_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            string mTemp = aTextBox.Text.Trim();
            Match mMyRegMatch = Regex.Match( mTemp, @"^[a-zA-Z ]*$" );
            if( mMyRegMatch.Success )
            {
                mValid = true;
                aTextBox.Text = mTemp;
            }

            return mValid;
        }

        public static bool Alpha_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^[a-zA-Z'\-\s ]*$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static bool AlphaNumeric_Capitalized_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            string mTemp = aTextBox.Text.Trim();
            mTemp = mTemp.ToLower();
            mTemp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase( mTemp );
            Match mMyRegMatch = Regex.Match( mTemp, @"^[0-9a-zA-Z ]*$" );
            if( mMyRegMatch.Success )
            {
                mValid = true;
                aTextBox.Text = mTemp;
            }
            return mValid;
        }

        public static bool AlphaNumeric_Capitalized_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                mTemp = mTemp.ToLower();
                mTemp = CultureInfo.CurrentCulture.TextInfo.ToTitleCase( mTemp );
                Match mMyRegMatch = Regex.Match( mTemp, @"^[0-9a-zA-Z ]*$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static bool AlphaNumeric_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            string mTemp = aTextBox.Text.Trim();
            Match mMyRegMatch = Regex.Match( mTemp, @"^[0-9a-zA-Z _+]*$" );
            if( mMyRegMatch.Success )
            {
                mValid = true;
                aTextBox.Text = mTemp;
            }
            return mValid;
        }

        public static bool AlphaNumeric_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^[0-9a-zA-Z. ]*$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static bool AlphaNumericSpecial_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^[0-9a-zA-Z.,';!?@$%&*()<>:`~ ]*$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static bool Date_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                try
                {
                    DateTime mTest = DateTime.ParseExact( mTemp, "M/d/yyyy", CultureInfo.InvariantCulture );
                    mValid = true;
                }
                catch
                {
                }
            }
            return mValid;
        }

        public static bool Date_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                try
                {
                    DateTime mTest = DateTime.ParseExact( mTemp, "M/d/yyyy", CultureInfo.InvariantCulture );
                    mValid = true;
                }
                catch
                {
                }
            }
            else
            {
                mValid = true;
            }
            return mValid;
        }

        public static bool Zip_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^\d{5}$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static bool Zip_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^\d{5}$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            else
            {
                mValid = true;
            }
            return mValid;
        }

        public static bool Phone_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Replace( "(", "" ).Replace( ")", "" ).Replace( "-", "" ).Replace( " ", "" ).Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^\d{10}$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                }
            }
            else
            {
                mValid = true;
            }
            return mValid;
        }

        public static bool Email_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                if( aTextBox.Text.Length > 4 && aTextBox.Text.Contains( "@" ) && aTextBox.Text.Contains( "." ) )
                {
                    try
                    {
                        string mTemp = aTextBox.Text.Trim().Substring( 0, aTextBox.Text.IndexOf( "@" ) );
                        string mTemp2 = aTextBox.Text.Trim().Substring( aTextBox.Text.IndexOf( "@" ) + 1 );
                        Match mMyRegMatch = Regex.Match( mTemp, @"^[A-Za-z0-9._%+-]*$" );
                        Match mRegMatch2 = Regex.Match( mTemp2, @"^[A-Za-z0-9.]*$" );
                        if( mMyRegMatch.Success && mRegMatch2.Success )
                        {
                            mValid = true;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            return mValid;
        }

        public static bool Email_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                if( aTextBox.Text.Length > 4 && aTextBox.Text.Contains( "@" ) && aTextBox.Text.Contains( "." ) )
                {
                    try
                    {
                        string mTemp = aTextBox.Text.Trim().Substring( 0, aTextBox.Text.IndexOf( "@" ) );
                        string mTemp2 = aTextBox.Text.Trim().Substring( aTextBox.Text.IndexOf( "@" ) + 1 );
                        Match mMyRegMatch = Regex.Match( mTemp, @"^[A-Za-z0-9._%+-]*$" );
                        Match mRegMatch2 = Regex.Match( mTemp2, @"^[A-Za-z0-9.]*$" );
                        if( mMyRegMatch.Success && mRegMatch2.Success )
                        {
                            mValid = true;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                mValid = true;
            }
            return mValid;
        }

        public static bool Website_Nonrequired( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 0 )
            {
                string mTemp = aTextBox.Text.Trim();
                mValid = Uri.IsWellFormedUriString( mTemp, UriKind.Absolute );
            }
            else
            {
                mValid = true;
            }
            return mValid;
        }

        public static bool Password_Required( TextBox aTextBox )
        {
            bool mValid = false;

            if( aTextBox.Text.Length > 6 && aTextBox.Text.Length < 11 )
            {
                string mTemp = aTextBox.Text.Trim();
                Match mMyRegMatch = Regex.Match( mTemp, @"^[0-9a-zA-Z]*$" );
                if( mMyRegMatch.Success )
                {
                    mValid = true;
                    aTextBox.Text = mTemp;
                }
            }
            return mValid;
        }

        public static string EncryptPassword( string aPassword )
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA512 hasher = new SHA512CryptoServiceProvider();
            byte[] mPassBytes = hasher.ComputeHash( Encoding.Unicode.GetBytes( aPassword ) );
            string mNewPass = String.Empty;
            foreach( byte b in mPassBytes )
            {
                mNewPass += String.Format( "{0,2:X2}", b );
            }
            return mNewPass;
        }

        public static int GetRandom( int aFrom, int aTo )
        {
            System.Security.Cryptography.RandomNumberGenerator mRandom = System.Security.Cryptography.RandomNumberGenerator.Create();
            byte[] mByte = new byte[1];
            mRandom.GetNonZeroBytes( mByte );
            return ( mByte[0] % ( ( aTo - aFrom ) + 1 ) ) + aFrom;
        }
    }
}