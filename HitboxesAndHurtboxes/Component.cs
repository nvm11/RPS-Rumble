using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//abstract components used throughout most classes
namespace HitboxesAndHurtboxes
{
    public abstract class Component
    {
        /// <summary>
        /// initializes the component
        /// </summary>
        /// <param name="content">content manager</param>
        public abstract void Initialize(ContentManager content);

        /// <summary>
        /// updates status of the component
        /// </summary>
        /// <param name="gameTime">gametime obj</param>
        public abstract void Update(GameTime gameTime);

        /// <summary>
        /// draws component to screen
        /// </summary>
        /// <param name="sb">_spritebatch obj</param>
        /// <param name="gameTime">gametime obj</param>
        public abstract void Draw(SpriteBatch sb, GameTime gameTime);
    }
}
