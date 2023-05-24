using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitboxesAndHurtboxes
{
    internal class Player
    {
        private float health;
        private RectangleF boundingBox;

        /// <summary>
        /// instantiates a player object with a specified
        /// health and bounding box
        /// </summary>
        /// <param name="health"></param>
        /// <param name="boundingBox"></param>
        public Player(float health, RectangleF boundingBox)
        {
            this.health = health;
            this.boundingBox = boundingBox;
        }

        /// <summary>
        /// instantiates a player obj with specified bounding box 
        /// and default health value of 100.0
        /// </summary>
        /// <param name="boundingBox"></param>
        public Player(Rectangle boundingBox)
        :this(100.0f, boundingBox){ }

        /// <summary>
        /// gets or sets the value of the player's health
        /// </summary>
        public float Health
        {
            get { return health; }
            set { health = value; }
        }


    }
}
