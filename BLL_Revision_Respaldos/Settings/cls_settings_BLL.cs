﻿using System;
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
            // llamada a ruta de carpeta compartida    
            
            try
            {
                DAL_sett.aFileDirectory = Directory.GetFiles(DAL_sett.sSharedPath);

                foreach (string file in DAL_sett.aFileDirectory)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    DAL_sett.sFile = Convert.ToString(fileInfo.Name);
                    DAL_sett.sFileDate = Convert.ToString(fileInfo.LastWriteTime);
                    
                }
                DAL_sett.sErrorMsj = "";
            }

            catch (Exception ex)
            {
                DAL_sett.sErrorMsj = "An error has ocurred : \n" + ex.Message;
            }



        }

        public void addFolders(ref cls_settings_DAL DAL) 
        {
            //dont allow duplicate

            if (DAL.lsFolderList.Contains(DAL.sSharedPath))
            {
                DAL.sErrorMsj = "This path already exists, try adding another path";
                return;
            }

            else 
            { 
            
                //set shared folder as new location
                DAL.lsFolderList.Add(DAL.sSharedPath);
                //create a count for new folders
                DAL.iCount = DAL.lsFolderList.Count+1;

                //software path and save data
                DAL.sSoftwarePath= AppDomain.CurrentDomain.BaseDirectory;
                DAL.sSoftwareFile= Path.Combine(DAL.sSoftwarePath, "data.txt");
                File.WriteAllLines("data.txt", DAL.lsFolderList);
            }
        }


        public void readFile(ref cls_settings_DAL DAL) 
        {
            DAL.lsFolderList = new List<string>();
            //software path
            DAL.sSoftwarePath = AppDomain.CurrentDomain.BaseDirectory;
            DAL.sSoftwareFile = Path.Combine(DAL.sSoftwarePath, "data.txt");

            //read config files of paths
            if (File.Exists("data.txt"))
            {
                DAL.lsFolderList.AddRange(File.ReadAllLines("data.txt"));
            }



        }
    }
}
