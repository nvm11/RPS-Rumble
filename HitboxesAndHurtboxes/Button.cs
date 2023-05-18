using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        /// gets or sets the color of the button
        /// </summary>
        public Color ButtonColor { get; set; }

        /// <summary>
        /// Creates a button object with a 
        /// texture and bounding box
        /// </summary>
        /// <param name="texture">texture of the button</param>
        /// <param name="boundingBox">rectangle that contains button</param>
        /// <param name="color">color of the button</param>
        public Button(Texture2D texture, Rectangle boundingBox, Color color)
        {
            this.Texture = texture;
            this.BoundingBox = boundingBox;
            this.ButtonColor = color;
        }

        /// <summary>
        /// creates a button with a default color of white
        /// </summary>
        /// <param name="texture">texture of button</param>
        /// <param name="boundingBox">rectangle of the button</param>
        public Button(Texture2D texture, Rectangle boundingBox)
            : this(texture, boundingBox, Color.White) { }

        /// <summary>
        /// updates the color of the button
        /// </summary>
        /// <param name="mouseRect">mouse's position (rectangle)</param>
        public void Update(Point mousePos)
        {
            if (this.BoundingBox.Contains(mousePos))
            {
                this.ButtonColor = Color.Gray;
            }

            else
            {
                this.ButtonColor = Color.White;
            }
        }
    }
}
