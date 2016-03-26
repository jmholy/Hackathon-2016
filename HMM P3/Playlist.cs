using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMM_P3
{
    public class PlaylistContainer
    {
        PlaylistNode Curr;

        public PlaylistContainer(string FileName)
        {
            Curr = new PlaylistNode(FileName);

        }

        public void addSong()
        {
            PlaylistNode Temp;
            OpenFileDialog fileopener = new OpenFileDialog();


            fileopener.ShowDialog();
            if (Curr != null)
            {
                Temp = new PlaylistNode(fileopener.FileName, Curr);
            }
            else
            {
                Curr = new PlaylistNode(fileopener.FileName);
            }
        }

        public string getSongName()
        {
            return Curr.SongTitle;
        }

        public string nextSong()
        {
            Curr = Curr.Next;
            return Curr.FileName;
        }

        public string prevSong()
        {
            Curr = Curr.Prev;
            return Curr.FileName;
        }
        /*        public void Alphasort(bool normal)
                {
                    if (normal)
                    {

                    }
                    else
                    {

                    }
                }
        */
        internal class PlaylistNode
        {
            internal string SongTitle;
            internal string FileName;
            internal PlaylistNode Prev, Next;

            public PlaylistNode(string name)
            {
                FileName = name;
                string[] temp = name.Split('/');
                SongTitle = temp.Last<string>();
                Prev = this;
                Next = this;
            }
            public PlaylistNode(string name, PlaylistNode CompleteList)
            {
                FileName = name;
                string[] temp = name.Split('/');
                SongTitle = temp.Last<string>();
                Prev = CompleteList;
                Next = CompleteList.Next;
                CompleteList.Next = this;
            }
        }
    }
}
