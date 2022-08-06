// See https://aka.ms/new-console-template for more information

using KevinPena.OrganizeDownloadedFiles.ConsoleTask;

string downloadFolder = @"D:\Users\Equipo\Downloads";

DirectoryInfo dirDownload = new DirectoryInfo(downloadFolder);

foreach (var file in dirDownload.GetFiles())
{
    //To Pictures
    if (Extensions.pictures.Contains(file.Extension))
    {
        file.MoveTo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)+@"\"+file.Name);
    }
    //To Documents
    if (Extensions.documents.Contains(file.Extension))
    {
        file.MoveTo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + file.Name);
    }
}