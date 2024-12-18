using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAMAB.InputItems
{
    class AllSensorsItem : ResponseItemBase
    {
        public byte m_bazMode;
        public float m_traverseAngleGunnerMirror;
        public float m_jackingAngleGunnerMirror;
        public byte m_solonoidJacking;
        public byte m_solonoidTraverse;
        public float m_sachiputResetValueTraverse;
        public float m_sachiputResetValueJacking;
        public byte m_driftCalibrationStatus;
    }
}
