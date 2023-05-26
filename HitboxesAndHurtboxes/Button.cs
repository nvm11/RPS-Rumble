using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
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
        /// Scale of the image displayed on the button
        /// </summary>
        public float Scale { get; set; }

        /// <summary>
        /// gets o sets the sprite effect of the button
        /// </summary>
        public SpriteEffects SpriteEffect { get; set; }

        /// <summary>
        /// Creates a button object with a 
        /// texture and bounding box
        /// </summary>
        /// <param name="texture">texture of the button</param>
        /// <param name="boundingBox">rectangle that contains button</param>
        /// <param name="color">color of the button</param>
        public Button(Texture2D texture, Rectangle boundingBox, Color color, SpriteEffects spriteEffect)
        {
            this.Texture = texture;
            this.BoundingBox = boundingBox;
            this.ButtonColor = color;
            this.SpriteEffect = spriteEffect;
            this.Scale = boundingBox.Width / texture.Width;
        }

        /// <summary>
        /// overload to create a button with no SpriteEffects
        /// </summary>
        /// <param name="texture">texture of button</param>
        /// <param name="boundingBox">bounding box</param>
        /// <param name="color">color of the button</param>
        public Button(Texture2D texture, Rectangle boundingBox, Color color)
            : this(texture, boundingBox, color, SpriteEffects.None) { }

        /// <summary>
        /// creates a button with a default color of white and no SpriteEffects
        /// </summary>
        /// <param name="texture">texture of button</param>
        /// <param name="boundingBox">rectangle of the button</param>
        public Button(Texture2D texture, Rectangle boundingBox)
            : this(texture, boundingBox, Color.White, SpriteEffects.None) { }

        public Button(Texture2D texture, Rectangle boundingBox, SpriteEffects spriteEffect)
            : this(texture, boundingBox, Color.White, spriteEffect) { }

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

        /// <summary>
        /// draws the button 
        /// </summary>
        public void Draw(SpriteBatch sb, Vector2 position)
        {
            sb.Draw(this.Texture, position, BoundingBox, this.ButtonColor, 0.0f, Vector2.Zero, this.Scale, this.SpriteEffect, 1.0f);
        }
    }
}
