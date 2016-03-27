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

        public string nextSong(int repeat)
        {
            if (repeat == 0)
            {
                return Curr.FileName;
            }
            else
            {
                PlaylistNode start = Curr;
                while (start.Prev != null)
                {
                    start = start.Prev;
                }
                return start.FileName;
            }
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

        public List<string> SongList()
        {
            PlaylistNode current = Curr;
            List<string> playlistlist = new List<string>();

            while (current.Prev != null)
            {
                current = current.Prev;
            }

            if (current.Next == null)
            {
                playlistlist.Add(current.SongTitle);
            }

            while (current.Next != null)
            {
                playlistlist.Add(current.SongTitle);
                current = current.Next;
            }

            return playlistlist;
        }
             
        //public string Remove(string fileName)
        //{
        //    //PlaylistNode temp = Curr.Prev;
        //    //temp.Next = null;

        //}
}

    internal class PlaylistNode
    {
        internal string SongTitle;
        internal string FileName;
        internal PlaylistNode Prev, Next;

        public PlaylistNode(string name)
        {
            FileName = name;
            string[] temp = name.Split('\\');
            SongTitle = temp[temp.Length-1];
            temp = SongTitle.Split('.');
            SongTitle = temp[0];

            Prev = null;
            Next = null;
         }
        public PlaylistNode(string name, PlaylistNode CompleteList)
         {
            FileName = name;
            string[] temp = name.Split('\\');
            SongTitle = temp[temp.Length - 1];
            temp = SongTitle.Split('.');
            SongTitle = temp[0];

            //Prev = CompleteList;
            //Next = CompleteList.Next;
            //if (CompleteList.Next != null)
            //{
            //    CompleteList.Next.Prev = this;
            //}

            //CompleteList.Next = this;
            PlaylistNode current = CompleteList;
            
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new PlaylistNode(name);
            current.Next.Prev = current;
        }
    }
}
