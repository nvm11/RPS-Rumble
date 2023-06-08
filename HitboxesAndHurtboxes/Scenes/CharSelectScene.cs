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

//Character select scene
//displays changes for both player one and two side
namespace HitboxesAndHurtboxes.Scenes
{
    internal class CharSelectScene : Component
    {
        public Input useerInput;

        public static Color[] characterClrs = { Color.White, Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Orange, Color.Pink, Color.Purple, Color.Brown };
        public int playerOneClr;
        public int playerTwoClr;

        private Texture2D charSelectText;
        private Texture2D arrowButtonText;

        private Animation playerOneSelect;
        private Animation playerTwoSelect;

        private Button playerOneLeft;
        private Button playerOneRight;

        private Button playerTwoLeft;
        private Button playerTwoRight;

        private Button[] buttons;
        public override void Initialize(ContentManager content)
        {
            useerInput = new Input();

            playerOneClr = 0;
            playerTwoClr = 0;

            charSelectText = content.Load<Texture2D>("RPS_CharSelect");
            arrowButtonText = content.Load<Texture2D>("Arrow");

            playerOneSelect = new Animation(charSelectText, 6, 1, 6);
            playerTwoSelect = new Animation(charSelectText, 6, 1, 6);
            playerOneSelect.Position = new Vector2(Data.ScreenWidth / 4, Data.ScreenHeight / 2);
            playerTwoSelect.Position = new Vector2(Data.ScreenWidth - (Data.ScreenWidth / 4), Data.ScreenHeight / 2);

            playerOneLeft = new Button(arrowButtonText, new Rectangle((int)(playerOneSelect.Position.X - 50), (int)playerOneSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4), SpriteEffects.FlipHorizontally);
            playerOneRight = new Button(arrowButtonText, new Rectangle((int)(playerOneSelect.Position.X + playerOneSelect.SourceRectangle.Width + 50), (int)playerOneSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4));

            playerTwoLeft = new Button(arrowButtonText, new Rectangle((int)(playerTwoSelect.Position.X - 50), (int)playerTwoSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4), SpriteEffects.FlipHorizontally);
            playerTwoRight = new Button(arrowButtonText, new Rectangle((int)(playerTwoSelect.Position.X + playerTwoSelect.SourceRectangle.Width + 50), (int)playerTwoSelect.Position.Y, arrowButtonText.Width / 4, arrowButtonText.Height / 4));

            buttons = new Button[4];
            buttons[0] = playerOneLeft;
            buttons[1] = playerOneRight;
            buttons[2] = playerTwoLeft;
            buttons[3] = playerTwoRight;
        }

        public override void Update(GameTime gameTime)
        {
            useerInput.UpdateMouse(gameTime);

            foreach(Button button in buttons)
            {
                button.Update(useerInput.mousePos);
            }

            if (playerOneLeft.ButtonColor == Color.Gray && useerInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                playerOneClr -= 1;
                if (playerOneClr < 0)
                {
                    playerOneClr = characterClrs.Length - 1;
                }

            }

            else if (playerTwoLeft.ButtonColor == Color.Gray && useerInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                playerTwoClr -= 1;
                if (playerTwoClr < 0)
                {
                    playerTwoClr = characterClrs.Length - 1;
                }

            }

            else if (playerOneRight.ButtonColor == Color.Gray && useerInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                playerOneClr += 1;
                if (playerOneClr == characterClrs.Length)
                {
                    playerOneClr = 0;
                }

            }

            else if (playerTwoRight.ButtonColor == Color.Gray && useerInput.ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                playerTwoClr += 1;
                if (playerTwoClr == characterClrs.Length)
                {
                    playerTwoClr = 0;
                }

            }

            playerOneSelect.UpdateAnimation(gameTime);
            playerTwoSelect.UpdateAnimation(gameTime);
        }

        public override void Draw(SpriteBatch sb, GameTime gameTime)
        {
            foreach(Button button in buttons)
            {
                button.Draw(sb);
            }

            playerOneSelect.Draw(sb, gameTime);
            playerTwoSelect.Draw(sb, gameTime);
        }
    }
}
