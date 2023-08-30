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

        public Vector2 p1Pos;
        public Vector2 p2Pos;

        float counter;

        public override void Initialize(ContentManager content)
        {
            rockText = content.Load<Texture2D>("RPS_RockFinal");
            paperText = content.Load<Texture2D>("RPS_PaperFinal");
            scissorsText = content.Load<Texture2D>("RPS_ScissorsFinal");

            idleSpriteSheet = content.Load<Texture2D>("RPS_IdleAnim");
            rockSprieSheet = content.Load<Texture2D>("RPS_RockAnim");
            paperSpriteSheet = content.Load<Texture2D>("RPS_PaperAnim");
            scissorsSpriteSheet = content.Load<Texture2D>("RPS_ScissorsAnim");

            idleAnim = new Animation(idleSpriteSheet, 1, 2, 3);
            rockAnim = new Animation(rockSprieSheet, 3, 3, 20);
            paperAnim = new Animation(paperSpriteSheet, 3, 3, 20);
            scissorsAnim = new Animation(scissorsSpriteSheet, 3, 3, 20);

            //p1Pos set equal distance from each other
            //p2Pos set equal distance from each other

            userInput = new Input();
            p1 = new Player(idleAnim.Clone(), rockAnim.Clone(), paperAnim.Clone(), scissorsAnim.Clone(), CharSelectScene.characterClrs[CharSelectScene.playerOneClr], p1Pos);
            p2 = new Player(idleAnim.Clone(), rockAnim.Clone(), paperAnim.Clone(), scissorsAnim.Clone(), CharSelectScene.characterClrs[CharSelectScene.playerTwoClr], p2Pos, SpriteEffects.FlipHorizontally);
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
