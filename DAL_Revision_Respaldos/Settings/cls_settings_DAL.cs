using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Revision_Respaldos.Settings
{
    public class cls_settings_DAL
    {

        #region Private
        private string _sSharedPath, _sFile, _sFileDate, _sErrorMsj, _sSoftwarePath, _sSoftwareFile;
        private string[] _aFileDirectory;

        private List<string> _lsFolderList;
        private int _iCount;
        #endregion

        #region Public
        public string sSharedPath { get => _sSharedPath; set => _sSharedPath = value; }
        public string sFile { get => _sFile; set => _sFile = value; }
        public string sFileDate { get => _sFileDate; set => _sFileDate = value; }
        public string[] aFileDirectory { get => _aFileDirectory; set => _aFileDirectory = value; }
        public string sErrorMsj { get => _sErrorMsj; set => _sErrorMsj = value; }
        public List<string> lsFolderList { get => _lsFolderList; set => _lsFolderList = value; }
        public int iCount { get => _iCount; set => _iCount = value; }
        public string sSoftwarePath { get => _sSoftwarePath; set => _sSoftwarePath = value; }
        public string sSoftwareFile { get => _sSoftwareFile; set => _sSoftwareFile = value; }
        #endregion
    }
}
