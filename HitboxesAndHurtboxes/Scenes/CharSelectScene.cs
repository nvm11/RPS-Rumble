using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Character select scene
//displays changes for both player one and two side
namespace HitboxesAndHurtboxes.Scenes
{
    internal class CharSelectScene
    {
        public static Color[] characterClrs = { Color.White, Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Orange, Color.Pink, Color.Purple, Color.Brown };
        public int playerOneClr;
        public int playerTwoClr;

        /// <summary>
        /// instantiates a 
        /// </summary>
        public CharSelectScene()
        {
            playerOneClr = 0;
            playerTwoClr = 0;
        }
    }
}
