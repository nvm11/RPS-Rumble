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

        public Player p1;
        public Player p2;

        public Color p1Color;
        public Color p2Color;

        float counter;

        public override void Initialize(ContentManager content)
        {
            userInput = new Input();
            p1 = new Player();
            p2 = new Player();
            counter = 0.0f;
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
    }
}
