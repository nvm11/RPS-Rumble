using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitboxesAndHurtboxes
{
    internal class Button
    {
        /// <summary>
        /// button's texture
        /// </summary>
        public Texture2D Texture { get; set; }

        /// <summary>
        /// bounding box
        /// </summary>
        public Rectangle BoundingBox { get; set; }

        /// <summary>
        /// Creates a button object with a 
        /// texture and bounding box
        /// </summary>
        /// <param name="texture">texture of the button</param>
        /// <param name="boundingBox">rectangle that contains button</param>
        public Button(Texture2D texture, Rectangle boundingBox)
        {
            this.Texture = texture;
            this.BoundingBox = boundingBox;
        }
    }
}
