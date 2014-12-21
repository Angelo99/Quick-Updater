Quick-Updater
=============

C# Simple Update Class

Example::

using Update;

//Add This code to Your Update Button
 string UpdateInfo = APP_UPDATER.CheckVersion("http://localhost/ac/update.xml");//Set UpdateXml File url
string[] SplitUpdateInfo = UpdateInfo.Split('@');
if (this.ProductVersion != SplitUpdateInfo[0]) //Compering Old version and Available Version
{
MessageBox.Show("Current version " + this.ProductVersion + " Available Version " + SplitUpdateInfo[0]);
MessageBox.Show("Patch " + SplitUpdateInfo[1]);
}
