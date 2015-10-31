using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Rhythm.Engine.Section;

namespace Rhythm.Engine
{
    class Chart
    {
        String title;
        String difficulty;
        Section[] sections;

        public List<Section> assembleSections(String chartFile){
            List<Section> secs = new List<Section>();
            using (StreamReader sr = File.OpenText(chartFile))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Section sec = new Section();
                    int BPM = Int32.Parse(line.Split('-').ElementAt(0));
                    int[] notes = Array.ConvertAll(
                        line.Split('-').ElementAt(1).Split(','),
                        s => int.Parse(s));
                    sec.BPM = BPM;
                    sec.setNotes(notes);
                    secs.Add(sec);
                }
            }
            return secs;
        }
    }
}
