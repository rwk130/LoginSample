This is a simple project that consists of 3 front end pages. I focused mainly on the backend code here, so a more pleasent UI will be added later.

index.aspx
	This page creates a new user. It validates the user name, address, and email entered and generates a unique password.

login.aspx
	This page takes the email address entered previously and the generated password and creates a new session.

loggedin/congrats.aspx
	If use has successfully logged in, a special message is generated. Otherwise, the user is forwarded to the login screen.


Some of this was copied from existing code I had written, and has functions that are unused in this simple example.
A good example of this is the sorting functions in the Contact.cs page. 


All code on all pages in this example was written by me, Richard W Kraemer (with help from StackOverflow when necessary).
