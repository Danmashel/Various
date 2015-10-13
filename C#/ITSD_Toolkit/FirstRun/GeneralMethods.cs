using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstRun
{
    class GeneralMethods
    {
        public void updateLog(string tryMessage, string resultMessage)
        {
                Form1.LogBox.Items.Add(tryMessage + resultMessage);
        }

        public void copyFiles()
        {
            bool exists = System.IO.Directory.Exists(@"C:\ITSDTemp");
            if (!exists)
                updateLog(@"---C:\ITSDTemp does not exist", "...Creating");
                System.IO.Directory.CreateDirectory(@"C:\ITSDTemp");

                //Copy SoftPack
                try
                {
                    if (File.Exists("SoftPack.exe"))
                    {
                        File.Copy("SoftPack.exe", @"C:\ITSDTemp\SoftPack.exe");
                        if (File.Exists(@"C:\ITSDTemp\SoftPack.exe"))
                            updateLog("Copying SoftPack.exe", "...Success");
                        else
                            updateLog("Copying SoftPack.exe", "...Failed");
                    }
                    else
                        updateLog("---SoftPack.exe does not exist in sourse directory", " ");

                    //ESET
                    if (File.Exists("Eset64.msi"))
                    {
                        File.Copy("Eset64.msi", @"C:\ITSDTemp\Eset64.msi");
                        if (File.Exists(@"C:\ITSDTemp\Eset64.msi"))
                            updateLog("Copying Eset64.msi", "...Success");
                        else
                            updateLog("Copying Eset64.msi", "...Failed");
                    }
                    else
                        updateLog("---Eset64.msi does not exist in sourse directory", " ");

                    //Winupdate.vbs
                    if (File.Exists("WinUpdate.vbs"))
                    {
                        File.Copy("WinUpdate.vbs", @"C:\ITSDTemp\WinUpdate.vbs");
                        if (File.Exists(@"C:\ITSDTemp\WinUpdate.vbs"))
                            updateLog("Copying WinUpdate.vbs", "...Success");
                        else
                            updateLog("Copying WinUpdate.vbs", "...Failed");
                    }
                    else
                        updateLog("---WinUpdate.vbs does not exist in sourse directory", " ");
                }
                catch (Exception e)
                {
                    updateLog("---Could not copy all source files...possibly permissions?", " ");
                    Console.WriteLine(e);
                }
        }
    }
}
