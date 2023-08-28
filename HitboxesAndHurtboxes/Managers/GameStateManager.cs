using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HitboxesAndHurtboxes.CoreFiles;
using HitboxesAndHurtboxes.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

//handles what state the game is in
namespace HitboxesAndHurtboxes.Managers
{
    public class GameStateManager : Component
    {
        MenuScene ms = new MenuScene();
        CharSelectScene cs = new CharSelectScene();
        

        /// <summary>
        /// initializes the menu scene
        /// </summary>
        /// <param name="content">content manager</param>
        public override void Initialize(ContentManager content)
        {
            ms.Initialize(content);
            cs.Initialize(content);
        }

        /// <summary>
        /// updates the game state
        /// </summary>
        /// <param name="gameTime">gameTime</param>
        public override void Update(GameTime gameTime)
        {
            switch (Data.CurrentState)
            {
                case 0: //menu
                    ms.Update(gameTime);
                    break;

                case 1: //char select
                    cs.Update(gameTime);
                    break;

                case 2: //options
                    break;

                case 3: //gameplay
                    break;
            }
        }

        /// <summary>
        /// draws the current game state
        /// </summary>
        /// <param name="sb">_spritebatch</param>
        /// <param name="gameTime">gameTime</param>
        public override void Draw(SpriteBatch sb, GameTime gameTime)
        {
            switch (Data.CurrentState)
            {
                case 0: //menu
                    ms.Draw(sb, gameTime);
                    break;

                case 1: //char select
                    cs.Draw(sb, gameTime);
                    break;

                case 2: //options
                    break;

                case 3: //gameplay
                    break;
            }
        }
    }
}
