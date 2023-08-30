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
    internal class GameScene : Component
    {

        public Input userInput;

        private Texture2D rockText;
        private Texture2D paperText;
        private Texture2D scissorsText;

        private Texture2D idleSpriteSheet;
        private Texture2D rockSprieSheet;
        private Texture2D paperSpriteSheet;
        private Texture2D scissorsSpriteSheet;

        private Animation idleAnim;
        private Animation rockAnim;
        private Animation paperAnim;
        private Animation scissorsAnim;



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
