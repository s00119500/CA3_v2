CA3_v2
======

CA3 due 13/1/2014



 
Started 29/12/2013

1)
⦁	created empty template
⦁	added old version of bootstrap (because current one has errors) Install-Package twitter.bootstrap.mvc4.sample -Version 1.0.90/ previous version
⦁	attached northwind db
⦁	created entity framework file/ models folder
⦁	commented out provided Home controller and index view
⦁	created blank home controller

2)
⦁	Created Db Context Class for entity framework/ models folder. Created Products class.

3)
⦁	Wrote syntax to display all products on the home page (home controller)
⦁	Created Home page view = Index.cshtml
⦁	added using bootstrap statmen to view ....forgot it last time derp. Basic styling.
⦁	Removed that "basic layout = null" so bootstrap works

4) 30/12/2013
Paged List
⦁	install paged list package package via nuget
⦁	page list sytax in controller, set the display limit to six because brief doesn't specify limit.
⦁	updated view to accept only Ipagedlist
⦁	added .first() to the end of all the column titles because an exception is thrown otherwise
⦁	went back to the controller and added .OrderBy(p=> p.ProductID) before the PagedList syntax because we get a NotSupportedException otherwise. 
	{The method 'OrderBy' must be called before the method 'Skip'.}
⦁	Forgot to add the correct using statements again....derp
@using PagedList;
@using PagedList.Mvc;
