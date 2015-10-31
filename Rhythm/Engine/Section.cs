using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rhythm.Engine
{
    /// <summary>
    /// Section of charts. Each section is defined by a set of notes at constant BPM.
    /// </summary>
    class Section
    {
        public String name;
        private int[] notes;
        public int BPM;

        public void setNotes(int[] n)
        {
            notes = n;
        }
    }
}
