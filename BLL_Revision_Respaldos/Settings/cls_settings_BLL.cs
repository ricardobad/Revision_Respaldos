using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL_Revision_Respaldos.Settings;


namespace BLL_Revision_Respaldos.Settings
{
    public class cls_settings_BLL
    {
        public void obtenerInfo(ref cls_settings_DAL DAL_sett)
        {
            // llamada a ruta de carpeta compartida    DAL_sett.sSharedPath = 
            //DAL_sett.sSharedPath = @"\\fileserver\Publico\WSUS";
            try
            {
                DAL_sett.aFileDirectory = Directory.GetFiles(DAL_sett.sSharedPath);

                foreach (string file in DAL_sett.aFileDirectory)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    DAL_sett.sFile = Convert.ToString(fileInfo.Name);
                    DAL_sett.sFileDate = Convert.ToString(fileInfo.LastWriteTime);
                    //Console.WriteLine($"Nombre del archivo: {fileInfo.Name}");
                    //Console.WriteLine($"Hora de modificación: {fileInfo.LastWriteTime}");
                }
                DAL_sett.sErrorMsj = "";
            }

            catch (Exception ex)
            {
                DAL_sett.sErrorMsj = "An error has ocurred " + ex.Message;
            }



        }

        public void addFolders(ref cls_settings_DAL DAL) 
        {
            DAL.lsFolderList.Add(DAL.sSharedPath);
            DAL.iCount = DAL.lsFolderList.Count;
            
        }
    }
}
