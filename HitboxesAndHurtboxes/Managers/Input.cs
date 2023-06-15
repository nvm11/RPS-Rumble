using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//manages user input
//current implementation keeps track of mouse input
namespace HitboxesAndHurtboxes.Managers
{
    internal class Input
    {
        public MouseState ms;
        public MouseState prevMs;

        public KeyboardState kb;
        public KeyboardState prevKB;

        public Point mousePos;

        /// <summary>
        /// updates the mouse's position and bounding box
        /// </summary>
        /// <param name="gameTime">gameTime</param>
        public void UpdateMouse(GameTime gameTime)
        {
            prevMs = ms;
            ms = Mouse.GetState();
            mousePos = ms.Position;
        }

        /// <summary>
        /// updates the keyboard's input
        /// </summary>
        /// <param name="gameTime">gameTime</param>
        public void UpdateKeyboard(GameTime gameTime)
        {
            prevKB = kb;
            kb = Keyboard.GetState();
        }

        /// <summary>
        /// checks if a key was pressed a single time
        /// </summary>
        /// <param name="key">key to check status of</param>
        /// <returns>true if key was released, false otherwise</returns>
        public bool SingleKeyPress(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key) && prevKB.IsKeyUp(key);
        }

        /// <summary>
        /// checks if the left mouse button was released
        /// </summary>
        /// <returns>true if it was pressed and released, false otherwise</returns>
        public bool LeftButtonReleased()
        {
            return ms.LeftButton == ButtonState.Released && prevMs.LeftButton == ButtonState.Pressed;
        }

    }
}
