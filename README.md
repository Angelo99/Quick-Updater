Quick-Updater
=============

C# Simple Update Class

1.Put Update.xml file to Your Server<br>
2.then add the app_updater.cs Class into your Project<br>
3.Paste Update.xml url into Class<br><br>


Example:<br><br>

    string UpdateInfo = APP_UPDATER.CheckVersion("http://localhost/ac/update.xml");//Set UpdateXml File url
    string[] SplitUpdateInfo = UpdateInfo.Split('@');<br>
        if (this.ProductVersion != SplitUpdateInfo[0]) //Compering Old version and Available Version
            {
                MessageBox.Show("Current version " + this.ProductVersion + " Available Version " + SplitUpdateInfo[0]); 
                MessageBox.Show("Patch " + SplitUpdateInfo[1]);
            }
