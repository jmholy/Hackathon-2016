using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMM_P3
{
    internal class PlaylistNode
    {
        string SongTitle;
        string FileName;
        PlaylistNode Prev, Next;

        public PlaylistNode(string name)
        {
            //SongTitle = name;
            FileName = name;
            string[] temp = name.Split('/');
            //SongTitle = temp.;
            Prev = this;
        }
    }
}
