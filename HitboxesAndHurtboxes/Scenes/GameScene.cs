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


//manages the gameplay scene of the game
namespace HitboxesAndHurtboxes.Scenes
{
    public enum playerState
    {
        Idle,
        Rock,
        Paper,
        Scissors,
        TakeDamage
    }


    internal class GameScene : Component
    {
        public Input userInput;
        private bool P1Input;
        private bool P2Input;

        public override void Initialize(ContentManager content)
        {
            userInput = new Input();
        }

        public override void Update(GameTime gameTime)
        {
            //update timer
            //check if players have input
            //handle interraction accordingly
            //reset
        }

        public override void Draw(SpriteBatch sb, GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// checks if player 1 has input a selection
        /// and either stops or continues checking
        /// temp control scheme: a,w,d
        /// </summary>
        private void CheckPlayer1Input()
        {
            if (userInput.kb.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.A))
            {
                //select option
            }
        }

        /// <summary>
        /// checks if player 2 has input a selection
        /// and either stops or continues checking
        /// temp control scheme: leftArr, upArr, rightArr
        /// </summary>
        private void CheckPlayer2Input()
        {

        }
    }
}
