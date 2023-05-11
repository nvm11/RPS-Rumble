using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HitboxesAndHurtboxes.CoreFiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using HitboxesAndHurtboxes.Managers;

//draws the menu scene of the game
namespace HitboxesAndHurtboxes.Scenes
{
    internal class MenuScene : Component
    {
        public Input userInput;

        public static Button[] buttons;

        /// <summary>
        /// initializes the menu scene
        /// </summary>
        /// <param name="content"></param>
        public override void Initialize(ContentManager content)
        {
            userInput = new Input();
            buttons = new Button[3];
            for (int i = 1; i <= buttons.Length; i++)
            {
                Texture2D tempButtontext = content.Load<Texture2D>($"button{i}");
                buttons[i] = new Button(tempButtontext, new Rectangle((Data.ScreenWidth - tempButtontext.Width) / 2, ((Data.ScreenHeight - tempButtontext.Height) / 2) * i, tempButtontext.Width, tempButtontext.Height));
            }
        }

        /// <summary>
        /// updates the current state of the game based on user input
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            if (buttons[0].BoundingBox.Contains(userInput.ms.Position) && userInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //play
            {
                Data.CurrentState = 1;
            }

            if (buttons[1].BoundingBox.Contains(userInput.ms.Position) && userInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //options
            {
                Data.CurrentState = 2;
            }

            if (buttons[2].BoundingBox.Contains(userInput.ms.Position) && userInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //exit
            {
                Data.Exit = true;
            }
        }

        /// <summary>
        /// draws menu scene
        /// </summary>
        /// <param name="sb">_spritebatch</param>
        /// <param name="gameTime">_gameTime</param>
        public override void Draw(SpriteBatch sb, GameTime gameTime)
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].BoundingBox.Intersects(userInput.mouseRect))
                {
                    sb.Draw(buttons[i].Texture, buttons[i].BoundingBox, Color.Gray);
                }

                else
                {
                    sb.Draw(buttons[i].Texture, buttons[i].BoundingBox, Color.White);
                }
            }
        }
    }
}
