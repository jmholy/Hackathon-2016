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

        public PlaylistContainer()
        {
            Curr = null;
        }

        public PlaylistContainer(string FileName)
        {
            Curr = new PlaylistNode(FileName);

        }

        public PlaylistContainer(string[] Folder)
        {
            Curr = new PlaylistNode(Folder[0]);
            for (int i = 1; i < Folder.Length; i++)
            {
                addSong(Folder[i]);
            }
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

        public void addSong (string fileName)
        {
            PlaylistNode Temp;

            if (Curr != null)
            {
                Temp = new PlaylistNode(fileName, Curr);
            }
            else
            {
                Curr = new PlaylistNode(fileName);
            }

        }

        public string getSongName()
        {
            return Curr.SongTitle;
        }

        public string getFileName()
        {
            return Curr.FileName;
        }

        public string nextSong()
        {
            if (Curr.Next != null)
            {
                Curr = Curr.Next;
                return Curr.FileName;
            }
            return null;  
        }

        public string prevSong()
        {
            if (Curr.Prev != null)
            {
                Curr = Curr.Prev;
                return Curr.FileName;
            }
            return null;
        }

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
                string[] temp = name.Split('\\');
                SongTitle = temp.Last<string>();
                Prev = null;
                Next = null;
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
