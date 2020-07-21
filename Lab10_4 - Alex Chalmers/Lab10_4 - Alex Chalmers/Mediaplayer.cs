using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4___Alex_Chalmers
{
    class Mediaplayer
    {
        public void PlayMedia(IAudioplayer media)
        {
            media.Play();
        }
    }
}
