﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //Problem Eight - Create UnpassableBlock
    public class UnpassableBlock : IndestructibleBlock
    {
        private const char Symbol = '$';

        public UnpassableBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }
    }
}
