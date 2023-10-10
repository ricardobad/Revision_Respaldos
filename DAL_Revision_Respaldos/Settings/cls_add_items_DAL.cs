using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Revision_Respaldos.Settings
{
    public class cls_add_items_DAL
    {
        #region Private

        private string[] _aServers;
        private byte _bFlag, _bIdleTest;



        #endregion

        #region Public
        public string[] aServers { get => _aServers; set => _aServers = value; }
        public byte bFlag { get => _bFlag; set => _bFlag = value; }
        public byte bIdleTest { get => _bIdleTest; set => _bIdleTest = value; }

        #endregion



    }
}
