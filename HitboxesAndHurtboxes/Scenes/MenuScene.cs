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

        public static int scalingFactor;

        /// <summary>
        /// initializes the menu scene
        /// </summary>
        /// <param name="content"></param>
        public override void Initialize(ContentManager content)
        {
            userInput = new Input();
            buttons = new Button[3];

            scalingFactor = 10;

            for (int i = 0; i < buttons.Length; i++)
            {
                Texture2D tempButtontext = content.Load<Texture2D>($"button{i}");
                int width = tempButtontext.Width / scalingFactor;
                int height = tempButtontext.Height / scalingFactor;
                buttons[i] = new Button(tempButtontext, new Rectangle((Data.ScreenWidth - width) / 2, ((Data.ScreenHeight - height) / 2) + (int)(i * height * 1.5), width, height));
            }
        }

        /// <summary>
        /// updates the current state of the game based on user input
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            //update input
            userInput.UpdateMouse(gameTime);

            //update buttons
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Update(userInput.mousePos);
            }

            //change state if needed

            if (buttons[0].ButtonColor == Color.Gray  && userInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //char select
            {
                Data.CurrentState = 1;
            }

            if (buttons[1].ButtonColor == Color.Gray && userInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //options
            {
                Data.CurrentState = 2;
            }

            if (buttons[2].ButtonColor == Color.Gray && userInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //exit
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
            foreach(Button button in buttons)
            {
                button.Draw(sb);
            }
        }
    }
}
