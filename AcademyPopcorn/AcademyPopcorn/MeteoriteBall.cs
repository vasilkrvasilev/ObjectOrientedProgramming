using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //Problem Six - Create MeteoriteBall
    public class MeteoriteBall : Ball
    {
        public const int TrailLife = 3;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        protected override void UpdatePosition()
        {
            this.TopLeft += this.Speed;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> array = new List<TrailObject>();
            TrailObject trail = new TrailObject(this.topLeft, new char[,] { { '.' } }, TrailLife);
            array.Add(trail);
            return array;
        }
    }
}
