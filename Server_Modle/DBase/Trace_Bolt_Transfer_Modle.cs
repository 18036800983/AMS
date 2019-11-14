using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Trace_Bolt_Transfer_Modle
    {
        private int iD;
        private string boltName;
        private string boltNo;
        private int programNo;
        private string torque;
        private string maxTorque;
        private string minTorque;
        private string angle;
        private string maxAngle;
        private string minAngle;
        private string result;
        private string sN;
        private string station;
        private string recordTime;

        public int ID { get => iD; set => iD = value; }
        public string BoltName { get => boltName; set => boltName = value; }
        public string BoltNo { get => boltNo; set => boltNo = value; }
        public int ProgramNo { get => programNo; set => programNo = value; }
        public string Torque { get => torque; set => torque = value; }
        public string MaxTorque { get => maxTorque; set => maxTorque = value; }
        public string MinTorque { get => minTorque; set => minTorque = value; }
        public string Angle { get => angle; set => angle = value; }
        public string MaxAngle { get => maxAngle; set => maxAngle = value; }
        public string MinAngle { get => minAngle; set => minAngle = value; }
        public string Result { get => result; set => result = value; }
        public string SN { get => sN; set => sN = value; }
        public string Station { get => station; set => station = value; }
        public string RecordTime { get => recordTime; set => recordTime = value; }
    }
}
