﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
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
        public Rectangle mouseRect;

        /// <summary>
        /// updates the mouse's position and bounding box
        /// </summary>
        /// <param name="gameTime">gameTime</param>
        public void UpdateMouse(GameTime gameTime)
        {
            prevMs = ms;
            ms = Mouse.GetState();
            mouseRect = new Rectangle(ms.X, ms.Y, 1, 1);
        }

        /// <summary>
        /// updates the keyboard's input
        /// </summary>
        /// <param name="gameTime">gameTime</param>
        public void UpdateKeyboard(GameTime gameTime)
        {

        }
    }
}