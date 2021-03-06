﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;
using IrrKlang;
namespace DreamEdit
{

    public partial class Mediaplayer : UserControl
    {
     //   SoundPlayer player;
        Info info;
        string filepath;
        ISoundEngine soundPlayer;
        //[DllImport("winmm.dll")]
       // private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public Mediaplayer(Info info,string filepath)
        {
            InitializeComponent();
            this.info = info;
            //player = new SoundPlayer(filepath);
            this.filepath = filepath;
            soundPlayer = new ISoundEngine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Play2D(filepath);
     //       mciSendString("open \"" + filepath + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
     //       mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //player.Stop();
     //       mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            soundPlayer.StopAllSounds();
        }
    }
}
