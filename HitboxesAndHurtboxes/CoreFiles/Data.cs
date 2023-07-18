using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//handles static variables used throughout most classes
namespace HitboxesAndHurtboxes.CoreFiles
{
    public static class Data
    {
        /// <summary>
        /// gets or dets screen width
        /// default is 1600
        /// </summary>
        public static int ScreenWidth { get; set; } = 1600;

        /// <summary>
        /// gets or sets screen width
        /// default is 900
        /// </summary>
        public static int ScreenHeight { get; set; } = 900;

        /// <summary>
        /// gets or sets current state of the game
        /// default is 0 (menu)
        /// 1 is char select
        /// 2 is options
        /// 3 is gameplay
        /// </summary>
        public static int CurrentState { get; set; } = 0;

        /// <summary>
        /// condition for the game to close
        /// </summary>
        public static bool Exit { get; set; } = false;
    }
}
