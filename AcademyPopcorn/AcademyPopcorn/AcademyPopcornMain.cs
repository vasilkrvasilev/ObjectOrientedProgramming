﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            //Problem One - Create ceiling wall
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock ceilBlock = new IndestructibleBlock(new MatrixCoords(0, i));

                engine.AddObject(ceilBlock);
            }

            //Problem One - Create side walls
            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock leftBlock = new IndestructibleBlock(new MatrixCoords(i, 0));
                IndestructibleBlock rightBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));

                engine.AddObject(leftBlock);
                engine.AddObject(rightBlock);
            }

            for (int i = startCol; i < endCol; i++)
            {
                //Problem Nine - Test UnpassableBlock
                //UnpassableBlock currBlock = new UnpassableBlock(new MatrixCoords(startRow, i));

                //Problem Ten - Test ExplodingBlock
                //ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));

                //Problem Twelve - Test GiftBlock
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            //Problem Seven - Test MeteoriteBall
            //MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //Problem Nine - Test UnstoppableBall
            UnstoppableBall theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            //Problem Thirteen - Test ShootingRacket
            ShootingRacket theRacket = new ShootingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 500);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
