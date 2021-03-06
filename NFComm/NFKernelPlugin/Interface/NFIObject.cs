using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFrame
{
    public abstract class NFIObject
    {
        public enum CLASS_EVENT_TYPE
        {
			OBJECT_DESTROY,
            OBJECT_CREATE,
			OBJECT_LOADDATA,
			OBJECT_CREATE_FINISH,
        }

        public delegate void ClassEventHandler(NFGUID self, int nContainerID, int nGroupID, CLASS_EVENT_TYPE eType, string strClassName, string strConfigIndex);

        public abstract void Init();
        public abstract void Shut();

        public abstract bool UpData(float fLastTime, float fAllTime);

        ///////////////////////////////////////////////////////////////////////
        public abstract NFGUID Self();
		public abstract int ContainerID();
		public abstract int GroupID();
        public abstract string ClassName();
        public abstract string ConfigIndex();

        public abstract void AddHeartBeat(string strHeartBeatName, float fTime, int nCount, NFIHeartBeat.HeartBeatEventHandler handler);
        public abstract bool FindHeartBeat(string strHeartBeatName);
        public abstract void RemoveHeartBeat(string strHeartBeatName);

        /////////////////////////////////////////////////////////////////

        public abstract bool FindProperty(string strPropertyName);

        public abstract bool SetPropertyInt(string strPropertyName, Int64 nValue);
        public abstract bool SetPropertyFloat(string strPropertyName, float fValue);
        public abstract bool SetPropertyDouble(string strPropertyName, double dwValue);
        public abstract bool SetPropertyString(string strPropertyName, string strValue);
        public abstract bool SetPropertyObject(string strPropertyName, NFGUID obj);

        public abstract Int64 QueryPropertyInt(string strPropertyName);
        public abstract float QueryPropertyFloat(string strPropertyName);
        public abstract double QueryPropertyDouble(string strPropertyName);
        public abstract string QueryPropertyString(string strPropertyName);
        public abstract NFGUID QueryPropertyObject(string strPropertyName);

        public abstract bool FindRecord(string strRecordName);

        public abstract bool SetRecordInt(string strRecordName, int nRow, int nCol, Int64 nValue);
        public abstract bool SetRecordFloat(string strRecordName, int nRow, int nCol, float fValue);
        public abstract bool SetRecordDouble(string strRecordName, int nRow, int nCol, double dwValue);
        public abstract bool SetRecordString(string strRecordName, int nRow, int nCol, string strValue);
        public abstract bool SetRecordObject(string strRecordName, int nRow, int nCol, NFGUID obj);

        public abstract Int64 QueryRecordInt(string strRecordName, int nRow, int nCol);
        public abstract float QueryRecordFloat(string strRecordName, int nRow, int nCol);
        public abstract double QueryRecordDouble(string strRecordName, int nRow, int nCol);
        public abstract string QueryRecordString(string strRecordName, int nRow, int nCol);
        public abstract NFGUID QueryRecordObject(string strRecordName, int nRow, int nCol);

        public abstract NFIRecordManager GetRecordManager();
        public abstract NFIPropertyManager GetPropertyManager();
        public abstract NFIHeartBeatManager GetHeartBeatManager();

    }
}